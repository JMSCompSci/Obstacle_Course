//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //[SerializeField] Material newMaterial = null;

    void OnCollisionEnter(Collision other)
    {
        // Debug.Log($"Ouch! The {this.gameObject.name} got in my way!");
        this.GetComponent<Renderer>().material.color = Color.red;
    }
    
}
