using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 100f;

    private float xInput;
    private float yInput;
    // Update is called once per frame
    void Update()
    {
        
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(xInput * speed * Time.deltaTime, yInput * speed * Time.deltaTime, 0f);
        
        transform.position += playerMovement;
   
    }
    
}
