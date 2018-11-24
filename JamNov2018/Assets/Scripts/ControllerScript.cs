using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour {

    //	public float moveSpeed = 0.004f;
    //
    //
    //	// Update is called once per frame
    //	void Update () {
    //
    //
    ////		transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), moveSpeed);
    ////
    ////		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    ////		difference.Normalize();
    ////		//float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
    ////		//transform.rotation = Quaternion.Euler(0f, 0f, rotation_z);
    //	}

    private Vector3 targetPos;
    public float speed = 2.0f;


    void Start() {
        targetPos = transform.position;
    }

    void Update() {
        float distance = transform.position.z - Camera.main.transform.position.z;
        targetPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        targetPos = Camera.main.ScreenToWorldPoint(targetPos);

        Vector3 followXonly = new Vector3(targetPos.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, followXonly, speed * Time.deltaTime);
    }

    


}
