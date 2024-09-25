using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySight : MonoBehaviour{
    //Create a gameObject to hold a player reference
    [SerializeField] private GameObject playerRef;

    //Setup and initialize all the variables
    private void Start(){
        if(playerRef == null){ playerRef = FindAnyObjectByType<PlayerMovement>().gameObject; }
    }

    private void Update(){
        //Check the normalized distance between this enemy and the player
        Vector3 distanceFromPlayer = (playerRef.transform.position - transform.position).normalized;
    }
}
