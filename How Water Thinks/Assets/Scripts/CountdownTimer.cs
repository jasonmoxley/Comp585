using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour {

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public Text timerText;
    public string sceneName;
    public float startTime;
    public Scene currentScene;
    public GameObject startScreen;
    // Use this for initialization
    void Start () {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        //Time.time is the amount of time that the application has been running
        startTime = Time.time;
        Time.timeScale = 0;
        startScreen.SetActive(true);
    }

    public void startTimer()
    {
        startScreen.SetActive(false);
        Time.timeScale = 1;
    }
    
    // Update is called once per frame
    void Update () {
        float t = Time.time-startTime;
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        if (timerText != null)
        {
            timerText.text = minutes + ":" + seconds;
        }
        sceneName = currentScene.name;
        if (sceneName == "Level 0")
        {
            if (t > 55)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
            }
            else if (t > 45)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(true);
            }
            else if (t > 35)
            {
                star1.SetActive(false);
                star2.SetActive(true);
                star3.SetActive(true);
            }
            else
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
            }
        }
        else if (sceneName == "Level 1")
        {
            if (t > 70)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
            }
            else if (t > 55)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(true);
            }
            else if (t > 45)
            {
                star1.SetActive(false);
                star2.SetActive(true);
                star3.SetActive(true);
            }
            else
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
            }
        }
        else if (sceneName == "Level 3")
        {
            if (t > 60)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
            }
            else if (t > 50)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(true);
            }
            else if (t > 40)
            {
                star1.SetActive(false);
                star2.SetActive(true);
                star3.SetActive(true);
            }
            else
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
            }
        }
        else if (sceneName == "Level 4")
        {
            if (t > 50)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
            }
            else if (t > 40)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(true);
            }
            else if (t > 35)
            {
                star1.SetActive(false);
                star2.SetActive(true);
                star3.SetActive(true);
            }
            else
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
            }
        }
    }

    public void UpdateScore () {
        sceneName = currentScene.name;
        if (sceneName == "Level 0")
        {
            Globals.level0stars = 0;
            if (star1.activeSelf) {
                Globals.level0stars++;
			    Globals.totalStars++;
            }
            if (star2.activeSelf) {
                Globals.level0stars++;
                Globals.totalStars++;
            }
            if (star3.activeSelf) {
                Globals.level0stars++;
                Globals.totalStars++;
            }
        }
        if (sceneName == "Level 1")
        {
            Globals.level1stars = 0;
            if (star1.activeSelf) {
                Globals.level1stars++;
			    Globals.totalStars++;
            }
            if (star2.activeSelf) {
                Globals.level1stars++;
                Globals.totalStars++;
            }
            if (star3.activeSelf) {
                Globals.level1stars++;
                Globals.totalStars++;
            }
        }
        if (sceneName == "Level 3")
        {
            Globals.level2stars = 0;
            if (star1.activeSelf) {
                Globals.level2stars++;
			    Globals.totalStars++;
            }
            if (star2.activeSelf) {
                Globals.level2stars++;
                Globals.totalStars++;
            }
            if (star3.activeSelf) {
                Globals.level2stars++;
                Globals.totalStars++;
            }
        }
        if (sceneName == "Level 4")
        {
            Globals.level3stars = 0;
            if (star1.activeSelf) {
                Globals.level3stars++;
			    Globals.totalStars++;
            }
            if (star2.activeSelf) {
                Globals.level3stars++;
                Globals.totalStars++;
            }
            if (star3.activeSelf) {
                Globals.level3stars++;
                Globals.totalStars++;
            }
        }
		
        print("Total Score: " + Globals.totalStars);
    }

}

