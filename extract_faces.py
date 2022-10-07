import cv2
import glob

faceDet = cv2.CascadeClassifier("classifiers/haarcascade_frontalface_default.xml")
faceDet2 = cv2.CascadeClassifier("classifiers/haarcascade_frontalface_alt2.xml")
faceDet3 = cv2.CascadeClassifier("classifiers/haarcascade_frontalface_alt.xml")
faceDet4 = cv2.CascadeClassifier("classifiers/haarcascade_frontalface_alt_tree.xml")

# Emotions
emotions = ["neutral", "anger", "contempt", "disgust", "fear", "happy", "sadness", "surprise"] 

print( "           __  __     _    _        \n    /\\    / _|/ _|   | |  | |       \n   /  \\  | |_| |_ ___| | _| |_ __ _ \n  / /\\ \\ |  _|  _/ _ \\ |/ / __/ _` |\n / ____ \\| | | ||  __/   <| || (_| |\n/_/    \\_\\_| |_| \\___|_|\\_\\\\__\\__,_|\n")

def detect_faces(emotion):
    files = glob.glob("datasets/sorted_dataset/%s/*" %emotion) # Get list of all images with emotion
    filenumber = 0
    for f in files:
        frame = cv2.imread(f) # Open image
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY) # Convert image to grayscale
        
        # Detect face using 4 different classifiers
        face = faceDet.detectMultiScale(gray, scaleFactor=1.1, minNeighbors=10, minSize=(5, 5), flags=cv2.CASCADE_SCALE_IMAGE)
        face2 = faceDet2.detectMultiScale(gray, scaleFactor=1.1, minNeighbors=10, minSize=(5, 5), flags=cv2.CASCADE_SCALE_IMAGE)
        face3 = faceDet3.detectMultiScale(gray, scaleFactor=1.1, minNeighbors=10, minSize=(5, 5), flags=cv2.CASCADE_SCALE_IMAGE)
        face4 = faceDet4.detectMultiScale(gray, scaleFactor=1.1, minNeighbors=10, minSize=(5, 5), flags=cv2.CASCADE_SCALE_IMAGE)

        # Go over detected faces, stop at first detected face, return empty if no face.
        if len(face) == 1:
            facefeatures = face
        elif len(face2) == 1:
            facefeatures == face2
        elif len(face3) == 1:
            facefeatures = face3
        elif len(face4) == 1:
            facefeatures = face4
        else:
            facefeatures = ""
        
        # Cut and save face
        for (x, y, w, h) in facefeatures: # Get coordinates and size of rectangle containing face
            print( "Face detected in file: %s" %f)
            gray = gray[y:y+h, x:x+w] # Cut the frame to size
            
            try:
                out = cv2.resize(gray, (350, 350)) # Resize face so all images have same size
                cv2.imwrite("datasets/faces_dataset/%s/%s.jpg" %(emotion, filenumber), out) # Write image
            except:
               pass # If error, pass file
        filenumber += 1 # Increment image number

for emotion in emotions: 
    detect_faces(emotion)
