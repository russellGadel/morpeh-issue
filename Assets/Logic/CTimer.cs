using Scellecs.Morpeh;
using Unity.IL2CPP.CompilerServices;

namespace Logic
{
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    public struct CTimer : IComponent
    {
        public float Value;
    }
}