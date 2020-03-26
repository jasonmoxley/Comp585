using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud_1 : MonoBehaviour {

 
    public Vector2 begin;
    public Vector2 end;
    public float time_for_move;
 
    float timer;
 
    // Use this for initialization
    void Start () {
 
        transform.position = begin;
        timer = time_for_move;
 
    }
 
    // Update is called once per frame
    void Update () {
 
        timer -= Time.deltaTime;
 
        if (timer > 0) {
            Vector2 distance =  end - begin;
                        float degree_of_movement = (time_for_move - timer) / time_for_move;
                        transform.position = new Vector2 (begin.x + (distance.x * degree_of_movement), begin.y + (distance.y * degree_of_movement));
                }
    }
}
