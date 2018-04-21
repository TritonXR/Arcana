using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blacklight : MonoBehaviour {

    public GameObject otherObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach(Transform child in transform)
        {
            if (otherObj.activeSelf && 
                otherObj.GetComponent<Light>().color.Equals(Color.blue) && 
                Math.Abs(child.position.x - otherObj.transform.position.x) < 5 && 
                Math.Abs(child.position.z - otherObj.transform.position.z) < 5)
            {
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(false);
            }
        }
	}
}
