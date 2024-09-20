using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed * 2;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed * 2;
        transform.Translate(xValue, 0, zValue);


        // Update the cube's position
    }
}
