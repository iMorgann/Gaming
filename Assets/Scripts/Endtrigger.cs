using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public gm GameManager;
    void OnTriggerEnter ()
    {
        GameManager.completelevel();
    }
        
    
}
