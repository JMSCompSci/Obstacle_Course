using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    Rigidbody rb = null;

    public float xValue = 0f;
    public float yValue = 0f;
    public float zValue = 0f;
    public float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        xValue = Input.GetAxis("Horizontal")  * moveSpeed;
        zValue = Input.GetAxis("Vertical")  * moveSpeed;
        //this.transform.Translate(xValue, yValue, zValue);
        rb.velocity = new Vector3(xValue, 0f, zValue);
        
    }
}
