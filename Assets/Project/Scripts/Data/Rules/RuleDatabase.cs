using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "RuleDatabase",
                 menuName = "Parcel Inspector/Database/Rule Database")]
public class RuleDatabase : ScriptableObject
{
    [SerializeField]
    private List<RuleData> rules = new();

    public IReadOnlyList<RuleData> Rules => rules;

    public RuleData GetRule(int id)
    {
        return rules.Find(r => r.Id == id);
    }

    public List<RuleData> GetUnlockedRules(int currentDay)
    {
        List<RuleData> unlocked = new();

        foreach (RuleData rule in rules)
        {
            if (rule.UnlockDay <= currentDay)
                unlocked.Add(rule);
        }

        return unlocked;
    }
}
