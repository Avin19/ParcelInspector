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
        foreach (RuleData rule in GameManager.Instance.Rules.ActiveRules)
        {
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