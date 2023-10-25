using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject credits;
    public GameObject skinButtons;
    public static string playerName;
    public Text editSkinText;
    private bool editSkinMode = false;
    
    /**
     * TASKS:
     * When you click the edit skin button, change the button's text to say confirm skin and allow the arrows to appear.
     * When pressing confirm skin, disable the buttons and revert the text back.
     * 
     * 
     * **/
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && credits.activeInHierarchy)
        {
            credits.SetActive(false);
        }
    }

    public void EnterSingleplayer()
    {
        SceneManager.LoadScene(1);
    }

    public void EnterMultiplayer()
    {
        SceneManager.LoadScene(3);
    }

    public void EnterOptions()
    {
        SceneManager.LoadScene(4);
    }

    public void EnterCredits()
    {
        credits.SetActive(true);
    }

    public void EditSkin()
    {
        if (!editSkinMode)
        {
            skinButtons.SetActive(true);
            editSkinText.text = "Confirm Skin";
            editSkinMode = true;
        }
        else
        {
            skinButtons.SetActive(false);
            editSkinText.text = "Edit Skin";
            editSkinMode = false;
        }
    }
}
