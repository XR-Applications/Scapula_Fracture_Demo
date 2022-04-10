using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioClip buttonPressClip;

    private static AudioControl instance;
    public static AudioControl Instance
    {
        get => instance;
    }
    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }
   
  public void PlayBtnPressFX()
    {
        GetComponent<AudioSource>().PlayOneShot(buttonPressClip);
    }
}
