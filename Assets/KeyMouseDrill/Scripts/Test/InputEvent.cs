using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class InputEvent : MonoBehaviour
{
    [SerializeField]
    private TMP_Text logLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current != null)
        {
            string[] keyNames = Keyboard.current.allKeys.Where(x => x.isPressed).Select(x => x.name).ToArray();
            logLabel.text = $"[{string.Join(",", keyNames)}]";
        }
    }

    public void OnMouseWheel(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            InputControl control = context.control;
            logLabel.text = control.name;
        }
    }

    public void OnKeyboard(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            InputControl control = context.control;
        }
    }
}
