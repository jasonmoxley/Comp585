using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void NextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        // if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        // {
        //     SceneManager.LoadScene(nextSceneIndex);
        // }
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void PrevScene()
    {
        int prevSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
        if (prevSceneIndex >= 2)
        {
            SceneManager.LoadScene(prevSceneIndex);
        }
    }

    public void LoadLevel0()
    {
        SceneManager.LoadScene("Level 0");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void LoadTransition1()
    {
        SceneManager.LoadScene("Transition 1");
    }

    public void LoadTransition12()
    {
        SceneManager.LoadScene("Transition 1.2");
    }

    public void LoadTransition2()
    {
        SceneManager.LoadScene("Transition 2");
    }

    public void LoadTransition22()
    {
        SceneManager.LoadScene("Transition 2.2");
    }

    public void LoadTransition3()
    {
        SceneManager.LoadScene("Transition 3");
    }

    public void LoadTransition32()
    {
        SceneManager.LoadScene("Transition 3.2");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game_Map_0");
        Time.timeScale = 1;
    }

    public void LoadMap1()
    {
        SceneManager.LoadScene("Game_Map_1");
        Time.timeScale = 1;
    }

    public void LoadMap2()
    {
        SceneManager.LoadScene("Game_Map_2");
        Time.timeScale = 1;
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings Menu");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");     
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");     
    }

    public void changeScene(string theScene){
        SceneManager.LoadScene(theScene);     
    }

    public void infoScreen()
    {
        SceneManager.LoadScene("About Scene");
    }

    public void exitScene()
    {
        Application.Quit();
    }

    //Update is called once per frame
    void Update () {
		
	}
}
