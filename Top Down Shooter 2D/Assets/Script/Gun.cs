using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
     private Vector3 mousePos;

     public GameObject cross;

     public GameObject bullets;





 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        mousePos = Camera.main.ScreenToWorldPoint(
            new Vector3(
                Input.mousePosition.x,
                Input.mousePosition.y,
                transform.position.z

            ));

            cross.transform.position = new Vector3(
                mousePos.x,
                mousePos.y,
                transform.position.z
            );

            if(Input.GetMouseButtonDown(0))
            {
                Shoot();
            }

            Vector3 targetDirection =mousePos -transform.position;
            float rotateZ = Mathf.Atan2(targetDirection.y,targetDirection.x) * Mathf.Rad2Deg;
            transform.rotation= Quaternion.Euler(0f, 0f, rotateZ);

    }


    private void Shoot()
    {
        Instantiate(bullets,transform.position,Quaternion.identity);
    }


    


    


}
