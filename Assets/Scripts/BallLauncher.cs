using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

    public float ballSpeed = 5f;
   public  GameObject ballPrefab;
    GameObject ballInstance;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Look for button click or left-ctrl
        if (Input.GetButtonDown("Fire1"))
        {
            ballInstance = Instantiate(ballPrefab);
            ballInstance.transform.position = transform.position;
            rb = ballInstance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.left * ballSpeed;
        }
	}
}
