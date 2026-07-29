using System.Collections.Generic;
using UnityEngine;

public class RulesPanel : MonoBehaviour
{
    [SerializeField] private Transform content;
    [SerializeField] private RuleItemUI rulePrefab;

    private readonly List<RuleItemUI> items = new();

    public void Refresh()
    {
        Clear();

        Debug.Log($"Rule Count: {GameManager.Instance.Rules.ActiveRules.Count}");

        foreach (RuleData rule in GameManager.Instance.Rules.ActiveRules)
        {
            Debug.Log($"Creating {rule.RuleName}");

            RuleItemUI item = Instantiate(rulePrefab, content);

            item.Initialize(rule);

            items.Add(item);
        }
    }

    private void Clear()
    {
        foreach (var item in items)
            Destroy(item.gameObject);

        items.Clear();
    }
}