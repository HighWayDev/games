using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool jumpKeyWasPressed;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if space key is pressed down
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }
    }


    //FixedUpdate is called once every physic update
    private void FixedUpdate()
    {
        if (jumpKeyWasPressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
    }














}
