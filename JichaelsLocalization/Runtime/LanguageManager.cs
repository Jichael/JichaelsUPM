using System.Collections.Generic;
using Jichaels.Core;
using Newtonsoft.Json;
using UnityEngine;

namespace Jichaels.Localization
{

    public class LanguageManager : MonoBehaviour
    {

        public static LanguageManager Instance { get; private set; }
        
        public string CurrentLanguage { get; private set; }
        public bool IsReady { get; private set; }

        private Dictionary<string, string> _languageData;

        private readonly HashSet<LanguageEntry> _entries = new HashSet<LanguageEntry>();

        [SerializeField] private string initialLanguage;
        

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            GetLanguageData(initialLanguage);
        }

        private void GetLanguageData(string newLanguage)
        {
            IsReady = false;
            CurrentLanguage = newLanguage;
            string json = IOManager.Instance.GetLanguageData(CurrentLanguage);
            
            if (json == null) return; // Error already handled in IOManager
            
            _languageData = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            IsReady = true;
        }

        public string RequestValue(string key)
        {
            _languageData.TryGetValue(key, out string value);

            if (value != null) return value;

            Debug.LogError($"RequestValue - Entry '{key}' not found in language file !", this);
            return string.Empty;
        }

        public void ChangeLanguage(string newLanguage)
        {
            if (string.Equals(CurrentLanguage, newLanguage)) return;
            
            GetLanguageData(newLanguage);

            foreach (var entry in _entries)
            {
                entry.SetValue();
            }
        }

        public void AddEntry(LanguageEntry entry)
        {
            _entries.Add(entry);
        }

        public void RemoveEntry(LanguageEntry entry)
        {
            _entries.Remove(entry);
        }

    }
}