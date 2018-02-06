using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Sphere : MonoBehaviour {

    public GameObject sphere;
    public float speedScale;

    // Use this for initialization
    void Start () {
        // Get the current game object
        sphere = this.gameObject;

        speedScale = 50.0f;
    }

    // Update is called once per frame
    void Update () {
        sphere.transform.Rotate (Vector3.up * Time.deltaTime * speedScale);
    }
}
