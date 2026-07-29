using UnityEngine;


[CreateAssetMenu(fileName = "Rule", menuName = "Parcel Inspector/Rules/Rule")]
public class RuleData : ScriptableObject
{
    public int Id;

    public string RuleName;

    [TextArea]
    public string Description;

    public Sprite Icon;

    public RuleCategory Category;

    public int UnlockDay;

    public bool IsMandatory;
}
