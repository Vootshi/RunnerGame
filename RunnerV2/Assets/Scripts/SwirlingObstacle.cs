using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwirlingObstacle : MonoBehaviour
{
    public GameObject axis;
    float speed = 130f;
    
    void Start()
    {
        speed *= Random.Range(-1,2);
        if(speed == 0)
        {
            speed = -130f;
        }
    }

    void Update()
    {
        axis.transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
}
