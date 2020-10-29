using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManeger : MonoBehaviour
{
    public AudioClip mainTheme;
    public AudioClip StateTheme;


    void Start()
    {
        AudioManager.instance.PlayMusic(mainTheme, 1);
        Debug.Log("menuThemesong");
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioManager.instance.PlayMusic(StateTheme, 2);
        }
    }

}

