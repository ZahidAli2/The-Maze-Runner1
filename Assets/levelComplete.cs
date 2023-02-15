using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
    public void loadNextLevel()
    {
        SceneManager.LoadScene(1);
    }
}
