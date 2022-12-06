using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

using TMPro;

using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

// System.Windows.Forms.dllをUnity上のフォルダーからAssetsフォルダにコピーすることを忘れずに！
using System.Windows.Forms;
using System.Runtime.CompilerServices;

public class YamlFileGUI : MonoBehaviour
{
    private const string OPEN_FILE_DIALOG_TITLE = @"YAMLファイルを選んでください";
    private const string YAML_FILE_FILTER = @"YAML file|*.yml;*.yaml";

    [SerializeField]
    private TMP_Text yaml_result;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickOpenYamlFileDialog()
    {
        using (var openYamlFileDialog = new OpenFileDialog())
        {
            openYamlFileDialog.Title = OPEN_FILE_DIALOG_TITLE;
            openYamlFileDialog.Filter = YAML_FILE_FILTER;

            if( openYamlFileDialog.ShowDialog() == DialogResult.OK )
            {
                string filePath = openYamlFileDialog.FileName;
                string scenario_str = File.ReadAllText(filePath);

                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(UnderscoredNamingConvention.Instance)
                    .Build();
                TestScenario scenario = deserializer.Deserialize<TestScenario>(scenario_str);
                byte[] bytesUTF8 = System.Text.Encoding.Default.GetBytes(scenario.name);
                yaml_result.text = System.Text.Encoding.UTF8.GetString(bytesUTF8);
            }
        }
    }
}
