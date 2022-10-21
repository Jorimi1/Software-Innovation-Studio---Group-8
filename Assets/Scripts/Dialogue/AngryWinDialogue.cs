using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class AngryWinDialogue : MonoBehaviour
{
    public DialogManager DialogManager;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        var line1 = new DialogData("God, I've finally beaten you!!!", "Player");
        var line2 = new DialogData("I lost and I'm a colossal failure...", "Boss2");
        var line3 = new DialogData("I know! And if I ever see you again, I will rip out your backend code", "Player");
        var line4 = new DialogData("Ummmm...", "Boss2");

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