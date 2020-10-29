using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ctrl_Player : MonoBehaviour
{
    public float speed;
    public Sprite Red, Yellow, Blue, White, Purple, Green, Orange;

    public Rigidbody2D rb;
    private GameObject Player;
    private GameObject Spawpos;
    private bool delaycorlor = false;

    public GameObject RespawEffct;


    Vector2 move;
    public static string currentColor;
    public static bool chageScence = false;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Spawpos = GameObject.FindGameObjectWithTag("SpawPos");
        currentColor = "White";
    }


    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        changePoWhenChangeState();
        Move();
        Chagecolor();
        

    }
    public void changePoWhenChangeState()
    {
        
        if (chageScence == true)
        {
            AudioManager.instance.PlaySound("Clear", transform.position);
            Spawpos = GameObject.FindGameObjectWithTag("SpawPos");
            this. transform.position = new Vector2(Spawpos.transform.position.x, Spawpos.transform.position.y);
            currentColor = "White";
            chageScence = false;
        }

    }

    public void Move()
    {
        if (move.x != 0 || move.y != 0)
        {
            rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);

        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            AudioManager.instance.PlaySound("Destroy", transform.position);
        }
    }

    public void Respawn()
    {
        effext();
        AudioManager.instance.PlaySound("Destroy", transform.position);
        Player.transform.position = new Vector2(Spawpos.transform.position.x, Spawpos.transform.position.y);
        effext();
     
        delaycorlor = false;
    }
    private void Rotate()
    {
        rb.velocity = new Vector3(0, 0, Time.deltaTime * 90f);
    }

    public void Chagecolor()
    {
        switch (currentColor)
        {
            case "White":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = White;

                break;
            case "Red":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Red;
                break;
            case "Yellow":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Yellow;
                break;
            case "Blue":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Blue;
                break;
            case "Purple":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Purple;
                break;
            case "Orange":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Orange;
                break;
            case "Green":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Green;
                break;
        }


    }
    public void effext()
    {
        GameObject effect = Instantiate(RespawEffct, Player.transform.position, Quaternion.identity);
        Destroy(effect, 3f);
    }

    public void colortaget()
    {

    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Respawn();           
        }


        if (other.gameObject.tag == "C_White")
        {
            currentColor = "White";
            delaycorlor = false;
        }

        if (other.gameObject.tag == "C_Red")
        {

            if (currentColor == "White")
            {
                currentColor = "Red";
                delaycorlor = false;
            }
                
            if (currentColor == "Blue")
            {
                currentColor = "Purple";
            }
                
            if (currentColor == "Yellow")
            {
                currentColor = "Orange";
            }
                                  
            if (currentColor == "Purple" || currentColor == "Orange" || currentColor == "Green")
            {
                
                StartCoroutine(CrashDelay());
                if (delaycorlor == true)
                {
                    Respawn();
                }
            }                      
           
        }
        if (other.gameObject.tag == "C_Blue")
        {
                        
                if (currentColor == "White")
                {
                    currentColor = "Blue";
                     delaycorlor = false;
                }
                if (currentColor == "Red")                   
                {
                    currentColor = "Purple";
  
                }
                if (currentColor == "Yellow")

                {
                    currentColor = "Green";

                }
                if (currentColor == "Purple" || currentColor == "Orange" || currentColor == "Green")
                {
                StartCoroutine(CrashDelay());

                if (delaycorlor == true)
                {
                    Respawn();
                    
                }
            }
            
            
        }
        if (other.gameObject.tag == "C_Yellow")
        {           
                if (currentColor == "White")
                {
                    currentColor = "Yellow";
                    delaycorlor = false;

            }
                if (currentColor == "Blue")
                {
                    currentColor = "Green";


                }
                if (currentColor == "Red")
                {                   
                    currentColor = "Orange";

                }
            if (currentColor == "Purple" || currentColor == "Orange" || currentColor == "Green")
            {
                
                StartCoroutine(CrashDelay());
                if (delaycorlor == true)
                {
                    Respawn();                   
                }
            }                     
        }
        if (other.gameObject.tag == "C_Orange")
        {
            if (currentColor == "White")
            {
                            currentColor = "Orange";
                delaycorlor = false;
            }
            if (currentColor != "Orange" || currentColor != "White")
            {
                StartCoroutine(CrashDelay());
                if (delaycorlor == true)
                {
                    Respawn();
                }
            }
            
        }
        if (other.gameObject.tag == "C_Green")
        {
            if (currentColor == "White")
            {
                            currentColor = "Green";
                delaycorlor = false;
            }

            if (currentColor != "Green" || currentColor != "White")
            {
                StartCoroutine(CrashDelay());
                if (delaycorlor == true)
                {
                    Respawn();
                }
            }
            
        }
        if (other.gameObject.tag == "C_Purple")
        {
            if (currentColor == "White")
            {
                            currentColor = "Purple";
                delaycorlor = false;
            }

            if (currentColor != "Purple" || currentColor != "White")
            {
                StartCoroutine(CrashDelay());
                if (delaycorlor == true)
                {
                    Respawn();
                }
            }
            
        }
        Debug.Log(currentColor);    
    }

    IEnumerator CrashDelay()
    {
        yield return new WaitForSeconds(1);
        delaycorlor = true;
        Debug.Log(delaycorlor);
        
    }

}
