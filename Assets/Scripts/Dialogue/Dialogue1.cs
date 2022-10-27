using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class Dialogue1 : MonoBehaviour
{
    public DialogManager DialogManager;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        var line1 = new DialogData("Finally, I found you...", "Player");
        var line2 = new DialogData("Took you some time... did you get stuck on the sky level?", "Boss1");
        var line3 = new DialogData("Wasn't easy with these game mechanics", "Player");
        var Text1 = new DialogData("get gud, why are you here..?", "Boss1");
        Text1.SelectList.Add("c1", "To save you");
        Text1.SelectList.Add("c2", "To get my emotions back");
        Text1.SelectList.Add("c3", "To escape the matrix");

        
        dialogTexts.Add(line1);
        dialogTexts.Add(line2);
        dialogTexts.Add(line3);
        dialogTexts.Add(Text1);

        DialogManager.Show(dialogTexts);
        Text1.Callback = () => CheckDia();
        Text1.Callback = () => GoToScene();

    }

    private void CheckDia()
    {
        if(DialogManager.Result == "c1")
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("first one"));

            DialogManager.Show(dialogTexts);
            
            
        }
        else if (DialogManager.Result == "c2")
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("second one"));

            DialogManager.Show(dialogTexts);
        }
        else 
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("last one"));

            DialogManager.Show(dialogTexts);
        }

    }
    public void GoToScene()
    {
        SceneManager.LoadScene("LevelBoss");
    }
}
