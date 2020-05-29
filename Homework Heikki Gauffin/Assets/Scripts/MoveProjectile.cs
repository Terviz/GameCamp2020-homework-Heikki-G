using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public float speed = 100f;
    private Vector3 screenBounds = new Vector3 (280, 157, 0);


    void Update()

    {   // The projectile will go straight right on the x axis
        transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);

        // Destroy the projectile once it goes out of bounds
        if (transform.position.x > screenBounds.x)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {   
        // if the object the projectile collided with was tagged with ufo, destroy the other object and the projectile and add to score
        if (other.tag == "Ufo")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Score.score++;
        }
    }
}
