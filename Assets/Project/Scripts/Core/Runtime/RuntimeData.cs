using System;

namespace ParcelInspector.Core.Runtime
{
    [Serializable]
    public class RuntimeData
    {
        public PlayerRuntimeData Player = new();
        public EconomyRuntimeData Economy = new();
        public ProgressRuntimeData Progress = new();
        public ShiftRuntimeData Shift = new();
        public RuleRuntimeData Rules = new();
        public StoryRuntimeData Story = new();
        public StatisticsRuntimeData Statistics = new();
        public InventoryRuntimeData Inventory = new();
        public AchievementRuntimeData Achievements = new();
        public SettingsRuntimeData Settings = new();
    }
}