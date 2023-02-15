using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Credits;
    public void creditsBtnPressed()
    {
        MainMenu.SetActive(false);
        Credits.SetActive(true);
    }
    public void backBtnPrssed()
    {
        MainMenu.SetActive(true);
        Credits.SetActive(false);
    }
    public void quit()
    {
        Application.Quit();
    }

}
