using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySound : MonoBehaviour{
    private Vector3 soundPosition;

    private void OnTriggerEnter(Collider other){
        if (other.tag == "SoundSource"){
            soundPosition = other.transform.position;
        }
    }

    public void ClearSoundPosition(){
        soundPosition = Vector3.zero;
    }
    public Vector3 GetSoundPosition(){
        return soundPosition;
    }



}
