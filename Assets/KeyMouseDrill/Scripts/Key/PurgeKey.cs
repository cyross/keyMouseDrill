using System.Runtime.Versioning;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
#if UNITY_EDITOR
using UnityEditor;
#endif

/**
 * auto generated by PurgeKeys
 */
[CreateAssetMenu(menuName="ScriptableObject/PurgeKeys")]
public class PurgeKey : ScriptableObject
{
    public string DisplayName;
    public string KeyName;
    public string Id;

    private const string _RESOURCE_PATH = "Assets/KeyMouseDrill/Resources";

    private const string _PURGE_KEY_PATH = "PurgeKeys";

    public static PurgeKey Create()
    {
        return ScriptableObject.CreateInstance<PurgeKey>();
    }

    public static PurgeKey Load(string key)
    {
        return Resources.Load<PurgeKey>($"{_PURGE_KEY_PATH}/{key}");
    }

    public static PurgeKey[] LoadAll()
    {
        return Resources.LoadAll<PurgeKey>(_PURGE_KEY_PATH);
    }

    #if UNITY_EDITOR
    public void Save()
    {
        AssetDatabase.CreateAsset(this, $"{_RESOURCE_PATH}/{_PURGE_KEY_PATH}/{KeyName}.asset");
        EditorUtility.SetDirty(this);
    }
    #endif

    public static PurgeKey Instantiate(string key)
    {
        return Object.Instantiate<PurgeKey>(Load(key));
    }
}
