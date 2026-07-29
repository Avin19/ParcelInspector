using System;
using System.Collections.Generic;
using UnityEngine;


public class RuleManager : Singleton<RuleManager>
{
    [SerializeField]
    private RuleDatabase database;

    public event Action OnRulesChanged;

    public IReadOnlyList<RuleData> ActiveRules =>
        GameManager.Instance.Rules.ActiveRules;

    public void Initialize()
    {
        Debug.Log("RuleMAnager Initialized");
        GenerateRules();
    }

    public void GenerateRules()
    {
        var runtime = GameManager.Instance.Rules;

        runtime.ActiveRules.Clear();

        List<RuleData> unlocked =
            database.GetUnlockedRules(
                GameManager.Instance.Player.CurrentDay);

        runtime.ActiveRules.AddRange(unlocked);

        OnRulesChanged?.Invoke();
    }

    public void RefreshRules()
    {
        GenerateRules();
    }
}
