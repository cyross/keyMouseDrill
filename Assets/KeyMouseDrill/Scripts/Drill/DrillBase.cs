using UnityEngine;

public class DrillBase: ScriptableObject
{
    public string title;
    public string gamename;
    public string casename;
    public int version;
    public System.DateTime createdDate;
    public System.DateTime updatedDate;
    public string memo;
    public DrillElement[] drillElements;
}

public class DrillElement: ScriptableObject
{
    public KeyAction action;
    public string[] keys;
    public float interval;
}