using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float steerSpeed= 1f;
    float moveSpeed= 0.001f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        float movementAmount = Input.GetAxis("Vertical") * moveSpeed;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, movementAmount, 0); 
    }
}
