using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Walking2 : MonoBehaviour {
     
    float speed = 2.0f;
    public void NextScene()
    {
        SceneManager.LoadScene("Transition 3");
    }
    public void checkForSceneChange()
    {
        if (GameObject.FindGameObjectWithTag("Lion").transform.position.x >= 14)
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
