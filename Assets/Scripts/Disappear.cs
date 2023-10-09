using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Disappear : MonoBehaviour
{
    

    void Start()
    {
             
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="enemy")
        {
            
            Destroy(other.gameObject);
            GameObject.Find("LostTextManager").GetComponent<Lost>().IncreseLost();
            
        }
    }
}
