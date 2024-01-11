using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour
{

    void Start()
    {
        Invoke("toMainMenu", 5);
        
    }

    void toMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
