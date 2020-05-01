using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour {

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject star1end;
    public GameObject star2end;
    public GameObject star3end;
    public Text timerText;
    public string sceneName;
    public float startTime;
    public Scene currentScene;
    public GameObject startScreen;
    public GameObject startScreen2;
    // Use this for initialization
    void Start () {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        //Time.time is the amount of time that the application has been running
        startTime = Time.time;
        Time.timeScale = 0;
        startScreen.SetActive(true);
    }

    public void nextStart()
    {
        startScreen.SetActive(false);
        startScreen2.SetActive(true);
    }

    public void lastStart()
    {
        startScreen2.SetActive(false);
        Time.timeScale = 1;
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
            if (t > 110)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
                star1end.SetActive(false);
                star2end.SetActive(false);
                star3end.SetActive(false);
            }
            else if (t > 100)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(true);
                star1end.SetActive(true);
                star2end.SetActive(false);
                star3end.SetActive(false);
            }
            else if (t > 90)
            {
                star1.SetActive(false);
                star2.SetActive(true);
                star3.SetActive(true);
                star1end.SetActive(true);
                star2end.SetActive(true);
                star3end.SetActive(false);
            }
            else
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star1end.SetActive(true);
                star2end.SetActive(true);
                star3end.SetActive(true);
            }
        }
        else if (sceneName == "Level 1")
        {
            if (t > 70)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
                star1end.SetActive(false);
                star2end.SetActive(false);
                star3end.SetActive(false);
            }
            else if (t > 55)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(true);
                star1end.SetActive(true);
                star2end.SetActive(false);
                star3end.SetActive(false);
            }
            else if (t > 45)
            {
                star1.SetActive(false);
                star2.SetActive(true);
                star3.SetActive(true);
                star1end.SetActive(true);
                star2end.SetActive(true);
                star3end.SetActive(false);
            }
            else
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star1end.SetActive(true);
                star2end.SetActive(true);
                star3end.SetActive(true);
            }
        }
        else if (sceneName == "Level 3")
        {
            if (t > 60)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
                star1end.SetActive(false);
                star2end.SetActive(false);
                star3end.SetActive(false);
            }
            else if (t > 50)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(true);
                star1end.SetActive(true);
                star2end.SetActive(false);
                star3end.SetActive(false);
            }
            else if (t > 40)
            {
                star1.SetActive(false);
                star2.SetActive(true);
                star3.SetActive(true);
                star1end.SetActive(true);
                star2end.SetActive(true);
                star3end.SetActive(false);
            }
            else
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star1end.SetActive(true);
                star2end.SetActive(true);
                star3end.SetActive(true);
            }
        }
        else if (sceneName == "Level 4")
        {
            if (t > 120)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
                star1end.SetActive(false);
                star2end.SetActive(false);
                star3end.SetActive(false);
            }
            else if (t > 105)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(true);
                star1end.SetActive(true);
                star2end.SetActive(false);
                star3end.SetActive(false);
            }
            else if (t > 90)
            {
                star1.SetActive(false);
                star2.SetActive(true);
                star3.SetActive(true);
                star1end.SetActive(true);
                star2end.SetActive(true);
                star3end.SetActive(false);
            }
            else
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star1end.SetActive(true);
                star2end.SetActive(true);
                star3end.SetActive(true);
            }
        }
    }

    public void UpdateScore () {
        sceneName = currentScene.name;
        int tempLevel0 = 0;
        int tempLevel1 = 0;
        int tempLevel2 = 0;
        int tempLevel3 = 0;
        if (sceneName == "Level 0")
        {
            Globals.level0stars = 0;
            if (star1.activeSelf) {
                tempLevel0++;
            }
            if (star2.activeSelf) {
                tempLevel0++;
            }
            if (star3.activeSelf) {
                tempLevel0++;
            }
            if (tempLevel0 > Globals.level0stars)
            {
                Globals.level0stars = tempLevel0;
            }
        }
        if (sceneName == "Level 1")
        {
            Globals.level1stars = 0;
            if (star1.activeSelf) {
                tempLevel1++;
            }
            if (star2.activeSelf) {
                tempLevel1++;
            }
            if (star3.activeSelf) {
                tempLevel1++;
            }
            if (tempLevel1 > Globals.level1stars)
            {
                Globals.level1stars =  tempLevel1;
            }
        }
        if (sceneName == "Level 3")
        {
            Globals.level2stars = 0;
            if (star1.activeSelf) {
                tempLevel2++;
            }
            if (star2.activeSelf) {
                tempLevel2++;
            }
            if (star3.activeSelf) {
                tempLevel2++;
            }
            if (tempLevel2 > Globals.level2stars)
            {
                Globals.level2stars = tempLevel2;
            }
        }
        if (sceneName == "Level 4")
        {
            Globals.level3stars = 0;
            if (star1.activeSelf) {
                tempLevel3++;
            }
            if (star2.activeSelf) {
                tempLevel3++;
            }
            if (star3.activeSelf) {
                tempLevel3++;
            }
            if (tempLevel3 > Globals.level3stars)
            {
                Globals.level3stars = tempLevel3;
            }
        }
		Globals.totalStars = Globals.level0stars + Globals.level1stars + Globals.level2stars + Globals.level3stars;
        print("Total Score: " + Globals.totalStars);
    }

}

