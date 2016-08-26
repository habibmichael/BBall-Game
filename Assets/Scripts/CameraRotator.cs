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
        mouseY = Input.GetAxis("Mouse Y")*rotationSpeed;
        transform.localRotation = Quaternion.Euler(0, mouseX, 0) * transform.localRotation;
        Camera camera = GetComponentInChildren<Camera>();
        camera.transform.localRotation = Quaternion.Euler(-mouseY, 0, 0) * camera.transform.localRotation;

	
	}
}
