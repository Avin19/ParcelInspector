using System;

namespace ParcelInspector.Save
{
    [Serializable]
    public class StatisticsData
    {
        public int PackagesInspected;
        public int CorrectInspections;
        public int IncorrectInspections;

        public int ApprovedPackages;
        public int RejectedPackages;

        public int PerfectShifts;
        public int FailedShifts;

        public float HighestAccuracy;

        public float TotalPlayTime;
    }
}