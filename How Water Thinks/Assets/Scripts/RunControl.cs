using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RunControl : MonoBehaviour
{

    // This set of routines appears in almost every scene. GameObject = RunControl


    public float boxSideLength;
    public float channelSideLength;
    private float speed;
    public GameObject popup;

    GameObject runControl;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        popup.SetActive(false);
        GameObject atoms = GameObject.FindGameObjectWithTag("Atoms");

        if (GameObject.FindGameObjectsWithTag("VolumeSlider").Length > 0) GameObject.FindGameObjectWithTag("VolumeSlider").GetComponent<Slider>().value = Globals.volume;
        if (GameObject.FindGameObjectsWithTag("ColorblindToggle").Length > 0) GameObject.FindGameObjectWithTag("ColorblindToggle").GetComponent<Toggle>().isOn = Globals.colorblindOn;
        if (GameObject.FindGameObjectsWithTag("Resolution").Length > 0) GameObject.FindGameObjectWithTag("Resolution").GetComponent<Dropdown>().value = Globals.windowSize;
        if (GameObject.FindGameObjectsWithTag("Fullscreen").Length > 0) GameObject.FindGameObjectWithTag("Fullscreen").GetComponent<Toggle>().isOn = Globals.fullscreenOn;

        if (Globals.colorblindOn) { (Resources.Load("Prefabs/sodiumAtom") as GameObject).GetComponent<Renderer>().material = Resources.Load("Materials/colorblind_sodium") as Material; } else { (Resources.Load("Prefabs/sodiumAtom") as GameObject).GetComponent<Renderer>().material = Resources.Load("Materials/sodiumAtom") as Material; }

        /*AudioListener.volume = 0.5f;
        if (GameObject.FindGameObjectsWithTag("VolumeSlider").Length > 0) GameObject.FindGameObjectWithTag("VolumeSlider").GetComponent<Slider>().value = AudioListener.volume;
        Debug.Log(AudioListener.volume);
        Debug.Log(Globals.volume);

        if (GameObject.FindGameObjectsWithTag("Resolution").Length > 0)
        {
            if (Screen.currentResolution.width == 1280) GameObject.FindGameObjectWithTag("Resolution").GetComponent<Dropdown>().value = 0;
            else
            if (Screen.currentResolution.width == 1360) GameObject.FindGameObjectWithTag("Resolution").GetComponent<Dropdown>().value = 1;
            else
            if (Screen.currentResolution.width == 1366) GameObject.FindGameObjectWithTag("Resolution").GetComponent<Dropdown>().value = 2;
            else
            if (Screen.currentResolution.width == 1600) GameObject.FindGameObjectWithTag("Resolution").GetComponent<Dropdown>().value = 3;
            else
            if (Screen.currentResolution.width == 1920) GameObject.FindGameObjectWithTag("Resolution").GetComponent<Dropdown>().value = 4;
        }

        if (GameObject.FindGameObjectsWithTag("Fullscreen").Length > 0)
        {
            if (Screen.fullScreen) GameObject.FindGameObjectWithTag("Fullscreen").GetComponent<Toggle>().isOn = true;
            else GameObject.FindGameObjectWithTag("Fullscreen").GetComponent<Toggle>().isOn = false;
        }*/

        if (sceneName == "Scene 4")
        {

            RemoveAllMolecules();
            //Debug.Log("ConstructChannel Membrane");

            // Create the basic membrane with a square hole in the middle
            //ConstructMembrane(boxSideLength, channelSideLength);

            // Construct the channel that goes in the hole in the membrane
            //ConstructChannel(channelSideLength);

            //atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(boxSideLength, channelSideLength);
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);

            GameObject.FindGameObjectWithTag("NumNaIons").GetComponent<Slider>().value = atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms;
            GameObject.FindGameObjectWithTag("NumClIons").GetComponent<Slider>().value = atoms.GetComponent<CreateAtoms>().numberOfChlorineAtoms;
            GameObject.FindGameObjectWithTag("NumKIons").GetComponent<Slider>().value = atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms;
            // GameObject.FindGameObjectWithTag("VoltageChanger").GetComponent<Slider>().maxValue = 300;
            // GameObject.FindGameObjectWithTag("VoltageChanger").GetComponent<Slider>().minValue = -300;
        }
        else if (sceneName == "Scene 1")
        {
            RemoveAllMolecules();
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);
            RemoveAllMolecules();
            print("creating atoms");
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms, atoms.GetComponent<CreateAtoms>().numberOfChlorineAtoms, atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms);
        }
        else if (sceneName == "Old Level 1")
        {
            RemoveAllMolecules();
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);
            RemoveAllMolecules();
            print("creating atoms");
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms, atoms.GetComponent<CreateAtoms>().numberOfChlorineAtoms, atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms);
        }
        else if (sceneName == "Level 0")
        {
            RemoveAllMolecules();
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);
            RemoveAllMolecules();
            print("creating atoms");
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms, atoms.GetComponent<CreateAtoms>().numberOfChlorineAtoms, atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms);
        }
        else if (sceneName == "Level 1")
        {
            RemoveAllMolecules();
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);
            RemoveAllMolecules();
            print("creating atoms");
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms, atoms.GetComponent<CreateAtoms>().numberOfChlorineAtoms, atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms);
        }
        else if (sceneName == "Level 2")
        {
            RemoveAllMolecules();
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);
            RemoveAllMolecules();
            print("creating atoms");
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms, atoms.GetComponent<CreateAtoms>().numberOfChlorineAtoms, atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms);
        }
        else if (sceneName == "Level 3")
        {
            RemoveAllMolecules();
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);
            RemoveAllMolecules();
            print("creating atoms");
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms, atoms.GetComponent<CreateAtoms>().numberOfChlorineAtoms, atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms);
        }
        else if (sceneName == "Level 4")
        {
            RemoveAllMolecules();
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);
            RemoveAllMolecules();
            print("creating atoms");
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms, atoms.GetComponent<CreateAtoms>().numberOfChlorineAtoms, atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms);
        }
        else if (sceneName == "Scene 2" ||sceneName == "Scene 3")
        {
            RemoveAllMolecules();
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);
            RemoveAllMolecules();
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms, atoms.GetComponent<CreateAtoms>().numberOfChlorineAtoms, atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms);

            GameObject.FindGameObjectWithTag("NumNaIons").GetComponent<Slider>().value = atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms;
            GameObject.FindGameObjectWithTag("NumKIons").GetComponent<Slider>().value = atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms;
        }
        else if (sceneName == "Scene 5")
        {
            RemoveAllMolecules();
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);
            RemoveAllMolecules();
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms, atoms.GetComponent<CreateAtoms>().numberOfChlorineAtoms, atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms);

        }

        if (sceneName != "Main Menu") Globals.firstLaunch = true;

    }



    void RemoveAllMolecules()
    {

        GameObject[] sodiumAtomClones = GameObject.FindGameObjectsWithTag("SodiumAtom");
        GameObject[] chlorineAtomClones = GameObject.FindGameObjectsWithTag("ChlorineAtom");
        GameObject[] potassiumAtomClones = GameObject.FindGameObjectsWithTag("PotassiumAtom");

        foreach (GameObject atomClone in sodiumAtomClones)
        {
            Destroy(atomClone);
        }

        foreach (GameObject atomClone in chlorineAtomClones)
        {
            Destroy(atomClone);
        }

        foreach (GameObject atomClone in potassiumAtomClones)
        {
            Destroy(atomClone);
        }
    }





    float GetBoxSideLength()
    {

        // A box side length of corresponds to 100 nm.
        float boxSide = 1f;

        return boxSide;

    }




    float GetChannelSideLength()
    {

        float channelSide;

        channelSide = channelSideLength;

        //Debug.Log ("sceneFlag in GetChannelSideLength = " + sceneFlag);

        channelSide = 0.1f;

        //Debug.Log ("channelSide = " + channelSide);

        /*
		else {

			Debug.Log ("sceneFlag in else = " + sceneFlag);

			// A channel side length of 0.1 corresponds to 10 nm.
			GameObject sliderRoutines = GameObject.FindGameObjectWithTag("Sliders");
			channelSide = sliderRoutines.GetComponent<SliderChannelWidth> ().valueOfChannelSlider;

		}
		*/


        //Debug.Log ("channelSide = " + channelSide);

        return channelSide;
    }

    public void ballSlider(Slider slider)
    {
        float size = slider.value;
        GameObject[] sodiumAtomClones = GameObject.FindGameObjectsWithTag("SodiumAtom");
        GameObject[] potassiumAtomClones = GameObject.FindGameObjectsWithTag("PotassiumAtom");


        print(size);
        Vector3 scaleChange = new Vector3(size, size, size);
        foreach (GameObject atomClone in sodiumAtomClones)
        {
            atomClone.transform.localScale = scaleChange;
        }
        foreach (GameObject atomClone in potassiumAtomClones)
        {
            atomClone.transform.localScale = scaleChange;
        }
    }

    public void FastForwardSlider(Slider slider)
    {
        speed = slider.value;
        GameObject[] sodiumAtomClones = GameObject.FindGameObjectsWithTag("SodiumAtom");
        GameObject[] potassiumAtomClones = GameObject.FindGameObjectsWithTag("PotassiumAtom");
        foreach (GameObject atomClone in sodiumAtomClones)
        {
            atomClone.GetComponent<Rigidbody>().velocity = atomClone.GetComponent<Rigidbody>().velocity.normalized * slider.value;
        }
        foreach (GameObject atomClone in potassiumAtomClones)
        {
            atomClone.GetComponent<Rigidbody>().velocity = atomClone.GetComponent<Rigidbody>().velocity.normalized * slider.value;
        }
    }

    // public void NormalizeVelocity()
    // {
    //     GameObject[] sodiumAtomClones = GameObject.FindGameObjectsWithTag("SodiumAtom");
    //     GameObject[] potassiumAtomClones = GameObject.FindGameObjectsWithTag("PotassiumAtom");
    //     foreach (GameObject atomClone in sodiumAtomClones)
    //     {
    //         atomClone.GetComponent<Rigidbody>().velocity = atomClone.GetComponent<Rigidbody>().velocity.normalized * speed;
    //     }
    //     foreach (GameObject atomClone in potassiumAtomClones)
    //     {
    //         atomClone.GetComponent<Rigidbody>().velocity = atomClone.GetComponent<Rigidbody>().velocity.normalized * speed;
    //     }
    // }

    public void FastForward()
    {
        if (GameObject.FindGameObjectWithTag("FastForward").GetComponent<Dropdown>().value == 0) Time.timeScale = 1;
        else if (GameObject.FindGameObjectWithTag("FastForward").GetComponent<Dropdown>().value == 1) Time.timeScale = 2;
        else if (GameObject.FindGameObjectWithTag("FastForward").GetComponent<Dropdown>().value == 2) Time.timeScale = 5;
        else if (GameObject.FindGameObjectWithTag("FastForward").GetComponent<Dropdown>().value == 3) Time.timeScale = 10;
        else if (GameObject.FindGameObjectWithTag("FastForward").GetComponent<Dropdown>().value == 4) Time.timeScale = 25;
    }

    public void checkForWin()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        int naOnTop = 0;
        int naOnBottom = 0;
        int kOnTop = 0;
        int kOnBottom = 0;
        int topTotal = 0;
        int bottomTotal = 0;
        foreach (GameObject atom in GameObject.FindGameObjectsWithTag("SodiumAtom"))
        {
            if (atom.transform.position.y > 214.95)
            {
                naOnTop++;
            }
            else 
            {
                naOnBottom++;
            }
        }
        foreach (GameObject atom in GameObject.FindGameObjectsWithTag("PotassiumAtom"))
        {
            if (atom.transform.position.y > 214.95)
            {
                kOnTop++;
            }
            else 
            {
                kOnBottom++;
            }
        }
        topTotal = naOnTop + kOnTop;
        bottomTotal = naOnBottom + kOnBottom;
        if (sceneName == "Level 0")
        {
            if (naOnBottom >= 25)
            {
                Time.timeScale = 0;
                popup.SetActive(true);
            }
        }
        else if (sceneName == "Level 1")
        {
            if ((naOnBottom >= 25) || (kOnTop >= 25))
            {
                Time.timeScale = 0;
                popup.SetActive(true);
            }
        }
        else if (sceneName == "Level 3")
        {
            if (((topTotal - bottomTotal) >= 25) || ((bottomTotal - topTotal) >= 25))
            {
                Time.timeScale = 0;
                popup.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //NormalizeVelocity();
        // if (SceneManager.GetActiveScene().buildIndex == 1)
        // {
        //     foreach (GameObject atom in GameObject.FindGameObjectsWithTag("PotassiumAtom"))
        //     {
        //         if (atom.transform.position.y > 214.95)
        //         {
        //             Destroy(atom);
        //             GameObject.Find("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 0, 0, 1);
        //         }
        //     }
        // }
        checkForWin();
        if (GameObject.FindGameObjectsWithTag("VolumeSlider").Length > 0)
        {
            AudioListener.volume = GameObject.FindGameObjectWithTag("VolumeSlider").GetComponent<Slider>().value;
        }
    }
}
