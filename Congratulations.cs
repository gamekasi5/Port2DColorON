using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Congratulations : MonoBehaviour
{
    public Text largeText;

    void Start()
    {
        PickRandomTextList();
        StartCoroutine(SceneDelay());
    }
    void Update()
    {
       
    }


    private void  PickRandomNumber (int maxInt)
    {
        int randomNum = Random.Range(1, maxInt+1);
        largeText.text = randomNum.ToString();
    }

    private void PickRandomTextList()
    {
        string[] congratulations = new string[] { "That's right!", 
                                                     "Wow!! This is Superb!", 
                                                       "You can do it!",
                                                         "Good Job!" };

        string randomName = congratulations[Random.Range(0, congratulations.Length)];
        largeText.text = randomName;
    }

    IEnumerator SceneDelay()
    {
        yield return new WaitForSeconds(2);
        SceneManager.UnloadSceneAsync("Congrate");
 
    }
}
