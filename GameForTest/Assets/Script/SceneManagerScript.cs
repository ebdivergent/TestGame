using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public GameObject gun;
    public GameObject em;
    void Update()
    {
        
        if (!GameObject.Find("BadBoy"))
        {
            SceneManager.LoadScene(1);
        }
        if (GameObject.Find("BadBoy") && !GameObject.Find ("Gun"))
        {
            Invoke("LoadLvlToStart", 5f);
        }
        
        
    }


    void Load3Lvl()
    {
        SceneManager.LoadScene(2);
        
    }

    void LoadLvlToStart()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
