using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RuleItemUI : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TMP_Text ruleName;
    [SerializeField] private Image completedIcon;

    public void Initialize(RuleData rule)
    {
        icon.sprite = rule.Icon;
        ruleName.text = rule.RuleName;

        completedIcon.enabled = true;
    }
}