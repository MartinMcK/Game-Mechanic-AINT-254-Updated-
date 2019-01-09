using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour {

    bool isFalling = false;
    float downSpeed = 0;


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player");
        isFalling = true;
            
        
    }
    private void Update()
    {
        if (isFalling)
        {
            downSpeed += Time.deltaTime/20;
            transform.position = new Vector3(transform.position.x, //Falls on the Y Axis (down) at 20/100 speed
                transform.position.y - downSpeed,
                transform.position.z);
        }
    }

}
