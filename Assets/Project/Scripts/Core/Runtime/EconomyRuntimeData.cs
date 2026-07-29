using System;

namespace ParcelInspector.Core.Runtime
{
    [Serializable]
    public class EconomyRuntimeData
    {
        public int Salary;
        public int Coins;

        public int ShiftSalary;

        public int ShiftBonus;

        public int TotalSalaryEarned;

        public int TotalCoinsEarned;
    }
}