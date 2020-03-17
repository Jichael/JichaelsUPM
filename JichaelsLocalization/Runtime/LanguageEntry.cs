using System.Collections;
using Jichaels.Core;
using TMPro;
using UnityEngine;

namespace Jichaels.Localization
{

    [RequireComponent(typeof(TMP_Text))]
    public class LanguageEntry : MonoBehaviour
    {

        [SerializeField] private string languageEntry;

        [SerializeField] private TMP_Text text;

        private bool _added;

        private void Awake()
        {
            if (LanguageManager.Instance == null || !LanguageManager.Instance.IsReady)
            {
                StartCoroutine(DelayCo());
            }
            else
            {
                SetValue();
                AddEntry();
            }
        }

        private IEnumerator DelayCo()
        {
            while (LanguageManager.Instance == null)
            {
                yield return Yielders.EndOfFrame;
            }

            AddEntry();

            while (!LanguageManager.Instance.IsReady)
            {
                yield return Yielders.EndOfFrame;
            }

            SetValue();

        }

        private void OnDestroy()
        {
            RemoveEntry();
        }


        private void AddEntry()
        {
            LanguageManager.Instance.AddEntry(this);
            _added = true;
        }

        private void RemoveEntry()
        {
            if(_added) LanguageManager.Instance.RemoveEntry(this);
        }

        public void SetValue()
        {
            text.text = LanguageManager.Instance.RequestValue(languageEntry);
        }

        private void OnValidate()
        {
            if (text == null)
            {
                text = GetComponent<TMP_Text>();
            }
        }
    }
    
}