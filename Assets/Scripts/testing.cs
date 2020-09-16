using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    private float moveSpeed = 5f;
    private float gravity = -9.81f;

    void Start()
    {
        
    }
    
    void Update()
    {
        //getInput();
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(horInput * moveSpeed * Time.deltaTime, verInput * moveSpeed * Time.deltaTime);
        //if (transform.position.y > -4f) transform.position += new Vector3(0, gravity * Time.deltaTime , 0);
    }

    void getInput()
    {
    }
}
