using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuxToggle : MonoBehaviour {

    // Use this for initialization
    void Start () {
    }

    void Update()
    {
        foreach(Transform child in transform)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
                if (child.gameObject.activeSelf)
                {
                    child.gameObject.SetActive(false);
                }
                else
                {
                    child.gameObject.SetActive(true);
                }
            }
        }
    }
}
