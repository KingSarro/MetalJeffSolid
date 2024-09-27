using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySight : MonoBehaviour{
    //Create a gameObject to hold a player reference
    [SerializeField] private Transform playerRef;

    [SerializeField] private float dotVisionCone;

    //Setup and initialize all the variables
    private void Start(){
        if(playerRef == null){ playerRef = FindAnyObjectByType<PlayerMovement>().gameObject.transform; }
    }

    private void Update(){
        DotProduct();
        
    }

    private void DotProduct(){
        //Check the normalized distance between this enemy and the player
        Vector3 distanceFromPlayer = (playerRef.position - transform.position).normalized;
        //Get the enemies forward direction
        Vector3 forwardDir = transform.forward;

        //Get the dot product of of the enemy of

        //--The dot product is a decimal that ranges from -1 to 1
        //-1 is behind the object, 0 is to the sides of the object, and 1 is in front of the object
        float dotProductOfPlayer = Vector3.Dot(distanceFromPlayer, forwardDir);
        ////Debug.Log("The dot product is " + dotProductOfPlayer);
        ///
        //Checks where in the player is relative to the enemy
        //If In front
        if(dotProductOfPlayer >= dotVisionCone){
            Debug.Log("Player is in front of enemy: " + gameObject.name);
        }
        //If Behind
        else if(dotProductOfPlayer <= -dotVisionCone){
            Debug.Log("Player is behind enemy: " + gameObject.name);
        }
        //If to side
        else{
            Debug.Log("Player is to the side of enemy: " + gameObject.name);
        }
    }
}
