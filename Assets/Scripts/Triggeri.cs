using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Triggeri : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player")
        {
            Debug.Log("e PREKLE");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }

    }
}
