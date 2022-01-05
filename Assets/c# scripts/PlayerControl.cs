using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{   
    [SerializeField] float speed = 50f;
    
    [SerializeField] float rotatespeed = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        rotate();
    }

    void rotate()
    {
        float Rotate = Input.GetAxis("Rotate") * rotatespeed * Time.deltaTime;
        transform.Rotate(0, 0, Rotate, Space.Self);  
    }

    void Movement()
    {   
        //  * speed * Time.deltaTime;
        // transform.Translate(Horizontal,0,0, Space.Self);
        
        // float Vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        // transform.Translate(0, Vertical, 0, Space.Self);

        float Horizontal = Input.GetAxis("Horizontal");
        float Xoffset = Horizontal * Time.deltaTime * speed;
        float Xthrow = transform.localPosition.x + Xoffset; 
        
        
        float Vertical = Input.GetAxis("Vertical");
        float Yoffset = Vertical * Time.deltaTime * speed;
        float YThrow = transform.localPosition.y + Yoffset;   ;
        
        transform.localPosition = new Vector3 (Xthrow,YThrow,transform.localPosition.z);

        
        
    
    
    }

}
