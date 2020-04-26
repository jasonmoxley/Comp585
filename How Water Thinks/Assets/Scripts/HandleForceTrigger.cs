using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HandleForceTrigger : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

 void OnCollisionEnter(Collision c)
  {
        float slider = GameObject.FindGameObjectWithTag("moleculeSize").GetComponent<Slider>().value;
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (slider > 0.25)
        {
            print("size slider too big");
            return;
        }
        else if (sceneName == "Level 4") {
            // print("here");
            if (this.tag == "NaForce")
            {
                if (c.gameObject.tag == "SodiumAtom")
                {
                    // GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
                    Physics.IgnoreCollision(c.collider, GetComponent<Collider>());
                }
            }
            else if (this.tag == "KForce")
            {
                if (c.gameObject.tag == "PotassiumAtom")
                {
                    // GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
                    Physics.IgnoreCollision(c.collider, GetComponent<Collider>());
                }
            }
            else if (this.tag == "ClForce")
            {
                if (c.gameObject.tag == "ChlorineAtom")
                {
                    if (c.gameObject.transform.position.y < 214.95)
                    {
                        Physics.IgnoreCollision(c.collider, GetComponent<Collider>());
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        else if (sceneName == "Level 3") {
            //float voltageOuter = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltageOuter();
            //float voltageInner = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltageInner();
            float totalVoltage = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltage();
            //print(totalVoltage);
            if (totalVoltage >= 70) {
                if (this.tag == "NaForce")
                {
                    if (c.gameObject.tag == "SodiumAtom")
                    {
                        if (c.gameObject.transform.position.y > 214.95)
                        {
                            // GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
                            Physics.IgnoreCollision(c.collider, GetComponent<Collider>());

                        }
                        else
                        {
                            
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else if (this.tag == "KForce")
                {
                    if (c.gameObject.tag == "PotassiumAtom")
                    {
                        if (c.gameObject.transform.position.y > 214.95)
                        {
                            // GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
                            Physics.IgnoreCollision(c.collider, GetComponent<Collider>());

                        }
                        else
                        {
                            return;
                        }
                    }
                    else 
                    {
                        return;
                    }
                }
            } else if (totalVoltage <= -70) {
                if (this.tag == "NaForce")
                {
                    if (c.gameObject.tag == "SodiumAtom")
                    {
                        if (c.gameObject.transform.position.y < 214.95)
                        {
                            // GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
                            Physics.IgnoreCollision(c.collider, GetComponent<Collider>());

                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else if (this.tag == "KForce")
                {
                    if (c.gameObject.tag == "PotassiumAtom")
                    {
                        if (c.gameObject.transform.position.y < 214.95)
                        {
                            // GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
                            Physics.IgnoreCollision(c.collider, GetComponent<Collider>());

                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        Physics.IgnoreCollision(c.collider, GetComponent<Collider>());
                    }
                }
            }
            else {
                if (this.tag == "NaForce")
                {
                    if (c.gameObject.tag == "SodiumAtom")
                    {
                        // GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
                        Physics.IgnoreCollision(c.collider, GetComponent<Collider>());
                    }
                    else
                    {
                        return;
                    }
                }
                else if (this.tag == "KForce")
                {
                    
                    if (c.gameObject.tag == "PotassiumAtom")
                    {
                        // GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
                        Physics.IgnoreCollision(c.collider, GetComponent<Collider>());
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        else { // level 1 or 2
            print("return statement not working");
            if (this.tag == "NaForce")
            {
                if (c.gameObject.tag == "SodiumAtom")
                {
                    // GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
                    Physics.IgnoreCollision(c.collider, GetComponent<Collider>());
                }
            }
            else if (this.tag == "KForce")
            {
                if (c.gameObject.tag == "PotassiumAtom")
                {
                    // GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
                    Physics.IgnoreCollision(c.collider, GetComponent<Collider>());
                }
            }
        }
    }


    // private void OnTriggerEnter(Collider c)
    // {
    //     Scene currentScene = SceneManager.GetActiveScene();
    //     string sceneName = currentScene.name;
    //     if (sceneName == "Level 3") {
    //         //float voltageOuter = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltageOuter();
    //         //float voltageInner = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltageInner();
    //         float totalVoltage = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltage();
    //         //print(totalVoltage);
    //         if (totalVoltage >= 70) {
    //             if (this.tag == "NaForce")
    //             {
    //                 if (c.gameObject.tag == "SodiumAtom")
    //                 {
    //                     if (c.gameObject.transform.position.y > 214.95)
    //                     {
    //                         //GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
    //                         return;
    //                     }
    //                     else
    //                     {
                            
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //                     }
    //                 }
    //                 else
    //                 {
    //                     if (c.gameObject.transform.position.y > 214.95)
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //                     }
    //                     else
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //                     }
    //                 }
    //             }
    //             else if (this.tag == "KForce")
    //             {
    //                 if (c.gameObject.tag == "PotassiumAtom")
    //                 {
    //                     if (c.gameObject.transform.position.y > 214.95)
    //                     {
    //                         //GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
    //                         return;
    //                     }
    //                     else
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //                     }
    //                 }
    //                 else 
    //                 {
    //                     if (c.gameObject.transform.position.y > 214.95)
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //                     }
    //                     else
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //                     }
    //                 }
    //             }
    //         } else if (totalVoltage <= -70) {
    //             if (this.tag == "NaForce")
    //             {
    //                 if (c.gameObject.tag == "SodiumAtom")
    //                 {
    //                     if (c.gameObject.transform.position.y < 214.95)
    //                     {
    //                         //GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
    //                         return;
    //                     }
    //                     else
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //                     }
    //                 }
    //                 else
    //                 {
    //                     if (c.gameObject.transform.position.y > 214.95)
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //                     }
    //                     else
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //                     }
    //                 }
    //             }
    //             else if (this.tag == "KForce")
    //             {
    //                 if (c.gameObject.tag == "PotassiumAtom")
    //                 {
    //                     if (c.gameObject.transform.position.y < 214.95)
    //                     {
    //                         //GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
    //                         return;
    //                     }
    //                     else
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //                     }
    //                 }
    //                 else
    //                 {
    //                     if (c.gameObject.transform.position.y > 214.95)
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //                     }
    //                     else
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //                     }
    //                 }
    //             }
    //         }
    //         else {
    //             if (this.tag == "NaForce")
    //             {
    //                 if (c.gameObject.tag == "SodiumAtom")
    //                 {
    //                     //GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
    //                     return;
    //                 }
    //                 else
    //                 {
    //                     if (c.gameObject.transform.position.y > 214.95)
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //                     }
    //                     else
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //                     }
    //                 }
    //             }
    //             else if (this.tag == "KForce")
    //             {
                    
    //                 if (c.gameObject.tag == "PotassiumAtom")
    //                 {
    //                     //GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
    //                     return;
    //                 }
    //                 else
    //                 {
    //                     if (c.gameObject.transform.position.y > 214.95)
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //                     }
    //                     else
    //                     {
    //                         c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //                     }
    //                 }
    //             }
    //         }
    //     }
    //     else { // level < 3
            // if (this.tag == "NaForce")
            // {
            //     if (c.gameObject.tag == "SodiumAtom")
            //     {
            //         // GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
            //         return;
            //     }
            //     else
            //     {
            //         if (c.gameObject.transform.position.y > 214.95)
            //         {
            //             c.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(c.gameObject.GetComponent<Rigidbody>().velocity.x, c.gameObject.GetComponent<Rigidbody>().velocity.y * -1, c.gameObject.GetComponent<Rigidbody>().velocity.z);
            //             c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
            //         }
            //         else
            //         {
            //             c.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(c.gameObject.GetComponent<Rigidbody>().velocity.x, c.gameObject.GetComponent<Rigidbody>().velocity.y * -1, c.gameObject.GetComponent<Rigidbody>().velocity.z);
            //             c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
            //         }
            //     }
            // }
            // else if (this.tag == "KForce")
            // {
                
            //     if (c.gameObject.tag == "PotassiumAtom")
            //     {
            //         //GameObject.Find("AtomCrossingSound").GetComponent<AudioSource>().Play();
            //         return;
            //     }
            //     else
            //     {
            //         if (c.gameObject.transform.position.y > 214.95)
            //         {
            //             // c.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            //             c.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(c.gameObject.GetComponent<Rigidbody>().velocity.x, c.gameObject.GetComponent<Rigidbody>().velocity.y * -1, c.gameObject.GetComponent<Rigidbody>().velocity.z);
            //             // c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));

            //         }
            //         else
            //         {
            //             // c.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

            //             c.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(c.gameObject.GetComponent<Rigidbody>().velocity.x, c.gameObject.GetComponent<Rigidbody>().velocity.y * -1, c.gameObject.GetComponent<Rigidbody>().velocity.z);
            //             // c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));

            //         }
            //     }
            // }
    //     }
    // }

    // private void OnTriggerEnter(Collider c)
    // {
    //     bool letThrough = false;
    //     float reflectChance = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().reflectChance;
    //     //if (reflectChance < 2) reflectChance = 2.0f;
    //     if (Random.Range(1.0f, 100.0f) <= reflectChance) letThrough = true;

    //     //float voltageOuter = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltageOuter();
    //     //float voltageInner = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltageInner();
    //     float totalVoltage = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltage();

    //     if (this.tag == "NaForce")
    //     {
    //         if (c.gameObject.tag == "SodiumAtom")
    //         {
    //             if (totalVoltage > (GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage()))
    //             {
    //                 if (c.gameObject.transform.position.y <= 214.95)
    //                 {
    //                     //Debug.Log("100% chance of sodium from inner to outer.");
    //                     return;
    //                 }
    //             }
    //             if (totalVoltage < (GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage()))
    //             {
    //                 if (c.gameObject.transform.position.y > 214.95)
    //                 {
    //                     //Debug.Log("100% chance of sodium from outer to inner.");
    //                     return;
    //                 }
    //             }

    //             if (!letThrough)
    //             {
    //                 if (c.gameObject.transform.position.y > 214.95)
    //                 {
    //                     c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //                 }
    //                 else
    //                 {
    //                     c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //                 }
    //             }
    //         }
    //         else if (c.gameObject.tag == "ChlorineAtom")
    //         {
    //             if (c.gameObject.transform.position.y > 214.95)
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //             }
    //             else
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //             }
    //         }
    //         else if (c.gameObject.tag == "PotassiumAtom")
    //         {
    //             if (c.gameObject.transform.position.y > 214.95)
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //             }
    //             else
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //             }
    //         }
    //     }
    //     else if (this.tag == "ClForce")
    //     {
    //         if (c.gameObject.tag == "SodiumAtom")
    //         {
    //             if (c.gameObject.transform.position.y > 214.95)
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //             }
    //             else
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //             }
    //         }
    //         else if (c.gameObject.tag == "ChlorineAtom")
    //         {
    //             if (totalVoltage < (GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage()))
    //             {
    //                 if (c.gameObject.transform.position.y <= 214.95)
    //                 {
    //                     //Debug.Log("100% chance of chlorine from inner to outer.");
    //                     return;
    //                 }
    //             }
    //             if (totalVoltage > (GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage()))
    //             {
    //                 if (c.gameObject.transform.position.y > 214.95)
    //                 {
    //                     Debug.Log("100% chance of chlorine from outer to inner.");
    //                     return;
    //                 }
    //             }

    //             if (!letThrough)
    //             {
    //                 if (c.gameObject.transform.position.y > 214.95)
    //                 {
    //                     c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //                 }
    //                 else
    //                 {
    //                     c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //                 }
    //             }
    //         }
    //         else if (c.gameObject.tag == "PotassiumAtom")
    //         {
    //             if (c.gameObject.transform.position.y > 214.95)
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //             }
    //             else
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //             }
    //         }
    //     }
    //     else if (this.tag == "KForce")
    //     {
    //         if (c.gameObject.tag == "SodiumAtom")
    //         {
    //             if (c.gameObject.transform.position.y > 214.95)
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //             }
    //             else
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //             }
    //         }
    //         else if (c.gameObject.tag == "ChlorineAtom")
    //         {
    //             if (c.gameObject.transform.position.y > 214.95)
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //             }
    //             else
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //             }
    //         }
    //         else if (c.gameObject.tag == "PotassiumAtom")
    //         {
    //             //if (!letThrough)
    //             //{
    //             if (c.gameObject.transform.position.y > 214.95)
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
    //             }
    //             else
    //             {
    //                 c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
    //             }
    //             //}
    //         }
    //     }
    // }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage());
    }
}
