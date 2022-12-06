using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using TMPro;

namespace KeyMouDrill
{
    public class MainView : MonoBehaviour
    {
        [SerializeField]
        private GameObject _licenseView;
        [SerializeField]
        private GameObject _aboutView;
        [SerializeField]
        private TMP_Dropdown _dropDown;

        // Start is called before the first frame update
        void Start()
        {
            foreach (KeyControl keyControl in Keyboard.current.allKeys)
            {
                string optionValue = $"{keyControl.displayName} / {keyControl.name}";
                TMP_Dropdown.OptionData keyOption = new TMP_Dropdown.OptionData(optionValue);
                _dropDown.options.Add(keyOption);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnclickShow_licenseViewButton()
        {
            _licenseView.SetActive(true);
        }

        public void OnClickShow_aboutViewButton()
        {
            _aboutView.SetActive(true);
        }
    }
}
