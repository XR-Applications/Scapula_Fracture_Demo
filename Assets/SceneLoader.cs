using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject loadingCanvas;
    private void Awake()
    {
        loadingCanvas.SetActive(true);
    }
    public void LoadIntroScene()
    {
        SceneManager.LoadSceneAsync(1);
        loadingCanvas.SetActive(true);
    }
}
