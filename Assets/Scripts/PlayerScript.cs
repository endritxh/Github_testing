using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

 

    public Rigidbody Rb;

    public GameObject youwon;


    public TextMeshProUGUI livesText;
    public int lives = 3;
    public float forwardForce = 2000f;
    public float backForce = -2000f;
    public float rightForce = 500f;
    public float leftForce = -500f;


     void Start()
    {
        youwon.SetActive(false);
    }


    void FixedUpdate()
    {
        livesText.text = lives + "/3";
        if (Input.GetKey("w"))
        {
            Rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        } 
        if (Input.GetKey("s"))
        {
            Rb.AddForce(0, 0, backForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            Rb.AddForce(rightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            Rb.AddForce(leftForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("hupe");
            lives = lives - 1;
            if (lives <= 0)
            {
                
                Invoke("ReloadScene", 1);

            }
           
           
        }
        if (collision.collider.name == "Heart")
        {
            Invoke("ReloadScene", 1);
            youwon.SetActive(true);
            Debug.Log("fitove!");
        }
    }
   
    void OnCollisionExit(Collision collision)
    {

    }
}

