using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour{
    PlayerMovement playerMovement;

    private Vector3 noSoundRadius = new Vector3(0,0,0);
    private Vector3 walkSoundRadius = new Vector3(4f,4f,4f);


    private bool isWalkSound = false;

    private void Start(){
        playerMovement = GetComponent<PlayerMovement>();

        transform.localScale = noSoundRadius;
    }

    private void FixedUpdate() {
        if (playerMovement.GetMovementWalk() != Vector3.zero){ isWalkSound = true;
        }
        else{ isWalkSound = false;}
    }

    public void TriggerNoSoundRadius(){
        transform.localScale = Vector3.Lerp(transform.localScale, noSoundRadius, 1f);
    }
    public void TriggerSoundRadius(){
        transform.localScale = Vector3.Lerp(transform.localScale, walkSoundRadius, 10f);
    }



}
