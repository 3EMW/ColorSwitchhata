using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turning : MonoBehaviour
{
    public static float turningSpeed = 100;

    private void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(0f, 0f, turningSpeed);
    }
}
