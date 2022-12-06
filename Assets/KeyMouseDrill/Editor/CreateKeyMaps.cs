using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEditor;

public class CreateKeyMaps : MonoBehaviour
{
    private static readonly string[] _SYMBOL_KEYS = new string[]{
        "quote", "semicolon", "comma", "period", "slash", "backslash", "leftBracket", "rightBracket", "minus", "equals"
    };

    private static readonly string[] _NUM_PAD_KEYS = new string[]{
        "numpadEnter", "numpadDivide", "numpadMultiply", "numpadPlus", "numpadMinus", "numpadPeriod", "numpadEquals",
        "numpad0", "numpad1", "numpad2", "numpad3", "numpad4", "numpad5", "numpad6", "numpad7", "numpad8", "numpad9"
    };

    private static readonly string[] _FUNCTION_KEYS = new string[]{
        "f1", "f2", "f3", "f4", "f5", "f6", "f7", "f8", "f9", "f10", "f11", "f12"
    };

    private static readonly string[] _META_KEYS = new string[]{
        "leftShift", "rightShift", "leftAlt", "rightAlt", "leftCtrl", "rightCtrl", "leftMeta", "rightMeta", "contextMenu",
        "escape", "leftArrow", "rightArrow", "upArrow", "downArrow" 
    };

    private static readonly string[] _SYSTEM_KEYS = new string[]{
        "space", "enter", "tab", "backquote", "backSpace", "pageDown", "pageUp", "home", "end", "insert", "delete",
        "capsLock", "numLock", "printScreen", "scrollLock", "pause"
    };

    private static readonly Dictionary<string, string> _SPECIAL_DISPLAY_NAME = new Dictionary<string, string>{
        {"numpadEnter", "(ENTER)"},
        {"numpadDivide", "(/)"},
        {"numpadMultiply", "(*)"},
        {"numpadPlus", "(+)"},
        {"numpadMinus", "(-)"},
        {"numpadPeriod", "(.)"},
        {"numpadEquals", "(=)"},
        {"numpad0", "(0)"},
        {"numpad1", "(1)"},
        {"numpad2", "(2)"},
        {"numpad3", "(3)"},
        {"numpad4", "(4)"},
        {"numpad5", "(5)"},
        {"numpad6", "(6)"},
        {"numpad7", "(7)"},
        {"numpad8", "(8)"},
        {"numpad9", "(9)"},
        {"leftShift", "<左シフト>"},
        {"rightShift", "<右シフト>"},
        {"leftCtrl", "<左コントロール>"},
        {"rightCtrl", "<右コントロール>"},
        {"leftAlt", "<左Alt>"},
        {"rightAlt", "<右Alt>"},
        {"leftMeta", "<左Meta>"},
        {"rightMeta", "<右Meta>"},
        {"contextMenu", "<コンテキストメニュー>"},
        {"space", "[SPACE]"},
        {"enter", "[ENTER]"},
        {"escape", "[ESC]"},
        {"leftArrow", "[←]"},
        {"rightArrow", "[→]"},
        {"upArrow", "[↑]"},
        {"downArrow", "[↓]"},
        {"backquote", "[全角／半角]"},
        {"backspace", "[BS]"},
        {"pageDown", "[PAGE DOWN]"},
        {"pageUp", "[PAGE UP]"},
        {"home", "[HOME]"},
        {"end", "[END]"},
        {"insert", "[INS]"},
        {"delete", "[DEL]"},
        {"capsLock", "[CAPS]"},
        {"numLock", "[NUM LOCK]"},
        {"printScreen", "[PRINT SCREEN]"},
        {"scrollLock", "[SCROLL LOCK]"},
        {"pause", "[PAUSE]"}
    };

    [MenuItem("キーリスト作成/キーマップ", false, 1)]
    static void Create()
    {
        foreach (KeyControl keyControl in Keyboard.current.allKeys)
        {
            if (Array.IndexOf(CreatePurgeKeys.PURGE_KEYS, keyControl.name) != -1)
            {
                continue;
            }
            KeyMapper keyMap = ScriptableObject.CreateInstance<KeyMapper>();
            keyMap.KeyName = keyControl.name;
            keyMap.DisplayName = GetDisplayName(keyControl);
            keyMap.KeyType = GetKeyType(keyControl.name);
            // Debug.Log($"{keyMap.Value} / {keyMap.KeyName} / {keyMap.KeyType}");
            keyMap.Save();
        }
    }

    static KeyMouDrill.KeyType GetKeyType(string keyName)
    {
        if (Array.IndexOf(_SYMBOL_KEYS, keyName) != -1)
        {
            return KeyMouDrill.KeyType.Symbol;
        }
        
        if (Array.IndexOf(_NUM_PAD_KEYS, keyName) != -1)
        {
            return KeyMouDrill.KeyType.NumPad;
        }

        if (Array.IndexOf(_FUNCTION_KEYS, keyName) != -1)
        {
            return KeyMouDrill.KeyType.Function;
        }

        if (Array.IndexOf(_META_KEYS, keyName) != -1)
        {
            return KeyMouDrill.KeyType.Meta;
        }

        if (Array.IndexOf(_SYSTEM_KEYS, keyName) != -1)
        {
            return KeyMouDrill.KeyType.System;
        }

        return KeyMouDrill.KeyType.AlphaNum;
    }

    static string GetDisplayName(KeyControl keyControl)
    {
        if (_SPECIAL_DISPLAY_NAME.ContainsKey(keyControl.name))
        {
            return _SPECIAL_DISPLAY_NAME[keyControl.name];
        }
        
        return keyControl.displayName;
    }
}
