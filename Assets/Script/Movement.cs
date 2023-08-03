using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rigid;
    Vector2 movement;
    public Animator anim;
    public SpriteRenderer spriteRenderer;
    public MovementJoystick movementJoystick;

    void Update()
    {
        movement.x = movementJoystick.joystickVec.x * speed;
        movement.y = movementJoystick.joystickVec.y * speed;
        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);
    }


    void FixedUpdate()
    {
        if (movementJoystick.joystickVec.y != 0)
        {
            rigid.MovePosition(rigid.position + movement.normalized * speed * Time.fixedDeltaTime);            
        }
        /*else
        {
            rigid.velocity = Vector2.zero;
        }*/
    }


}
