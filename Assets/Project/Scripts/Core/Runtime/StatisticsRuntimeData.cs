using System;

namespace ParcelInspector.Core.Runtime
{
    [Serializable]
    public class StatisticsRuntimeData
    {
        public int TotalPackagesInspected;

        public int TotalCorrectInspections;

        public int TotalIncorrectInspections;

        public int PerfectShifts;

        public int FailedShifts;

        public float HighestAccuracy;

        public float TotalPlayTime;
    }
}