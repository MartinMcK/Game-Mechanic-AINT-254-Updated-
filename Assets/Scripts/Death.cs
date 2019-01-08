using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    public AudioSource deathSound;

	// Use this for initialization
	void Start () {

        deathSound = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            deathSound.Play();

            
        }
    }
}
