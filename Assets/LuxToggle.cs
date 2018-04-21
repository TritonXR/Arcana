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
                if (child.gameObject.activeSelf)
                {
                    child.gameObject.SetActive(false);
                }
                else
                {
                    child.gameObject.SetActive(true);
                }
            }

            if(child.gameObject.activeSelf)
            {
                if(Input.GetKeyDown(KeyCode.W))
                {
                    Light lt = child.gameObject.GetComponent<Light>();
                    //Material mat = child.gameObject.GetComponent<Renderer>().material;
                    if(lt.color == Color.blue)
                    {
                        lt.color = Color.Lerp(Color.blue, Color.white, 3);
                        //mat.SetColor("white", Color.white);
                    }
                    else
                    {
                        lt.color = Color.Lerp(Color.white, Color.blue, 3);
                        //mat.SetColor("blue", Color.blue);
                    }
                }
            }
        }
    }
}
