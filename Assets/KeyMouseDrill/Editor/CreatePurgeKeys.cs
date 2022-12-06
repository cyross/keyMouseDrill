using System.Runtime.Versioning;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreatePurgeKeys : MonoBehaviour
{
    public static readonly string[] PURGE_KEYS = new string[] {
        "OEM1", "OEM2", "OEM3", "OEM4", "OEM5"
    };

    [MenuItem("キーリスト作成/除外キー", false, 1)]
    static void Create()
    {
        foreach (var purgeKeyName in PURGE_KEYS)
        {

            PurgeKey purgeKey = ScriptableObject.CreateInstance<PurgeKey>();
            purgeKey.DisplayName = purgeKeyName;
            purgeKey.KeyName = purgeKeyName;
            purgeKey.Id = purgeKeyName;
            purgeKey.Save();
        }
    }
}
