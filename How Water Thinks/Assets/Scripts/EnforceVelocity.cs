using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class EnforceVelocity : MonoBehaviour {

	Rigidbody rb;
	public float velocityMultiplier = 0.0f;
	public float angularVelocityMultiplier = 0.0f;
	Vector3 atomVelocity;
	public float temperatureMultiplier = 0.5f;
    public Vector3 forward;
	private float temp = 1;
	// Use this for initialization
	// Scene currentScene = SceneManager.GetActiveScene();
	void Start () {

		// Calculate a random velocity
		atomVelocity = Vector3.forward * (Random.value - 0.05f) + Vector3.up * (Random.value - 0.05f) + Vector3.right * (Random.value - 0.05f);

		rb = GetComponent<Rigidbody> ();
		rb.velocity += atomVelocity * velocityMultiplier;
		rb.angularVelocity += atomVelocity * angularVelocityMultiplier;
		float idealVelocity = temp * 1f;
		this.gameObject.GetComponent<Rigidbody>().velocity = idealVelocity * this.gameObject.GetComponent<Rigidbody>().velocity.normalized;
		
	}
	
	public void getTempSlider(Slider slider)
	{
		temp = slider.value;
	}

	// Update is called once per frame
	void Update () {
        /*
        forward = gameObject.transform.forward;
		atomVelocity = Vector3.forward * (Random.value - 0.05f) + Vector3.up * (Random.value - 0.05f) + Vector3.right * (Random.value - 0.05f);
		rb.velocity += atomVelocity * velocityMultiplier * temperatureMultiplier;
		rb.angularVelocity += atomVelocity * angularVelocityMultiplier;*/
        this.gameObject.GetComponent<Rigidbody>().drag = 0;
        this.gameObject.GetComponent<Rigidbody>().angularDrag = 0;
		
		// if (sceneName == "Level 3") {
		// 	float idealVelocity = temp * 1f;
		// 	this.gameObject.GetComponent<Rigidbody>().velocity = idealVelocity * this.gameObject.GetComponent<Rigidbody>().velocity.normalized;
		// }
        // float idealVelocity = temp * 1f;
        //Debug.Log(this.gameObject.GetComponent<Rigidbody>().velocity);
        //this.gameObject.GetComponent<Rigidbody>().velocity = idealVelocity * this.gameObject.GetComponent<Rigidbody>().velocity.normalized;
    }
}
