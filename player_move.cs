using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public  float speed_Move;
    float x_Move;
    float z_Move;
    public float jump;
    public float gravity;
    CharacterController player;
    Vector3 move_Direction;   
   


    void Start()
    {
        player = GetComponent<CharacterController>();
    }

 
    void Update()
    {
        Move();
    }
    void Move()
    {
    x_Move = Input.GetAxis("Horizontal");
    z_Move = Input.GetAxis("Vertical");
     if (player.isGrounded)
        {
          move_Direction = new Vector3(x_Move, 0f, z_Move);
          move_Direction = transform.TransformDirection(move_Direction);
        
        if(Input.GetKey(KeyCode.Space))
        {
            move_Direction.y += jump;
        }
        if(Input.GetKey(KeyCode.LeftControl))
        {
        player.height = 1.2f;
        
        }
        else player.height = 1.8f;
        
       }  

         move_Direction.y -= gravity;
         player.Move(move_Direction * speed_Move * Time.deltaTime);




    }



}
