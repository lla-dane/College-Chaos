using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D enemy;
    public Vector2 moveSpeed;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        enemy.velocity = moveSpeed;
    }

    
}
