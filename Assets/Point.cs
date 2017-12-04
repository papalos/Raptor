using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnMouseDown()
    {
        // = GameObject.Find("objSoldier");
        if (Common.movingObj != null)
        {
            Common.target = this.gameObject;
        }
    }
}
