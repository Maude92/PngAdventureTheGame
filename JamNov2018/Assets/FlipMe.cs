using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipMe : MonoBehaviour {

    private bool faceRight = true;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        float move = Input.GetAxis("Mouse X");

        if (move > 0 && !faceRight)
        {
            Flip();
        }
        else if (move < 0 && faceRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        faceRight = !faceRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
