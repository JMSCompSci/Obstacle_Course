using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public float xValue = 0f;
    public float yValue = 0f;
    public float zValue = 0f;
    public float moveSpeed = 10f;

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        this.transform.Translate(xValue, yValue, zValue);
        
    }
}
