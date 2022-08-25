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

    private float horizontal;
    private float vertical;
    private Vector2 movement;


    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
 
    void Update()
    {
        MovementMake();
        
    }


    #region  Movement Codes
    private void MovementMake()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical= Input.GetAxis("Vertical");

        rb.velocity =new Vector2(horizontal * speed,vertical*speed);
        RunAnim();

    }
    #endregion 

   #region  Character Animations
    private void RunAnim()
    {
        if(horizontal!= 0 || vertical != 0)
        {
            animator.SetBool("isRuning",true);
        }else
        {
            animator.SetBool("isRuning",false);
        }
    }

    #endregion



    #region MoveButton
    public void GoLeft()
    {
        horizontal =-1;
    }

    public void GoRight()
    {
       horizontal =1;
    }

    public void StopButton()
    {
       horizontal =0;
   
    }
     public void StopButtonY()
    {
       vertical=0;
   
    }

    public void GoUp()
    {
       vertical =1;

    }
    public void GoDown()
    {
        vertical=-1;
    }




    #endregion





}
