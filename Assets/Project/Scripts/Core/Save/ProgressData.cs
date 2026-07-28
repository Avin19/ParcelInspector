using System;
using System.Collections.Generic;

namespace ParcelInspector.Save
{
    [Serializable]
    public class ProgressData
    {
        public int CurrentXP;
        public int TotalXP;

        public int CurrentRank = 1;

        public List<int> UnlockedRules = new();
        public List<int> UnlockedDepartments = new();
        public List<int> CompletedStoryEvents = new();
    }
}