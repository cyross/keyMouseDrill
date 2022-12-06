using UnityEngine;

namespace KeyMouDrill
{
    public class DrillBase
    {
        public string Title;
        public string GameName;
        public string CaseName;
        public int Version;
        public System.DateTime CreatedDate;
        public System.DateTime UpdatedDate;
        public string Memo;
        public DrillElement[] DrillElements;
    }

    public class DrillElement
    {
        public KeyAction Action;
        public string[] Keys;
        public float Amount;
    }
}
