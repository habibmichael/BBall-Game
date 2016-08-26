using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab;
    GameObject ballInstance;
    Rigidbody rb;
    float speed=5f;

	// Use this for initialization
	void Start () {

      
	
	}

    // Update is called once per frame
    void Update () {
        /*
            if (Input.GetKeyDown(KeyCode.Space))
            {
               GameObject instance = Instantiate(ballPrefab);
               Rigidbody rb =  instance.GetComponent<Rigidbody>();

            }
            */
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ballInstance = Instantiate(ballPrefab);
            rb = ballInstance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.up *speed;

         }
        else if (Input.GetKeyDown(KeyCode.DownArrow))

        {
            ballInstance = Instantiate(ballPrefab);
            rb = ballInstance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.down *speed;

        } else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ballInstance = Instantiate(ballPrefab);
            rb = ballInstance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.left *speed;

        }  else if (Input.GetKeyDown(KeyCode.RightArrow))   {

            ballInstance = Instantiate(ballPrefab);
            rb = ballInstance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.right *speed;

        }
	}
}
