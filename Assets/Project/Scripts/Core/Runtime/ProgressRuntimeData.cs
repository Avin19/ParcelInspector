using System.Collections.Generic;

namespace ParcelInspector.Core.Runtime
{
    [System.Serializable]

    public class ProgressRuntimeData
    {
        public int CurrentRank = 1;

        public int CurrentXP = 0;

        public int TotalXP = 0;

        public int NextRankXP = 1000;

        public float XPPercentage =>
            NextRankXP <= 0 ? 0f : (float)CurrentXP / NextRankXP;

        public List<int> UnlockedRules = new();

        public List<int> UnlockedDepartments = new();

        public List<int> CompletedStoryEvents = new();
    }
}