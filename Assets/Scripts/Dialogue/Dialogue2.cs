using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class Dialogue2 : MonoBehaviour
{
    public DialogManager DialogManager;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        var line1 = new DialogData("OHHHHHH, I did it!", "Player");
        var line2 = new DialogData("Your...I lost...", "Boss2");
        var line3 = new DialogData("Now the whole world will be peace again!", "Player");
        var line4 = new DialogData("Ummmm...no...", "Boss2");


        
        dialogTexts.Add(line1);
        dialogTexts.Add(line2);
        dialogTexts.Add(line3);
        dialogTexts.Add(line4);


        DialogManager.Show(dialogTexts);
        line4.Callback = () => GoToScene();

    }

    public void GoToScene()
    {
        SceneManager.LoadScene("WinScene");
    }
}