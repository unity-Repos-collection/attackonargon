using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bobtree : MonoBehaviour
{   
    Vector3 startingposition;
    [SerializeField] Vector3 movementvector;
    float movementfactor; 
    [SerializeField] float Period = 2f;
    // Start is called before the first frame update
    void Start()
    {
        //get transform of object
        startingposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        sinwave();
    }

    void sinwave()
    {
        if (Period <= Mathf.Epsilon) {return;}
        
        float cycles = Time.time / Period; // growing over time
        
        const float tau = Mathf.PI * 2f; // constant value of 6.283
        float RawSinWave = Mathf.Sin(cycles * tau); // going from -1 to 1

        movementfactor = (RawSinWave + 1f) / 2f; // recalculated to go from 0 to 1
        
        
        Vector3 offset = movementvector * movementfactor; 
        transform.position = startingposition + offset;
    }
}


