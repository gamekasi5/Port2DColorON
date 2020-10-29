using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GatenextState : MonoBehaviour
{
    public string KeyColor;
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            if (KeyColor == Ctrl_Player.currentColor)
            {
                LevelState.currentLevel += 1;
                SceneManager.LoadScene("Congrate", LoadSceneMode.Additive);
                StartCoroutine(NextDelay());
            }
        }
    }

    IEnumerator NextDelay()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("hey hey");
        Ctrl_Player.chageScence = true;

    }
}
