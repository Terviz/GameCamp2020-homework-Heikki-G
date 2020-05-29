using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUfoLeft : MonoBehaviour
{
    public float speed;
    private Vector3 screenBounds = new Vector3 (280, 157, 0);
 
    void Start()
    {   // Give the Ufos a random speed value between 1 and 9 when they spawn
        speed = Random.Range(20,100);
    }

    void Update() 
    {
        // Move the newly spawned Ufos to the left on the x axis
        transform.position += new Vector3 (speed * Time.deltaTime * -1, 0, 0);

        // Destroy the ufo if it goes out of the game bounds
        if (transform.position.x < screenBounds.x * -1)
        {
            Destroy(gameObject);
        }
    }

}
