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

        var line1 = new DialogData("Hi", "Player");
        var line2 = new DialogData("NO HI", "Boss1");
        var line3 = new DialogData("Why no hi?", "Player");
        var Text1 = new DialogData("Why hi?", "Boss1");
        Text1.SelectList.Add("c1", "10");
        Text1.SelectList.Add("c2", "7");
        Text1.SelectList.Add("c3", "idk");

        
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
