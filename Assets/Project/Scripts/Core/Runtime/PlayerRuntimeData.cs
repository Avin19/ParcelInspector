using System;

namespace ParcelInspector.Core.Runtime
{
    [Serializable]
    public class PlayerRuntimeData
    {
        public string PlayerName = "Inspector";

        public int CurrentDay = 1;

        public int CurrentDepartment = 0;

        public int CurrentRank = 1;

        public DateTime CreatedDate = DateTime.Now;

        public DateTime LastPlayed = DateTime.Now;
    }
}