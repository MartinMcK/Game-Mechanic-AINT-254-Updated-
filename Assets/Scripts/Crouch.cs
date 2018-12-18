using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour {

    public CharacterController characterController;
	// Use this for initialization
	void Start ()
    {
        characterController = gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.C))
        {
            characterController.height = 0.4f;
        }
        else
        {
            characterController.height = 1.0f;
        }
	}
}
