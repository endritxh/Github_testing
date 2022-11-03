using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private float speed = 20;
    private float turnspeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public Transform kerri;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right *  Time.deltaTime * speed * forwardInput );
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);

        if (kerri.position.x > 6)
        {
            Debug.Log("sdasdas");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (kerri.position.x < -6)
        {
            Debug.Log("sdasdas");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


    private void OnTriggerEnter(Collider col)
    {
        

        if (col.tag == "End")
        {

            SceneManager.LoadScene("EndScene");

        }

    }

}
