using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public GameObject em;
   void Update()
    {
        
        if (!GameObject.Find("BadBoy"))
        {
            SceneManager.LoadScene(1);
        }
        
    }
  

    //void LoadLvl3()
    //{
    //    Enemy em = new Enemy();
    //    if (em == null)
    //    {
    //        SceneManager.LoadScene(2);
    //    }
    //    if (em != null)
    //    {
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //    }
    //}

    //void LoadLvlToStart()
    //{
    //    Enemy em = new Enemy();
    //    if (em == null)
    //    {
    //        SceneManager.LoadScene(0);
    //    }
    //    if (em != null)
    //    {
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //    }
    //}


}
