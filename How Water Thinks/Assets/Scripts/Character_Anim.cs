using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Anim : MonoBehaviour {



	private Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
		anim.SetBool("is_jumping", true);
		anim.SetBool("Is_Running", false);
		} else if ((Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.RightArrow))) {
		anim.SetBool("Is_Running", false);
		anim.SetBool("is_jumping", true);
		}
		else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
		anim.SetBool("Is_Running", true);
	} else {
		anim.SetBool("Is_Running", false);
		anim.SetBool("is_jumping", false);
		
	}
}
}
