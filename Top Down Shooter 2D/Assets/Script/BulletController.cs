using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Vector2  target;
    public float speed;


    void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            target,
            speed* Time.deltaTime


        );
        Destroy(gameObject,1f);
    }

     private void OnTriggerEnter2D(Collider2D  col)
    {
        if(col.tag =="enemy")
        {
            Destroy(gameObject);
        }

        
    }


    
}
