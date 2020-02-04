using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    //This is a reference to Rigidbody component called  rb
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewaysforce = 500f;
    
   

    // Update is called once per frame
    //We are using Fixedupdate because we are using it to mess with physics and unity loves it
    void FixedUpdate()
    {
        //Add A forward Force
        rb.AddForce(0, 0, forwardforce * Time.deltaTime); 
        //Adding movement to the right (all on the x axis)
        if (Input.GetKey("m"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //Adding movement to the left (all on the x axis)
        if (Input.GetKey("n"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < - 1f)
        {
            FindObjectOfType<gm>().GameOver();
        }
    }
}
