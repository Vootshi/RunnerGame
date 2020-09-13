using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    public float obstacleRotationSpeed=1f;

    private void FixedUpdate()
    {
        transform.Rotate(0f, 0f, transform.position.z * obstacleRotationSpeed * Time.fixedDeltaTime);
    }
}
