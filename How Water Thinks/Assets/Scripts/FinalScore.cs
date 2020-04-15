using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScore : MonoBehaviour {

    public UnityEngine.UI.Text endingText;
	// Use this for initialization
	void Start () {
		endingText.text = "You did it! After smoking the pipe, Dorothy can now see Kansas, Scarecrow can see a brain, Tin Man can see a heart, and Lion can see a bottle of courage. \nYou have completed the game with " + Globals.totalStars + " out of 12 stars!";

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
