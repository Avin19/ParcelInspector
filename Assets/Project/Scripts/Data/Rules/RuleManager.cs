using System.Collections.Generic;
using UnityEngine;

namespace ParcelInspector.Gameplay.Rules
{
    public class RuleManager : Singleton<RuleManager>
    {
        [SerializeField]
        private RuleDatabase database;

        public void GenerateRules()
        {
            var runtime = GameManager.Instance.Runtime.Rules;

            runtime.ActiveRules.Clear();

            List<RuleData> unlocked =
                database.GetUnlockedRules(GameManager.Instance.Runtime.Player.CurrentDay);

            runtime.ActiveRules.AddRange(unlocked);
        }
    }
}