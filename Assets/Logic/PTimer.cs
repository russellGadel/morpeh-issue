using Scellecs.Morpeh;
using Scellecs.Morpeh.Providers;
using TMPro;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Logic
{
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class PTimer : MonoProvider<CTimer>
    {
        private TextMeshProUGUI text;

        protected override void Initialize()
        {
            text = gameObject.GetComponent<TextMeshProUGUI>();
        }

        private void Update()
        {
            if (World.Default == null)
                return;

            text.SetText($"Ecs time {GetData().Value}");
        }
    }
}