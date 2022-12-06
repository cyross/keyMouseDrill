using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeyMouDrill
{
    public class DrillSample : MonoBehaviour
    {
        private KeyMapper[] _keyMaps;
        private PurgeKey[] _purgeKeys;

        private const string _DRILL_FILE_DIRECTORY = @"DrillYAML";

        private const string _SAMPLE_DRILL_FILE_PATH = _DRILL_FILE_DIRECTORY + @"/drill01";

        // Start is called before the first frame update
        void Start()
        {
            _keyMaps = KeyMapper.LoadAll();
            _purgeKeys = PurgeKey.LoadAll();
            foreach (KeyMapper k in _keyMaps)
            {
                Debug.Log(k.DisplayName);
            }
            //DrillBase drill = Yaml.LoadFromResources<DrillBase>(_SAMPLE_DRILL_FILE_PATH);
            //Debug.Log(drill.Title);
        }

        // Update is called once per frame
        void Update()
        {

        }

        bool isInclude(string keyName)
        {
            return false;
        }
    }
}
