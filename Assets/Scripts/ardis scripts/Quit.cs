using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Quit : MonoBehaviour
{
    public void QuitLul()
    {
        Application.Quit();
    }

    public void Restartlevel()
    {
        SceneManager.LoadScene("EduardDibrani");
    }
}
