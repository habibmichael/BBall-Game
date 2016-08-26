using UnityEngine;
using System.Collections;

public class CameraRotator : MonoBehaviour {

    float mouseX;
    float mouseY;
    float rotationSpeed = 5f;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        mouseX = Input.GetAxis("Mouse X")*rotationSpeed;
        mouseY = Input.GetAxis("Mouse Y")+rotationSpeed;
        transform.rotation = Quaternion.Euler(-mouseY,mouseX,0) * transform.rotation;
	
	}
}
