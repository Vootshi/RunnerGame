using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float speed = 10f;

    void FixedUpdate()
    {
        
        transform.Translate(Vector3.right * speed * Time.fixedDeltaTime);
        
        if(Mathf.Abs(transform.position.x) >= 7.5f)
        {
            speed = -speed;
        }

    }
}
