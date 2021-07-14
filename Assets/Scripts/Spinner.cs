using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float xSpinSpeed = 0f;
    [SerializeField] float ySpinSpeed = 0f;
    [SerializeField] float zSpinSpeed = 0f;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(xSpinSpeed * Time.deltaTime,ySpinSpeed * Time.deltaTime,zSpinSpeed * Time.deltaTime);
    }
}
