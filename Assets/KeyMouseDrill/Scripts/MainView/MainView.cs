using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using TMPro;

public class MainView : MonoBehaviour
{
    [SerializeField]
    private GameObject licenseView;
    [SerializeField]
    private GameObject aboutView;
    [SerializeField]
    private TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        foreach (KeyControl keyControl in Keyboard.current.allKeys)
        {
            string optionValue = $"{keyControl.displayName} / {keyControl.name}";
            TMP_Dropdown.OptionData keyOption = new TMP_Dropdown.OptionData(optionValue);
            dropdown.options.Add(keyOption);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnclickShowLicenseViewButton()
    {
        licenseView.SetActive(true);
    }

    public void OnClickShowAboutViewButton()
    {
        aboutView.SetActive(true);
    }
}
