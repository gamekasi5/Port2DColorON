using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuSlide : MonoBehaviour
{
    public GameObject MenuTab;

    private bool checkTabIN;

    private Animator Anim;


    void Start()
    {
        Anim = GetComponent<Animator>();

        checkTabIN = true;


        Debug.Log(checkTabIN +"1");
    }

    void Update()
    {
        if (checkTabIN == true)
        {
            Anim.SetInteger("State", 2);
        }
        else
        {
            Anim.SetInteger("State", 1);
          
        }
        
    }

    public void SlideTab()
    {
        if (checkTabIN == true)
        {
            checkTabIN = false;
        }
        else
            checkTabIN = true;
    }
    



}
