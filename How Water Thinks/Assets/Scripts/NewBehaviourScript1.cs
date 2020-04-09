using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_movement2 : MonoBehaviour {

public Transform followObject;
private Vector3 moveTemp;

void start () {
	moveTemp = followObject.transform.position;
}

void Update () {
	if (GameObject.FindGameObjectWithTag("Lion").transform.position.x >= 0) {
	moveTemp = followObject.transform.position;
	moveTemp.z = -7;
	moveTemp.y = 4;
	transform.position = moveTemp;
	}
}
	
 
}
