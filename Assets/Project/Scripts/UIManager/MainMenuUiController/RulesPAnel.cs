using UnityEngine;

public class RulesPanel : MonoBehaviour
{
    [SerializeField] Transform content;
    //[SerializeField] RuleItemUI prefab;

    public void Refresh()
    {
        foreach (var rule in GameManager.Instance.Runtime.Rules.ActiveRules)
        {
            // Create UI
        }
    }
}