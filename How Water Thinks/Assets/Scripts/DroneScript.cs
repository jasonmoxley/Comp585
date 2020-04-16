using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DroneScript : MonoBehaviour {
    public GameObject Drone;
    public GameObject popup;
    public GameObject crash;
    //int i;

    // Use this for initialization
    void Start()
    {
        //i = 0;
        //InvokeRepeating("Spawn", 0f, .05f);
    }


    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Lion")
        {
            InvokeRepeating("Shrink", 0f, 0.1f);
            Invoke("KillCharacter", 1f);

        }
        if (c.gameObject.tag == "Ground")
        {
            // sprite needs to change
            Destroy(Drone);
            Instantiate(crash, new Vector3(17, 2, -4), Quaternion.identity);
            Instantiate(crash, new Vector3(18, 2, -4), Quaternion.identity);
            Instantiate(crash, new Vector3(19, 2, -4), Quaternion.identity);
        }
    }

    void Shrink()
    {
        if (GameObject.Find("Lion").GetComponent<Transform>().transform.localScale.y > 0)
        {
            GameObject.Find("Lion").GetComponent<Transform>().transform.localScale -= new Vector3(0, .05f, 0);
            GameObject.Find("Lion").GetComponent<Transform>().transform.position -= new Vector3(0, .01f, 0); ;

        }
    }

    void KillCharacter()
    {
        popup.SetActive(true);
        Time.timeScale = 0;
        // SceneManager.LoadScene("Game_Map_2");

    }

    public void restartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game_Map_0");
    }


    //void Spawn()
    //{
        // instantiate acorns every .05s, delete from scene after 8 seconds, to keep from getting thousands of objects and slowing down game.
        //Destroy(Instantiate(acorn, new Vector3(Random.Range(-2f, 14.5f), 7f, -4f), transform.rotation) as GameObject, 8f);
        //i++;
    //}
    // Update is called once per frame
    void Update () {
		
	}
}
