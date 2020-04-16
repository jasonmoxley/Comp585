using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class toggleReaction : MonoBehaviour {

    public GameObject ZeroMembrane;
    public GameObject NaMembrane;
    public GameObject NaMembrane2;
    public GameObject ClMembrane;
    public GameObject KMembrane;
    public GameObject NaClMembrane;
    public GameObject NaKMembrane;
    public GameObject ClKMembrane;
    public GameObject NaClKMembrane;
    public GameObject NaForce;
    public GameObject NaForce2;
    public GameObject NaLiner;
    public GameObject NaLiner2;
    public GameObject NaMidForce;
    public GameObject NaMidLiner;
    public GameObject ClForce;
    public GameObject ClLiner;
    public GameObject KForce;
    public GameObject KLiner;
    public GameObject KMidForce;
    public GameObject KMidLiner;
    private float KOn = 0;
    private float NaOn = 0;
    private float ClOn = 0;

    // Use this for initialization
    void Start ()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Level 0")
        {
            ZeroMembrane.SetActive(true);
            NaMembrane.SetActive(false);
            NaMembrane2.SetActive(false);
            NaForce.SetActive(false);
            NaForce2.SetActive(false);
            NaLiner.SetActive(false);
            NaLiner2.SetActive(false);
        }
        if (sceneName == "Level 1")
        {
            ZeroMembrane.SetActive(true);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(false);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(false);
            NaClKMembrane.SetActive(false);
            NaLiner.SetActive(false);
            KLiner.SetActive(false);
            ClLiner.SetActive(false);
            NaForce.SetActive(false);
            KForce.SetActive(false);
            ClForce.SetActive(false);
            NaMidForce.SetActive(false);
            NaMidLiner.SetActive(false);
            KMidForce.SetActive(false);
            KMidLiner.SetActive(false);
        }
        if (sceneName == "Level 3")
        {
            ZeroMembrane.SetActive(true);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(false);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(false);
            NaClKMembrane.SetActive(false);
            NaLiner.SetActive(false);
            KLiner.SetActive(false);
            ClLiner.SetActive(false);
            NaForce.SetActive(false);
            KForce.SetActive(false);
            ClForce.SetActive(false);
            NaMidForce.SetActive(false);
            NaMidLiner.SetActive(false);
            KMidForce.SetActive(false);
            KMidLiner.SetActive(false);
        }
        if (sceneName == "Level 4")
        {
            ZeroMembrane.SetActive(true);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(false);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(false);
            NaClKMembrane.SetActive(false);
            NaLiner.SetActive(false);
            KLiner.SetActive(false);
            ClLiner.SetActive(false);
            NaForce.SetActive(false);
            KForce.SetActive(false);
            ClForce.SetActive(false);
            NaMidForce.SetActive(false);
            NaMidLiner.SetActive(false);
            KMidForce.SetActive(false);
            KMidLiner.SetActive(false);
        }
	}

    public int getNumberNaChannels()
    {
        if (NaMembrane.active)
        {
            return 1;
        }
        else if (NaMembrane2.active)
        {
            return 2;
        }
        else
        {
            return 0;
        }
    }

    public void HandleNaSlider(Slider slider)
    {
        NaOn = slider.value;
        if (NaOn == 2 && KOn == 2)
        {
            KOn = 1;
            if (GameObject.FindGameObjectWithTag("KChannelSlider") != null) GameObject.FindGameObjectWithTag("KChannelSlider").GetComponent<Slider>().value = 1;

        }
        HandleChannelToggles();
    }

    public void HandleKSlider(Slider slider)
    {
        KOn = slider.value;
        if (NaOn == 2 && KOn == 2)
        {
            NaOn = 1;
            if (GameObject.FindGameObjectWithTag("NaChannelSlider") != null) GameObject.FindGameObjectWithTag("NaChannelSlider").GetComponent<Slider>().value = 1;

        }
        HandleChannelToggles();
    }

    public void HandleClSlider(Slider slider)
    {
        ClOn = slider.value;
        HandleChannelToggles();
    }

    public void HandleChannelToggles()
    {
        // print("NaOn: " + NaOn + " KOn: " + KOn + " ClOn: " + ClOn);
        if (NaOn ==  2 && KOn == 1)
        {
            ZeroMembrane.SetActive(false);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(false);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(false);
            NaClKMembrane.SetActive(true);
            NaLiner.SetActive(true);
            KLiner.SetActive(true);
            ClLiner.SetActive(false);
            NaForce.SetActive(true);
            KForce.SetActive(true);
            ClForce.SetActive(false);
            NaMidForce.SetActive(true);
            NaMidLiner.SetActive(true);
            KMidForce.SetActive(false);
            KMidLiner.SetActive(false);
        }
        else if (NaOn == 1 && KOn == 2)
        {
            ZeroMembrane.SetActive(false);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(false);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(false);
            NaClKMembrane.SetActive(true);
            NaLiner.SetActive(true);
            KLiner.SetActive(true);
            ClLiner.SetActive(false);
            NaForce.SetActive(true);
            KForce.SetActive(true);
            ClForce.SetActive(false);
            NaMidForce.SetActive(false);
            NaMidLiner.SetActive(false);
            KMidForce.SetActive(true);
            KMidLiner.SetActive(true);
        }
        else if (NaOn == 2 && KOn == 0)
        {
            ZeroMembrane.SetActive(false);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(true);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(false);
            NaClKMembrane.SetActive(false);
            NaLiner.SetActive(true);
            KLiner.SetActive(false);
            ClLiner.SetActive(false);
            NaForce.SetActive(true);
            KForce.SetActive(false);
            ClForce.SetActive(false);
            NaMidForce.SetActive(true);
            NaMidLiner.SetActive(true);
            KMidForce.SetActive(false);
            KMidLiner.SetActive(false);
        }
        else if (NaOn == 0 && KOn == 2)
        {
            ZeroMembrane.SetActive(false);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(false);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(true);
            NaClKMembrane.SetActive(false);
            NaLiner.SetActive(false);
            KLiner.SetActive(true);
            ClLiner.SetActive(false);
            NaForce.SetActive(false);
            KForce.SetActive(true);
            ClForce.SetActive(false);
            NaMidForce.SetActive(false);
            NaMidLiner.SetActive(false);
            KMidForce.SetActive(true);
            KMidLiner.SetActive(true);
        }
        else if (NaOn == 1 && KOn == 1 && ClOn == 1)
        {
            // print("NaKCl");
            ZeroMembrane.SetActive(false);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(false);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(false);
            NaClKMembrane.SetActive(true);
            NaLiner.SetActive(true);
            KLiner.SetActive(true);
            ClLiner.SetActive(true);
            NaForce.SetActive(true);
            KForce.SetActive(true);
            ClForce.SetActive(true);
            NaMidForce.SetActive(false);
            NaMidLiner.SetActive(false);
            KMidForce.SetActive(false);
            KMidLiner.SetActive(false);
        }
        else if (KOn == 1 && ClOn == 1)
        {
            // print("KCl");
            ZeroMembrane.SetActive(false);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(false);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(true);
            NaClKMembrane.SetActive(false);
            NaLiner.SetActive(false);
            KLiner.SetActive(true);
            ClLiner.SetActive(true);
            NaForce.SetActive(false);
            KForce.SetActive(true);
            ClForce.SetActive(true);
            NaMidForce.SetActive(false);
            NaMidLiner.SetActive(false);
            KMidForce.SetActive(false);
            KMidLiner.SetActive(false);
        }
        else if (NaOn == 1 && ClOn == 1)
        {
            // print("NaCl");
            ZeroMembrane.SetActive(false);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(true);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(false);
            NaClKMembrane.SetActive(false);
            NaLiner.SetActive(true);
            KLiner.SetActive(false);
            ClLiner.SetActive(true);
            NaForce.SetActive(true);
            KForce.SetActive(false);
            ClForce.SetActive(true);
            NaMidForce.SetActive(false);
            NaMidLiner.SetActive(false);
            KMidForce.SetActive(false);
            KMidLiner.SetActive(false);
        }
        else if (NaOn == 1 && KOn == 1)
        {
            // print("NaK");
            ZeroMembrane.SetActive(false);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(false);
            NaKMembrane.SetActive(true);
            ClKMembrane.SetActive(false);
            NaClKMembrane.SetActive(false);
            NaLiner.SetActive(true);
            KLiner.SetActive(true);
            ClLiner.SetActive(false);
            NaForce.SetActive(true);
            KForce.SetActive(true);
            ClForce.SetActive(false);
            NaMidForce.SetActive(false);
            NaMidLiner.SetActive(false);
            KMidForce.SetActive(false);
            KMidLiner.SetActive(false);
        }
        else if (NaOn == 1)
        {
            // print("Na");
            ZeroMembrane.SetActive(false);
            NaMembrane.SetActive(true);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(false);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(false);
            NaClKMembrane.SetActive(false);
            NaLiner.SetActive(true);
            KLiner.SetActive(false);
            ClLiner.SetActive(false);
            NaForce.SetActive(true);
            KForce.SetActive(false);
            ClForce.SetActive(false);
            NaMidForce.SetActive(false);
            NaMidLiner.SetActive(false);
            KMidForce.SetActive(false);
            KMidLiner.SetActive(false);
        }
        else if (KOn == 1)
        {
            // print("K");
            ZeroMembrane.SetActive(false);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(true);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(false);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(false);
            NaClKMembrane.SetActive(false);
            NaLiner.SetActive(false);
            KLiner.SetActive(true);
            ClLiner.SetActive(false);
            NaForce.SetActive(false);
            KForce.SetActive(true);
            ClForce.SetActive(false);
            NaMidForce.SetActive(false);
            NaMidLiner.SetActive(false);
            KMidForce.SetActive(false);
            KMidLiner.SetActive(false);
        }
        else if (ClOn == 1)
        {
            // print("Cl");
            ZeroMembrane.SetActive(false);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(true);
            NaClMembrane.SetActive(false);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(false);
            NaClKMembrane.SetActive(false);
            NaLiner.SetActive(false);
            KLiner.SetActive(false);
            ClLiner.SetActive(true);
            NaForce.SetActive(false);
            KForce.SetActive(false);
            ClForce.SetActive(true);
            NaMidForce.SetActive(false);
            NaMidLiner.SetActive(false);
            KMidForce.SetActive(false);
            KMidLiner.SetActive(false);
        }
        else {
            // print("zero");
            ZeroMembrane.SetActive(true);
            NaMembrane.SetActive(false);
            KMembrane.SetActive(false);
            ClMembrane.SetActive(false);
            NaClMembrane.SetActive(false);
            NaKMembrane.SetActive(false);
            ClKMembrane.SetActive(false);
            NaClKMembrane.SetActive(false);
            NaLiner.SetActive(false);
            KLiner.SetActive(false);
            ClLiner.SetActive(false);
            NaForce.SetActive(false);
            KForce.SetActive(false);
            ClForce.SetActive(false);
            NaMidForce.SetActive(false);
            NaMidLiner.SetActive(false);
            KMidForce.SetActive(false);
            KMidLiner.SetActive(false);
        }
    }

    public void HandleNaChannelSlider(Slider slider)
    {
        // float naChannelSlider = GameObject.FindGameObjectWithTag("NaChannelSlider").GetComponent <Slider> ().value;
        float naChannelSlider = slider.value;
        int numChannels = getNumberNaChannels();
        if (numChannels == 0)
        {
            if (naChannelSlider == 1)
            {
                ZeroMembrane.SetActive(false);
                NaMembrane.SetActive(true);
                NaMembrane2.SetActive(false);
                NaLiner.SetActive(true);
                NaLiner2.SetActive(false);
            }
            else if (naChannelSlider == 2)
            {
                ZeroMembrane.SetActive(false);
                NaMembrane.SetActive(false);
                NaMembrane2.SetActive(true);
                NaLiner.SetActive(true);
                NaLiner2.SetActive(true);
            }
        }
        else if (numChannels == 1)
        {
            if (naChannelSlider == 0)
            {
                ZeroMembrane.SetActive(true);
                NaMembrane.SetActive(false);
                NaMembrane2.SetActive(false);
                NaLiner.SetActive(false);
                NaLiner2.SetActive(false);
            }
            else if ((int)(naChannelSlider) == 2)
            {
                ZeroMembrane.SetActive(false);
                NaMembrane.SetActive(false);
                NaMembrane2.SetActive(true);
                NaLiner.SetActive(true);
                NaLiner2.SetActive(true);

            }
        }
        else if (numChannels == 2)
        {
            if ((int)(naChannelSlider) == 0)
            {
                ZeroMembrane.SetActive(true);
                NaMembrane.SetActive(false);
                NaMembrane2.SetActive(false);
                NaLiner.SetActive(false);
                NaLiner2.SetActive(false);
            }
            else if ((int)(naChannelSlider) == 1)
            {
                ZeroMembrane.SetActive(false);
                NaMembrane.SetActive(true);
                NaMembrane2.SetActive(false);
                NaLiner.SetActive(true);
                NaLiner2.SetActive(false);

            }
        }
    }

    // public void HandleNaToggle(Toggle sodiumToggle)
    // {
    //     if (sodiumToggle.isOn == true)
    //     {
    //         GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, (int)GameObject.FindGameObjectWithTag("NumNaIons").GetComponent<Slider>().value, 0, 0);
    //     } else
    //     {
    //         foreach (GameObject atom in GameObject.FindGameObjectsWithTag("SodiumAtom")) Destroy(atom);
    //     }
    // }

    // public void HandleClToggle(Toggle chlorineToggle)
    // {
    //     if (chlorineToggle.isOn == true)
    //     {
    //         GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 0, (int)GameObject.FindGameObjectWithTag("NumClIons").GetComponent<Slider>().value, 0);
    //     }
    //     else
    //     {
    //         foreach (GameObject atom in GameObject.FindGameObjectsWithTag("ChlorineAtom")) Destroy(atom);
    //     }
    // }

    // public void HandleKToggle(Toggle potassiumToggle)
    // {
    //     if (potassiumToggle.isOn == true)
    //     {
    //         GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 0, 0, (int)GameObject.FindGameObjectWithTag("NumKIons").GetComponent<Slider>().value);
    //     }
    //     else
    //     {
    //         foreach (GameObject atom in GameObject.FindGameObjectsWithTag("PotassiumAtom")) Destroy(atom);
    //     }
    // }

    // public void HandleMembraneToggle()
    // {
    //     bool NaOn = false;
    //     bool ClOn = false;
    //     bool KOn = false;
    //     if (GameObject.FindGameObjectsWithTag("NaChannelToggle").Length > 0) NaOn = GameObject.FindGameObjectWithTag("NaChannelToggle").GetComponent<Toggle>().isOn;
    //     if (GameObject.FindGameObjectsWithTag("ClChannelToggle").Length > 0) ClOn = GameObject.FindGameObjectWithTag("ClChannelToggle").GetComponent<Toggle>().isOn;
    //     if (GameObject.FindGameObjectsWithTag("KChannelToggle").Length > 0) KOn = GameObject.FindGameObjectWithTag("KChannelToggle").GetComponent<Toggle>().isOn;

    //     for (int i = 0; i < GameObject.FindGameObjectWithTag("ModelMembrane").transform.childCount; i++)
    //     {
    //         var child = GameObject.FindGameObjectWithTag("ModelMembrane").transform.GetChild(i).gameObject;
    //         if (child != null)
    //             child.SetActive(false);
    //     }

    //     if (!NaOn && !ClOn && !KOn)
    //     {
    //         ZeroMembrane.SetActive(true);
    //     } else if (NaOn && !ClOn && !KOn) //1
    //     {
    //         NaMembrane.SetActive(true);
    //         NaLiner.SetActive(true);
    //     }
    //     else if (!NaOn && ClOn && !KOn) //2
    //     {
    //         ClMembrane.SetActive(true);
    //         ClLiner.SetActive(true);
    //     }
    //     else if (!NaOn && !ClOn && KOn) //3
    //     {
    //         KMembrane.SetActive(true);
    //         KLiner.SetActive(true);
    //     }
    //     else if(NaOn && ClOn && !KOn) //1 2
    //     {
    //         NaClMembrane.SetActive(true);
    //         NaLiner.SetActive(true);
    //         ClLiner.SetActive(true);
    //     }
    //     else if (!NaOn && ClOn && KOn) //2 3
    //     {
    //         ClKMembrane.SetActive(true);
    //         ClLiner.SetActive(true);
    //         KLiner.SetActive(true);
    //     }
    //     else if (NaOn && !ClOn && KOn) //1 3
    //     {
    //         NaKMembrane.SetActive(true);
    //         NaLiner.SetActive(true);
    //         KLiner.SetActive(true);
    //     }
    //     else if (NaOn && ClOn && KOn) //1 2 3
    //     {
    //         NaClKMembrane.SetActive(true);
    //         NaLiner.SetActive(true);
    //         ClLiner.SetActive(true);
    //         KLiner.SetActive(true);
    //     }
    // }

    public void ToggleFullscreen(Toggle fullscreenToggle)
    {
        if (fullscreenToggle.isOn)
        {
            Screen.SetResolution(Screen.width, Screen.height, true);
            Globals.fullscreenOn = true;
        }
        else
        {
            Screen.SetResolution(Screen.width, Screen.height, false);
            Globals.fullscreenOn = false;
        }
    }

    public void ToggleColorBlind(Toggle cbToggle)
    {
        GameObject sodiumAtom = Resources.Load("Prefabs/sodiumAtom") as GameObject;
        Material cbNA = Resources.Load("Materials/colorblind_sodium") as Material;
        Material normalNA = Resources.Load("Materials/sodiumAtom") as Material;

        if (cbToggle.isOn)
        {
            foreach (GameObject atom in GameObject.FindGameObjectsWithTag("SodiumAtom"))
            {
                atom.GetComponent<Renderer>().material = cbNA;
            }
            sodiumAtom.GetComponent<Renderer>().material = cbNA;
            Globals.colorblindOn = true;
        }
        else
        {
            foreach (GameObject atom in GameObject.FindGameObjectsWithTag("SodiumAtom"))
            {
                atom.GetComponent<Renderer>().material = normalNA;
            }
            sodiumAtom.GetComponent<Renderer>().material = normalNA;
            Globals.colorblindOn = false;
        }
    }

    // Update is called once per frame
    void Update () {
        
	}
}
