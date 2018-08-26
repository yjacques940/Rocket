using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    private Rigidbody rigidBody;
    [SerializeField] public float ForceUpward = 100;
    [SerializeField] public float ForceToRight= 25;
    [SerializeField] public float ForceToLeft = 25;
    // Use this for initialization
    void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            rigidBody.AddForce(new Vector3(0, ForceUpward, 0));
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            rigidBody.AddForceAtPosition(new Vector3(ForceToRight,0,0),new Vector3());
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            rigidBody.AddForceAtPosition(new Vector3(0, ForceToLeft, 0), new Vector3());
        }
	}
}
