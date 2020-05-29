using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    private AudioSource harp;
    private float currentTime = 0f;

    void Start()
    {
        harp = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

         if (currentTime >= 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }           
    }

    void Shoot()
    {

        Instantiate(
            original: projectilePrefab,
            position: transform.position,
            rotation: Quaternion.identity
        );

        harp.Play();

    }
}
