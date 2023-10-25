using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateSingleController : MonoBehaviour
{
    public GameObject newWorld;
    public Transform addNewBarLocation;
    public Text newWorldInfo;
    public Dropdown worldType;
    public InputField Input;
    void Start()
    {

    }

    void Update()
    {
        
    }

    void confirmWorldCreation()
    {
        int selectedIndex = worldType.value;
        string selectedOption = worldType.options[selectedIndex].text;
        newWorldInfo.text = Input.text + " - " + selectedOption;
    }
}
