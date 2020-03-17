#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;

namespace Jichaels.VRSDK
{
    [CreateAssetMenu(menuName = "FadeEffect")]
    public class FadeEffectSO : ScriptableObject
    {
        public bool fadeInAndOut;

        public float durationAB;
        
#if ODIN_INSPECTOR
        [ShowIf("fadeInAndOut")]
#endif
        public float durationBC;

        public float delayStart;
        
#if ODIN_INSPECTOR
        [ShowIf("fadeInAndOut")] 
#endif
        public float delayAfterB;


        public float delayEnd;

        public Color colorA;
        public Color colorB;
        
#if ODIN_INSPECTOR
        [ShowIf("fadeInAndOut")] 
#endif
        public Color colorC;
    }
}