using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 3;
    private Rigidbody2D rb;

    public float Move;
    
        // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
          
    }

    // Update is called once per frame
    void Update()
       
    {
        //Move = 
        if (Input.GetKey("a")){
            Debug.Log(" input resived");
        }
    }
}
