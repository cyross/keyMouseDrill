using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace KeyMouDrill
{
    public class DrillSample : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _yamlResult;

        private KeyMapper[] _keyMaps;
        private PurgeKey[] _purgeKeys;

        private const string _DRILL_FILE_DIRECTORY = @"DrillYAML";

        private const string _SAMPLE_DRILL_FILE_PATH = _DRILL_FILE_DIRECTORY + @"/drill01";

        // Start is called before the first frame update
        void Start()
        {
            _keyMaps = KeyMapper.LoadAll();
            _purgeKeys = PurgeKey.LoadAll();
#if false
            foreach (KeyMapper k in _keyMaps)
            {
                Debug.Log(k.DisplayName);
            }
#endif
            DrillSpec drill = Yaml.LoadFromResources<DrillSpec>(_SAMPLE_DRILL_FILE_PATH);
            _yamlResult.text = $"タイトル：{drill.Title} アクション：{drill.DrillElements[0].Action}";
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
