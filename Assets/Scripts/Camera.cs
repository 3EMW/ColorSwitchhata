using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform ballPos;
    void Update()
    {
        if (ballPos.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, ballPos.position.y, transform.position.z);
        }
    }
}
