using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gm : MonoBehaviour
{
    bool gamehasended = false;
    public float restartdelay = 4f ;
    public GameObject Completegameui;
    public void completelevel()
    {
        Completegameui.SetActive(true);
    }
    public void GameOver ()
    
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("Game Over");
            Invoke("restart", restartdelay);

        }
        
    }
    void restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
