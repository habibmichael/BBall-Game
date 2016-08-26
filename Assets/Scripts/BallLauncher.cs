using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

    public float ballSpeed = 15f;
   public  GameObject ballPrefab;
    GameObject ballInstance;
    Rigidbody rb;
    Camera camera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Look for button click or left-ctrl
        if (Input.GetButtonDown("Fire1"))
        {
           //Create Ball & Update Location
            ballInstance = Instantiate(ballPrefab);
            camera = GetComponentInChildren<Camera>();
            ballInstance.transform.position = camera.transform.position;


            rb = ballInstance.GetComponent<Rigidbody>();
            //Launch Ball in Direction Camera is Viewing
            rb.velocity = (camera.transform.rotation * Vector3.forward) * ballSpeed;
        }
	}
}
