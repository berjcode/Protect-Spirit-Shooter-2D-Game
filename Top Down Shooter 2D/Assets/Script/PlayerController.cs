using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Components
    public Rigidbody2D rb;
    public Animator animator;
    //GamePlay
    public float speed;
    private Vector2 movement;





    
    void Start()
    {
        
    }

 
    void Update()
    {
        MovementMake();
        
    }


    #region  Movement Codes
    private void MovementMake()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y=Input.GetAxis("Vertical");

        rb.velocity =new Vector2(movement.x * speed,movement.y*speed);
        RunAnim();

    }
    #endregion 

   #region  Character Animations
    private void RunAnim()
    {
        if(movement.x != 0 || movement.y != 0)
        {
            animator.SetBool("isRuning",true);
        }else
        {
            animator.SetBool("isRuning",false);
        }
    }

    #endregion
}
