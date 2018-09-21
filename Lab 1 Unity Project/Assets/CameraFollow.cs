using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform targetTransform;
    Transform myTransform;

	// Use this for initialization
	void Start () {
        myTransform = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
        myTransform = targetTransform;
        
	}
}
