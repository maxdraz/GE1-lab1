using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {

    Rigidbody rb;
    public float speed = 5f;
    public float rotationSpeed = 5f;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float vMove = Input.GetAxis("Vertical");
        float hMove = Input.GetAxis("Horizontal");
        Debug.Log(vMove);

        transform.Translate(Vector3.forward * vMove * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * hMove * rotationSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }

    }

    public void Fire()
    {
        Instantiate(bulletPrefab, bulletSpawn);
    }

}
