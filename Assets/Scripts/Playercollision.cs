
using UnityEngine;

public class Playercollision : MonoBehaviour
{
    public playermovement movement;
    
    
    
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gm>().GameOver();
              

        }
        
    }


   
}
