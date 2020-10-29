using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int speed = 24;


    public void Start()
    {

    }
    public void Update()
    {
        Rotate_f();
    }
    void Rotate_f()
    {
        transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));      
    }
}
