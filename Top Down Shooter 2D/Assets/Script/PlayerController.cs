using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public static PlayerController Instance {get; set;}

    public void Awake()
    {
        Instance=this;
    }
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
        movement.x = SimpleInput.GetAxis("Horizontal");
        movement.y= SimpleInput.GetAxis("Vertical");

        rb.velocity =new Vector2(movement.x  * speed,movement.y*speed);
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
