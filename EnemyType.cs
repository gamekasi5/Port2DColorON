using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType : MonoBehaviour
{
    public float speed;

    private bool MoveRight, MoveTop , MoveobliqueR, MoveobliqueL;
    public bool Type_A, Type_A2,
                    Type_B, Type_B2, Type_B3, Type_B4,
                        Type_C, Type_C2, Type_C3, Type_C4,
                          Type_D, Type_D2, Type_E, Type_E2;

    void Update()
    {
        if (Type_A == true )
        {
            Enemy_A();                     // Type tranfrom L-R
        }
        if(Type_A2 == true)
        {
            Enemy_A_2();                   // Type tranfrom T-U
        }

        if(Type_B == true)
        { 
            Enemy_B();                     // Type tranfrom L-R
        }
        if (Type_B2 == true)
        {
            Enemy_B_2();                   // Type tranfrom T-U
        }
        if (Type_B3 == true)
        {
            Enemy_B_3();                    // Type Rotate R
        }
        if (Type_B4 == true)
        {
            Enemy_B_4();                    // Type Rotate L
        }
        if (Type_C == true)
        {
            Enemy_C();                      // Type tranfrom L-R
        }
        if (Type_C2 == true)
        {
            Enemy_C_2();                   // Type tranfrom T-U
        }
        if (Type_C3 == true)
        {
            Enemy_C_3();                   // Type Rotate R
        }
        if (Type_C4 == true)
        {
            Enemy_C_4();                    // Type Rotate L
        }
        if (Type_D == true)
        {
            Enemy_D();                      // Type Rotate R
        }
        if (Type_D2 == true)
        {
            Enemy_D_2();                    // Type Rotate R
        }
        if (Type_E == true)
        {
            Enemy_E();                      // Type tranfrom oblique  R
        }
        if(Type_E2 == true)
        {
            Enemy_E_2();                    // Type tranfrom oblique  L
        }
    }

    void Enemy_A()
    {
        if (MoveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        }

        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
    }
    void Enemy_A_2()
    {
        if (MoveTop)
        {
            transform.Translate(0, 2 * Time.deltaTime * speed, 0);
}

        else
        {
            transform.Translate(0, -2 * Time.deltaTime * speed, 0);
        }

    }

    void Enemy_B()
    {
        if (MoveTop)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        }

        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
    }
    void Enemy_B_2()
    {
        if (MoveRight)
        {
            transform.Translate(0, 2 * Time.deltaTime * speed, 0);
        }

        else
        {
            transform.Translate(0, -2 * Time.deltaTime * speed, 0);
        }

    }
    void Enemy_B_3()
    {
        transform.Rotate(new Vector3(0, 0, 2* speed * Time.deltaTime));
    }
    void Enemy_B_4()
    {
        transform.Rotate(new Vector3(0, 0, -2 * speed * Time.deltaTime));
    }
    void Enemy_C()
    {
        if (MoveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        }

        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
    }
    void Enemy_C_2()
    {
        if (MoveTop)
        {
            transform.Translate(0, 2 * Time.deltaTime * speed, 0);
        }

        else
        {
            transform.Translate(0, -2 * Time.deltaTime * speed, 0);
        }

    }
    void Enemy_C_3()
    {
        transform.Rotate(new Vector3(0, 0, 2 * speed * Time.deltaTime));
    }
    void Enemy_C_4()
    {
        transform.Rotate(new Vector3(0, 0, -2 * speed * Time.deltaTime));
    }
    void Enemy_D()
    {
        transform.Rotate(new Vector3(0, 0, 2 * speed * Time.deltaTime));
    }
    void Enemy_D_2()
    {
        transform.Rotate(new Vector3(0, 0, -2 * speed * Time.deltaTime));
    }
    void Enemy_E()
    {
        if (MoveobliqueR)
        {
            transform.Translate(2 * Time.deltaTime, 2 * Time.deltaTime * speed, 0);
        }

        else
        {
            transform.Translate(-2 * Time.deltaTime, -2 * Time.deltaTime * speed, 0);
        }
    }
    void Enemy_E_2()
    {
        if (MoveobliqueL)
        {
            transform.Translate(2 * Time.deltaTime, -2 * Time.deltaTime * speed, 0);
        }

        else
        {
            transform.Translate(-2 * Time.deltaTime, 2 * Time.deltaTime * speed, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "turn")
        {
            MoveRight = false;
            Debug.Log("ture");
        }
        else
        {
            Debug.Log("ture");
            MoveRight = true;
        }

        if (other.gameObject.tag == "turnUnder")
        {
            Debug.Log("33");
            MoveTop = false;
        }
        else
        {
            MoveTop = true;
        }
        if (other.gameObject.CompareTag("turnslantR"))
        {
            MoveobliqueR = false;
        }
        else
        {
            MoveobliqueR = true;
        }
        if (other.gameObject.CompareTag("turnslantL"))
        {
            MoveobliqueL = false;
        }
        else
        {
            MoveobliqueL = true;
        }
    }
}
