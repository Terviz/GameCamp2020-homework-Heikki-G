using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Parameters for the prefab, timers duration and the current time
    public GameObject prefab;
    public float spawnInterval = 2f;
    private float currentTime = 0f;

    private Vector3 screenBounds = new Vector3 (280, 157, 0);
    
    // Update is called once per frame

    void Update()
    {
        currentTime += Time.deltaTime;
        // Add to the current time the time between the previous and current frame


        if (currentTime >= spawnInterval)
        {
            currentTime = 0f;

            // Given random y value within -4 and 3 so that the newly spawned ufos will not only spawn in a single line
            var position = new Vector3(290f, Random.Range(screenBounds.y * -1 + 20f, screenBounds.y - 20f), 0f);

            Instantiate(
                original: prefab, 
                position: position,
                rotation: Quaternion.identity
            );
        }
    }
}
