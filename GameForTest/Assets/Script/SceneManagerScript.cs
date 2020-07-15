using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    [SerializeField]
    public static SceneManagerScript instance = null;
    int sceneIndex;
    int levelComplete;
    public GameObject gun;
    public GameObject em;
    Score score;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        score = FindObjectOfType <Score> ();
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("levelComplete");

    }
    void Update()
    {

        
        if (!GameObject.Find("BadBoy"))
        {
            isEndGame();
            NextLvl();

            //PlayerPrefs.SetInt("Score", score.ChangeScore(coinValue));
        }
        if (GameObject.Find("BadBoy") && !GameObject.Find ("Gun"))
        {
            Invoke("LoadLvlToStart", 5f);
        }

        
        
    }


    public void isEndGame()
    {
        if(sceneIndex == 2)
        {
            Invoke("LoadFirstLvl", 1f);
        }
        else
        {
            if (levelComplete < sceneIndex)
                PlayerPrefs.SetInt("LevelComplete", sceneIndex);
            Invoke("NextLvl", 4f);
        }
    }
    void NextLvl()
    {
        if(sceneIndex == 2)
        {
            Invoke("LoadFirstLvl", 1f);
        }
        else
        { 
            SceneManager.LoadScene(sceneIndex + 1); 
        }
        

    }

    void LoadFirstLvl()
    {
        SceneManager.LoadScene(0);
    }
    //void LoadLvlToStart()
    //{
    //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}


}
