using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 30f;
    public float lifetime = 5;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        Destroy(gameObject, lifetime);

        
	}

   
    //IEnumerator Die(float waitTime)
    //{
      //  yield return new WaitForSeconds(waitTime);
    //
    //}
}
