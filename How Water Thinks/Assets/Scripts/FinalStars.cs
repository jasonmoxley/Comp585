using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalStars : MonoBehaviour {

	public GameObject star11;
    public GameObject star12;
    public GameObject star13;
	public GameObject star21;
    public GameObject star22;
    public GameObject star23;
	public GameObject star31;
    public GameObject star32;
    public GameObject star33;
	public GameObject star41;
    public GameObject star42;
    public GameObject star43;
	public GameObject star11e;
    public GameObject star12e;
    public GameObject star13e;
	public GameObject star21e;
    public GameObject star22e;
    public GameObject star23e;
	public GameObject star31e;
    public GameObject star32e;
    public GameObject star33e;
	public GameObject star41e;
    public GameObject star42e;
    public GameObject star43e;

	// Use this for initialization
	void Start () {
		star11.SetActive(false);
		star12.SetActive(false);
		star13.SetActive(false);
		star21.SetActive(false);
		star22.SetActive(false);
		star23.SetActive(false);
		star31.SetActive(false);
		star32.SetActive(false);
		star33.SetActive(false);
		star41.SetActive(false);
		star42.SetActive(false);
		star43.SetActive(false);
		star11e.SetActive(true);
		star12e.SetActive(true);
		star13e.SetActive(true);
		star21e.SetActive(true);
		star22e.SetActive(true);
		star23e.SetActive(true);
		star31e.SetActive(true);
		star32e.SetActive(true);
		star33e.SetActive(true);
		star41e.SetActive(true);
		star42e.SetActive(true);
		star43e.SetActive(true);
		checkForStars();
	}

	public void checkForStars()
	{
		if (Globals.level0stars == 3) {
			star11.SetActive(true);
			star12.SetActive(true);
			star13.SetActive(true);
		}
		else if (Globals.level0stars == 2) {
			star11.SetActive(true);
			star12.SetActive(true);
		}
		else if (Globals.level0stars == 1) {
			star11.SetActive(true);
		}

		if (Globals.level1stars == 3) {
			star21.SetActive(true);
			star22.SetActive(true);
			star23.SetActive(true);
		}
		else if (Globals.level1stars == 2) {
			star21.SetActive(true);
			star22.SetActive(true);
		}
		else if (Globals.level1stars == 1) {
			star21.SetActive(true);
		}

		if (Globals.level2stars == 3) {
			star31.SetActive(true);
			star32.SetActive(true);
			star33.SetActive(true);
		}
		else if (Globals.level2stars == 2) {
			star31.SetActive(true);
			star32.SetActive(true);
		}
		else if (Globals.level2stars == 1) {
			star31.SetActive(true);
		}

		if (Globals.level3stars == 3) {
			star41.SetActive(true);
			star42.SetActive(true);
			star43.SetActive(true);
		}
		else if (Globals.level3stars == 2) {
			star41.SetActive(true);
			star42.SetActive(true);
		}
		else if (Globals.level3stars == 1) {
			star41.SetActive(true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
