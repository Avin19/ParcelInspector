using System;

namespace ParcelInspector.Save
{
    [Serializable]
    public class EconomyData
    {
        public int Salary;
        public int Coins;

        public int TotalSalaryEarned;
        public int TotalCoinsEarned;
    }
}