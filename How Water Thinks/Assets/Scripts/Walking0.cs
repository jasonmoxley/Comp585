using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Walking0 : MonoBehaviour {
    public GameObject Drone;
    public bool drone1IsCreated = false;
    public bool drone2IsCreated = false;

     
    float speed = 1.5f;
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
        if (GameObject.FindGameObjectWithTag("Lion").transform.position.x >= 5 && drone1IsCreated == false)
        {
            spawnDrones(8);
            drone1IsCreated = true;

        }

        if (GameObject.FindGameObjectWithTag("Lion").transform.position.x >= 14 && drone2IsCreated == false)
        {
            spawnDrones(17);
            drone2IsCreated = true;

        }

    }
    public void spawnDrones(float x)
    {
        Instantiate(Drone, new Vector3(x, 3.5f, -4), Quaternion.identity);
        Instantiate(Drone, new Vector3(x + 1.5f, 4, -4), Quaternion.identity);
        Instantiate(Drone, new Vector3(x + 3, 3.5f, -4), Quaternion.identity);


    }

    void Update() {
        checkForSceneChange();
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * speed * Time.deltaTime;
    }
}
