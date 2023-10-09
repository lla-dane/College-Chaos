using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource[] enemyCaught;
    public AudioSource playerResapwn;

    public void PlayEnemyCaught()
    {
        enemyCaught[Random.Range(0, enemyCaught.Length)].Play();
    }

    public void PlayPlayerRespawn()
    {
        playerResapwn.Play();
    }

    
   
}
