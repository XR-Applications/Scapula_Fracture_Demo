using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class ButtonInteraction : MonoBehaviour
{

    public TextMeshProUGUI simpleUIText; 

    public void OnButton1Clicked(string msg)
    {
        simpleUIText.text = msg;
    }

    public void OnButton2Clicked()
    {

        ExitApplication();
    }


    public void OnButton3Clicked()
    {
        AudioControl.Instance.PlayBtnPressFX();

        simpleUIText.text = "Button3 is clicked";
    }

    public void ExitApplication()
    {
        AudioControl.Instance.PlayBtnPressFX();

        Application.Quit();
    }

    public void LoadLevelByInt(int levelIndex)
    {
        AudioControl.Instance.PlayBtnPressFX();
        OnButton1Clicked("Loading");
        SceneManager.LoadSceneAsync(levelIndex);
    }


}
