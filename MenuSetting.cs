using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSetting : MonoBehaviour
{
    public GameObject GuildGame, ControlGame, Playbutton;

    private void Update()
    {

        if (LevelState.currentLevel != 0)
        {
            Playbutton.gameObject.SetActive(false);
        }
        else
        {
            Playbutton.gameObject.SetActive(true);
        }
            
    }
    public void Play()
    {
        AudioManager.instance.PlaySound("buttonClick", transform.position);
        SceneManager.LoadScene("1");
        LevelState.currentLevel = 1;
        Ctrl_Player.chageScence = true;
    }

    public void Quit()
    {
        SceneManager.LoadScene("FirstPage");
        LevelState.currentLevel = 0;
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void GuildOpen()
    {
        AudioManager.instance.PlaySound("buttonClick", transform.position);
        GuildGame.gameObject.SetActive(true);
        Playbutton.gameObject.SetActive(false);
    }
    public void GuildClose()
    {
        AudioManager.instance.PlaySound("buttonClick", transform.position);
        GuildGame.gameObject.SetActive(false);
        Playbutton.gameObject.SetActive(true);
    }
    public void ControlGameOpen()
    {
        AudioManager.instance.PlaySound("buttonClick", transform.position);
        ControlGame.gameObject.SetActive(true);
        Playbutton.gameObject.SetActive(false);
    }
    public void ControlGameClose()
    {
        AudioManager.instance.PlaySound("buttonClick", transform.position);
        ControlGame.gameObject.SetActive(false);
        Playbutton.gameObject.SetActive(true);
    }
    public void SetMasterVolume(float value)
    {
        AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Master);
    }
    public void SetMusicVolume(float value)
    {
        AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Music);
    }
    public void SetSfxVolume(float value)
    {
        AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Sfx);
    }

}
