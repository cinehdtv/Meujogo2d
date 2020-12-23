using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour
{
    public float speed;
    private Rigidbody2D rig;
    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            rig = GetComponent<Rigidbody2D>();
            float moveHorisontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            rig.velocity = new Vector2(moveHorisontal * speed, moveVertical * speed);
            
        }
    }

    private void Update()
    {
        HandleMovement();
    }
}
