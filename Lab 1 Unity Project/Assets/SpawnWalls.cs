using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalls : MonoBehaviour {

    public float wallCount;
    Transform myTransform;
    public float spacing = 5f;

	// Use this for initialization
	void Start () {

        myTransform = gameObject.transform;

        for (int x = 0; x < wallCount; x++)
        {
            for (int y = 0; y< wallCount; y++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.AddComponent<Rigidbody>();
                //cube.GetComponent<Rigidbody>().isKinematic = true;
                //cube.GetComponent<Renderer>().material.color
                
                cube.transform.position = new Vector3(myTransform.position.x + x * spacing, myTransform.position.y + y * spacing, myTransform.position.z);
                //StartCoroutine(SwitchOnKinematic(2f, cube));
            }
        }
	}
	
   // IEnumerator SwitchOnKinematic(float time, GameObject cube)
   // {
     //   yield return new WaitForSeconds(time);
     //   cube.GetComponent<Rigidbody>().isKinematic = false;
    //}

	// Update is called once per frame
	void Update () {
		
	}
}
