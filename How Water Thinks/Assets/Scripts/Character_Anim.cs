using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Anim : MonoBehaviour {



	private Animator anim;
	public GameObject walkSound;

	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
		walkSound.GetComponent<AudioSource>().Stop();
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


	if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) && this.transform.position.y < 2.6 && walkSound.GetComponent<AudioSource>().isPlaying == false) {
		walkSound.GetComponent<AudioSource>().Play();
	}
	// if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) && this.transform.position.y < 2.6) {
	// 	walkSound.GetComponent<AudioSource>().Play();
	// }
	if (this.transform.position.y > 2.6 || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) {
		walkSound.GetComponent<AudioSource>().Stop();
	}
}


}
