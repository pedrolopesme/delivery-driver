using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float steerSpeed= 200f; 
    float moveSpeed= 8f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float movimentAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        if (movimentAmount != 0f) 
        {
            if(movimentAmount > 0f)
            {
                transform.Rotate(0, 0, -steerAmount);
            }  else {
                transform.Rotate(0, 0, steerAmount);
            }
        }

        transform.Translate(0, movimentAmount, 0); 
    }
}
