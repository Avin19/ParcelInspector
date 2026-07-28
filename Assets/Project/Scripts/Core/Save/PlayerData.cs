using System;

namespace ParcelInspector.Save
{
    [Serializable]
    public class PlayerData
    {
        public string PlayerName = "Inspector";
        public int CurrentDay = 1;
        public string CurrentDepartment = "Receiving Dock";

        public DateTime CreatedDate;
        public DateTime LastPlayed;
    }
}