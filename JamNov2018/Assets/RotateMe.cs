using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour {

    public float RotateSpeed = 10.0f;
    Rigidbody2D rbSpiky;
    public GameObject Spiky;
    private Vector3 lastPos;
    private bool gauche = false;

	// Use this for initialization
	void Start () {
        rbSpiky = Spiky.GetComponent<Rigidbody2D>();
        lastPos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float move = Input.GetAxis("Mouse X");


        if (move > 0)
        {
            gauche = false;
        }
        else if (move < 0)
        {
            gauche = true;

        }


        if (gauche == false && lastPos != transform.position)
        {
            transform.Rotate(Vector3.forward * -RotateSpeed);
            //print(Input.GetAxis("Mouse X"));
            lastPos = transform.position;
        }
        else if (gauche == true && lastPos != transform.position)
        {
            transform.Rotate(Vector3.forward * RotateSpeed);
            //print(Input.GetAxis("Mouse X"));
            lastPos = transform.position;

        }
        
    }
}
