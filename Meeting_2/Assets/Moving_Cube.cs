using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Cube : MonoBehaviour {

    public GameObject cube;
    public GameObject camera;

    public float maxSpeed;
    public float acceleration;
    public float speed;

    // Use this for initialization
    void Start () {

		// Get the current game object
        cube = this.gameObject;

        maxSpeed = 1.0f;
        acceleration = 0.1f;
        speed = 0.0f;
    }

    // Update is called once per frame
    void Update () {
        // Create the new vector that this cube is going to be at
//		float currentZPosition = cube.transform.position.z;
//        Vector3 newPosition = new Vector3 (
//            cube.transform.position.x,
//            cube.transform.position.y,
//			currentZPosition + (float)0.01
//        );
//        cube.transform.position = newPosition;


//      // This doesn't work - why?
//      cube.transform.position.z = cube.transform.position.z + (float)0.01;
//      cube.transform.position.z += (float)0.01;


//      // Sets the speed with acceleration
//      speed = speed + (acceleration * Time.deltaTime);
//      Vector3 newPosition = new Vector3 (
//          cube.transform.position.x,
//          cube.transform.position.y,
//          cube.transform.position.z + (speed * Time.deltaTime)
//      );
//      cube.transform.position = newPosition;


//      // Sets the speed with acceleration, but has a limit on the max speed
//      if (speed < maxSpeed) {
//          speed = speed + (acceleration * Time.deltaTime);
//      }
//      Vector3 newPosition = new Vector3 (
//          cube.transform.position.x,
//          cube.transform.position.y,
//          cube.transform.position.z + (speed * Time.deltaTime)
//      );
//      cube.transform.position = newPosition;

    }
}
