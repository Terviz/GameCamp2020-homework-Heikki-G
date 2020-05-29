using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score;
    public GameObject Menu;

    void Start()
    {
        score = 0;
        Time.timeScale = 0;
    }
    void OnGUI()
    {
       GUI.Label(new Rect(0, 0, 100, 25), "Score: " + score);
    }

}
