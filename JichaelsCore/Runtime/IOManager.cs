using System.IO;
using UnityEngine;

namespace Jichaels.Core
{

    public class IOManager : MonoBehaviour
    {

        public static IOManager Instance { get; private set; }

        public string languageFolderName = "Languages";

        private void Awake()
        {
            Instance = this;
        }

        public string GetLanguageData(string language)
        {
            string filePath = CombinePath(languageFolderName, language, "json");
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return json;
            }

            Debug.LogError($"GetLanguageData - Could not load lang file : '{filePath}' doesn't exist !", this);
            return null;
        }

        public static string CombinePath(string path, string fileName, string extension)
        {
            string filePath = Path.Combine(StreamingAssetsPath(path), $"{fileName}.{extension}");
            return filePath;
        }

        public static string StreamingAssetsPath(string path)
        {
            return Path.Combine(Application.streamingAssetsPath, $"{path}");
        }

    }
}