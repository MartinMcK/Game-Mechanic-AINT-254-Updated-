using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position; //Tells the player they will be repawned at the position allocated 
    }
}
