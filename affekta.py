import cv2
import numpy as np

emotions = ["anger", "happy", "sadness"]
face_classifier = cv2.face.createFisherFaceRecognizer()
face_classifier.load("models/model_2022-09-26-22-44-33_61.111111111111114.xml")
face_detector = cv2.CascadeClassifier("classifiers/haarcascade_frontalface_default.xml")
font = cv2.FONT_HERSHEY_SIMPLEX


def detect_face(raw_image):
	face = face_detector.detectMultiScale(raw_image, scaleFactor=1.1, minNeighbors=20, minSize=(5, 5), flags=cv2.CASCADE_SCALE_IMAGE)
	if len(face) == 1:
		return face
	else:
		return ""

def run_realtime():
	print("Running real-time emotion detection..")
	cam = cv2.VideoCapture(0)
	while True:
		ret_val, current_frame = cam.read()
		cv2.imshow('Affekta',current_frame)
		gray = cv2.cvtColor(current_frame,cv2.COLOR_BGR2GRAY)
		detected_face_coordinates = detect_face(gray)
		for (x, y, w, h) in detected_face_coordinates:
			gray_cropped_face = gray[y:y+h, x:x+w]
			gray_face = cv2.resize(gray_cropped_face, (350, 350))
			pred, conf = face_classifier.predict(gray_face)
			current_emotion = str(emotions[pred][0].upper())+str(emotions[pred][1:])
			cv2.putText(current_frame,current_emotion,(10,300), font, 1.5,(63,63,63),2)
			cv2.imshow('Affekta',current_frame)

		if cv2.waitKey(1)==27:
			return
	

if __name__ == '__main__':
	run_realtime()	
	exit(0)
