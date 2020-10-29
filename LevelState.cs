using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelState : MonoBehaviour
{
    private static LevelState instance;

    public static int currentLevel = 0;

    public Text currentLevelTxt;

    void Start()
    {

    }
    void Update()
    {
        currentLevelTxt.text = currentLevel.ToString();
        if (currentLevel == 0)
        {
            currentLevelTxt.color = Color.gray;
        }
        else if (currentLevel <= 5)
        {
            currentLevelTxt.color = Color.green;
        }
        else if (currentLevel <= 10)
        {
            currentLevelTxt.color = Color.yellow;
        }
        else if (currentLevel <= 15)
        {
            currentLevelTxt.color = Color.blue;
        }
        else
        {
            currentLevelTxt.color = Color.red;
        }


    }
}
