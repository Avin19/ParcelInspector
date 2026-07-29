using System.Collections.Generic;

namespace ParcelInspector.Core.Runtime
{
    [System.Serializable]
    public class RuleRuntimeData
    {
        public List<RuleData> ActiveRules = new();

        public int DifficultyLevel;

        public bool IsRandomized;
    }
}