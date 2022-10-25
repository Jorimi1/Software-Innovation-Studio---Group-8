using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class HappyWinDialogue : MonoBehaviour
{
    public DialogManager DialogManager;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        var line1 = new DialogData("I'm so happy, I did it!", "Player");
        var line2 = new DialogData("I lost and I'm a colossal failure...", "Boss2");
        var line3 = new DialogData("Don't care, I'm a WINNER!!!", "Player");
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