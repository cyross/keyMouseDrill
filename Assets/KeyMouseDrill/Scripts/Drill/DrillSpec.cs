using UnityEngine;

namespace KeyMouDrill
{
    public class DrillSpec
    {
        public string Title { get; set; }
        public string GameName { get; set; }
        public string CaseName { get; set; }
        public int Version { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string Memo { get; set; }
        public DrillElement[] DrillElements { get; set; }
    }

    public class DrillElement
    {
        public KeyAction Action { get; set; }
        public string[] Keys { get; set; }
        public float Amount { get; set; }
    }
}
