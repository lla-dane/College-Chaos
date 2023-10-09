using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float steerSpeed=0.1f;
    public float moveSpeed=3f;
    public Transform[] respawnPosition;
    public TextMeshProUGUI caughtText;

    public int caught=0;

    void Awake()
    {
        Time.timeScale = 0f;     
    }
    void Start()
    {
        caughtText.text = "CAUGHT " + caught;
    }

   
    void Update()
    {
        float steerAmount=Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;
        float moveAmount=Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;

        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag=="enemy")
        {
            caught += 1;            
            Destroy(other.gameObject);
            GameObject.Find("AudioManager").GetComponent<SoundManager>().PlayEnemyCaught();
            caughtText.text = "CAUGHT " + caught;
        }   
        
        if(other.tag=="respawn")
        {
            gameObject.transform.position = respawnPosition[Random.Range(0, respawnPosition.Length)].position;
            GameObject.Find("AudioManager").GetComponent<SoundManager>().PlayPlayerRespawn();
        }
    }

    
}
