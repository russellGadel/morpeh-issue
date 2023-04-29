using TMPro;
using UnityEngine;

namespace Logic
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class RealTime : MonoBehaviour
    {
        public float seconds;
        private TextMeshProUGUI text;

        void Awake()
        {
            text = GetComponent<TextMeshProUGUI>();
        }

        void Update()
        {
            text.SetText($" Real : {seconds += Time.deltaTime}");
        }
    }
}