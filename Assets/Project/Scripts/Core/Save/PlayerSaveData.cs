using System;

namespace ParcelInspector.Core.Save
{
    [Serializable]
    public class PlayerSaveData
    {
        public int SaveVersion = 1;

        public PlayerData Player = new();
        public EconomyData Economy = new();
        public ProgressData Progress = new();
        public StatisticsData Statistics = new();
        public SettingsData Settings = new();
    }
}