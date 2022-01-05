using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spintree : MonoBehaviour
{
    [SerializeField] float rotatespeed = 0.1f;
    
    // Update is called once per frame
    void Update()  
    {
        TreeRotator();
    }

    void TreeRotator()    
    { 
        transform.Rotate(Vector3.up * Time.deltaTime * rotatespeed);
    }
}
