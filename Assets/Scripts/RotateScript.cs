using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {

    public float speed;

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, speed);
    }
}
