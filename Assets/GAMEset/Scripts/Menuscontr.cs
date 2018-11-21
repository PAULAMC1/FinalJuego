using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuscontr : MonoBehaviour
{

    public void Playgame()
    {
        SceneManager.LoadScene("LEVE1");
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    //if get Escape key load scene 0 to Pause
}