using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to force the game object to stay within the game playe area. This is determined by using the game camera size and enforced via clamps
public class ObjectInsideGameArea : MonoBehaviour
{
    // Assign MainCamera to this variable in Unity, used to get the game screen size for the boundary calculations
    private Vector3 screenBounds = new Vector3 (280, 157, 0);
    private float objectWidth;
    private float objectHeight;

    void Start()
    {
        // Get the object Width and Height from the spriterenderer to substract from the clamps so the whole sprite stays inside the area
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //extents = size of height / 2
    }
    // Update is called once per frame
    void Update()
    {
        // Forces the x and y position values of the object to be between the min and max values, in this case the boundaries (camera) x and y values
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth), 
        Mathf.Clamp(transform.position.y, screenBounds.y * -1 + objectHeight, screenBounds.y - objectHeight),
        transform.position.z);
    }
}
