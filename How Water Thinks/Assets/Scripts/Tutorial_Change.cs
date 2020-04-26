using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Tutorial_Change : MonoBehaviour {
    public Canvas CanvasA;
    public Canvas CanvasB;
    public Canvas CanvasC;
	public Canvas CanvasD;

    // Use this for initialization
    void Start () {
		CanvasA.gameObject.SetActive(true);
        CanvasB.gameObject.SetActive(false);
		CanvasC.gameObject.SetActive(false);
		CanvasD.gameObject.SetActive(false);
    }
	
	// Update is called once per frame

	public void loadCanvasA()
	{
		CanvasA.gameObject.SetActive(true);
        CanvasB.gameObject.SetActive(false);
		CanvasC.gameObject.SetActive(false);
		CanvasD.gameObject.SetActive(false);
	}

	public void loadCanvasB()
	{
		CanvasA.gameObject.SetActive(false);
        CanvasB.gameObject.SetActive(true);
		CanvasC.gameObject.SetActive(false);
		CanvasD.gameObject.SetActive(false);
	}

	public void loadCanvasC()
	{
		CanvasA.gameObject.SetActive(false);
        CanvasB.gameObject.SetActive(false);
		CanvasC.gameObject.SetActive(true);
		CanvasD.gameObject.SetActive(false);
	}

	public void loadCanvasD()
	{
		CanvasA.gameObject.SetActive(false);
        CanvasB.gameObject.SetActive(false);
		CanvasC.gameObject.SetActive(false);
		CanvasD.gameObject.SetActive(true);
	}
}
