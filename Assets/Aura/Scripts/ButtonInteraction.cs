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
        simpleUIText.text = "Button3 is clicked";
    }

    public void ExitApplication()
    {
        Application.Quit();
    }

    public void LoadLevelByInt(int levelIndex)
    {
        OnButton1Clicked("Loading");
        SceneManager.LoadSceneAsync(levelIndex);
    }


}
