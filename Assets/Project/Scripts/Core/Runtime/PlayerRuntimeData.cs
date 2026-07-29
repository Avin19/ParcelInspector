using System;

namespace ParcelInspector.Core.Runtime
{
    [Serializable]
    public class PlayerRuntimeData
    {
        public string PlayerName = "Inspector";

        public int CurrentDay = 1;

        public DepartmentType CurrentDepartment = DepartmentType.Mailroom;

        public int CurrentRank = 1;



        public DateTime LastPlayed = DateTime.Now;
    }
}