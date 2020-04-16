using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Walking0 : MonoBehaviour {
    public GameObject Drone;
     
    float speed = 2.0f;
    public void NextScene()
    {
        SceneManager.LoadScene("Transition 1");
    }
    public void checkForSceneChange()
    {
        if (GameObject.FindGameObjectWithTag("Lion").transform.position.x >= 25)
        {
            NextScene();
        }
        if (GameObject.FindGameObjectWithTag("Lion").transform.position.x >= 14)
        {
            if (GameObject.FindGameObjectWithTag("Lion").transform.position.x <= 14.05f)
            {
                spawnDrones();
            }
        }
    }
    public void spawnDrones()
    {
        Instantiate(Drone, new Vector3(17, 3.5f, -4), Quaternion.identity);
        Instantiate(Drone, new Vector3(18, 4, -4), Quaternion.identity);
        Instantiate(Drone, new Vector3(19, 3.5f, -4), Quaternion.identity);

    }

    void Update() {
        checkForSceneChange();
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * speed * Time.deltaTime;
    }
}
