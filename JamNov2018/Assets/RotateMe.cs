using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour {

    public float RotateSpeed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        float move = Input.GetAxis("Mouse X");

        if (move > 0)
        {
            transform.Rotate(Vector3.forward * -RotateSpeed);
        }
        else if (move < 0)
        {
            transform.Rotate(Vector3.forward * RotateSpeed);
        }
    }
}
