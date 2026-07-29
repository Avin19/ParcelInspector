using System;

namespace ParcelInspector.Core.Runtime
{
    [Serializable]
    public class ShiftRuntimeData
    {
        public int PackagesInspected;

        public int CorrectPackages;

        public int IncorrectPackages;

        public int PackagesRemaining;

        public int Combo;

        public float Accuracy;

        public float ShiftTime;

        public bool ShiftCompleted;
    }
}