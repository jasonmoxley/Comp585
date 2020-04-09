using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Walking3 : MonoBehaviour {
     
    float speed = 2.0f;
    public void NextScene()
    {
        SceneManager.LoadScene("Transition 4");
    }
    public void checkForSceneChange()
    {
        if (GameObject.FindGameObjectWithTag("Lion").transform.position.x >= 15)
        {
            NextScene();
        }
    }
    void Update() {
        checkForSceneChange();
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * speed * Time.deltaTime;
    }
}
