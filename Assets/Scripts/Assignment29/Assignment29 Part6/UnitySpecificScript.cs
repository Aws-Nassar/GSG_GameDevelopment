using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment296
{
    public class UnitySpecificScript : MonoBehaviour
    {
        GameObject targetObject, jokerObject, lightObject;
        

        void Start()
        {
            print("Game started!");
            
            //Use GameObject.Find() to locate "TargetObject" by its name.
            targetObject = GameObject.Find("TargetObject");

            if(targetObject != null)
            {
                print($"Found object by name: {targetObject.name}");
            }
            
            else
            {
                print("No TargetObject found.");
            }

            //Use GameObject.FindGameObjectWithTag() to locate the "Joker" object by its tag.
            jokerObject = GameObject.FindGameObjectWithTag("Joker");

            if(jokerObject != null)
            {
                print($"Found object by tag: {jokerObject.name}");
            }
            
            else
            {
                print("No Joker object found.");
            }

            //Use GameObject.FindObjectOfType<>() to locate an object of type Light.
            lightObject = FindAnyObjectByType<Light>().gameObject;

            if(jokerObject != null)
            {
                print($"Found object of type Light: {lightObject.name}");
            }
            
            else
            {
                print("No Light object found.");
            }
        }

        void OnEnable()
        {
            print("GameObject Enabled");
        }

        void OnDisable()
        {
            print("GameObject Disabled");
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.D) && targetObject != null)
            {
                print("TargetObject Deactivated");
                targetObject.SetActive(false);
            }
        }
    }
}
