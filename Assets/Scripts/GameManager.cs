using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject CompleteLevelUI;
   

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    
    public void completeLevel()
    {
        CompleteLevelUI.SetActive(true);
        Debug.Log("Level 01");
    }
 public void endGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("End Game");
            Invoke("restartGame", restartDelay);
        }
       
    }

     void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  
    
}
