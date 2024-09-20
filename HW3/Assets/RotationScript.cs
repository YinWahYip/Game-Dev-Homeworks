using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    // Speed of rotation
    public float rotationSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the cube or rectangle mesh around the Y-axis
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
