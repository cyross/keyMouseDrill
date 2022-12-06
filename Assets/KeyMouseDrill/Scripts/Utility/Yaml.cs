using System.IO;

using UnityEngine;

using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace KeyMouDrill
{
    public class Yaml
    {
        // YAMLファイルはUTF-8を想定

        public static T Load<T>(string filePath)
        {
            string yamlBody = File.ReadAllText(filePath);
            string yamlText = Utils.ConvertToUTF8(yamlBody);

            return DeserializeYamlString<T>(yamlText);
        }

        public static T LoadFromResources<T>(string filePath)
        {
            TextAsset yamlBody = Resources.Load<TextAsset>(filePath);
            string yamlText = Utils.ConvertToUTF8FromBytes(yamlBody.bytes);

            return DeserializeYamlString<T>(yamlText);
        }

        private static T DeserializeYamlString<T>(string yamlString)
        {
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(UnderscoredNamingConvention.Instance)
                .Build();

            return deserializer.Deserialize<T>(yamlString);
        }
    }
}
