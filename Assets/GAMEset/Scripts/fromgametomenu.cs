using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fromgametomenu: MonoBehaviour
{

    public void Pausegame()
    {
        SceneManager.LoadScene("MENU");
    }

   
    }
    //if get Escape key load scene 0 to Pause