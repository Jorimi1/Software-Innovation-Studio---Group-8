using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
using OpenCvSharp;
using OpenCvSharp.Face;
public class Webcam : MonoBehaviour
{
    public UnityEngine.TextAsset recognizerXml;
    private WebCamTexture webcamTexture;
    private CascadeClassifier cascade;
    private FaceRecognizer recognizer;
    private string[] emotion;
    private readonly Size requiredSize = new Size(128, 128);
    public string emotion_status = null;

    void Start()
    {
        webcamTexture = new WebCamTexture();
	    Renderer renderer = GetComponent<Renderer>();
	    renderer.material.mainTexture = webcamTexture;
	    renderer.material.shader = Shader.Find("Unlit/Texture");
	    webcamTexture.Play();

        cascade = new CascadeClassifier(Application.dataPath + "/Assets/haarcascade_frontalface_default.xml");
        recognizer = FaceRecognizer.CreateFisherFaceRecognizer();
        recognizer.Load(new FileStorage(recognizerXml.text, FileStorage.Mode.Read | FileStorage.Mode.Memory));
        
        emotion = new string[] { "Angry", "Happy", "Sad" };
    }

    private void Update()
    {

        Debug.Log(emotion_status);
        Mat image = OpenCvSharp.Unity.TextureToMat(webcamTexture);
        var gray = image.CvtColor(ColorConversionCodes.BGR2GRAY);

        Cv2.EqualizeHist(gray, gray);

        var face = cascade.DetectMultiScale(gray, 1.1, 6, HaarDetectionType.ScaleImage);

        foreach (var faceRect in face) {
            Debug.Log("Working");
            var grayFace = new Mat(gray, faceRect);

            if (requiredSize.Width > 0 && requiredSize.Height > 0) {
                grayFace = grayFace.Resize(requiredSize);
            }

            int label = -1;
            double confidence = 0.0;
            recognizer.Predict(grayFace, out label, out confidence);

            bool found = confidence < 1200;
            Scalar frameColour = found ? Scalar.LightGreen : Scalar.Red;

            Cv2.Rectangle((InputOutputArray)image, faceRect, frameColour, 2);

            int line = 0;
            const int textPadding = 2;
            const double textScale = 2.0;
            string message = string.Format("{0}", emotion[label], (int)confidence);

            emotion_status = emotion[label];

            emotion_status = emotion[label];
            var textSize = Cv2.GetTextSize(message, HersheyFonts.HersheyPlain, textScale, 1, out line);

            var textBox = new OpenCvSharp.Rect(
                faceRect.X + (faceRect.Width - textSize.Width) / 2 - textPadding,
                faceRect.Bottom,
                textSize.Width + textPadding * 2,
                textSize.Height + textPadding * 2
            );

            Cv2.Rectangle((InputOutputArray)image, textBox, frameColour, -1);
            image.PutText(message, textBox.TopLeft + new Point(textPadding, textPadding + textSize.Height), HersheyFonts.HersheyPlain, textScale, Scalar.Black, 2);
            break;
        }

        var new_texture = OpenCvSharp.Unity.MatToTexture(image);
        GetComponent<Renderer>().material.mainTexture = new_texture;
    }
}
