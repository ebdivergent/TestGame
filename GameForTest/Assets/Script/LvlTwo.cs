using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlTwo : MonoBehaviour
{
    public GameObject gun;
    public GameObject em;
    void Update()
    {

        if (!GameObject.Find("BadBoy"))
        {
            SceneManager.LoadScene(2);
        }
        if (GameObject.Find("BadBoy") && !GameObject.Find("Gun"))
        {
            Invoke("LoadLvlToStart", 6f);
        }


    }




    void LoadLvlToStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
