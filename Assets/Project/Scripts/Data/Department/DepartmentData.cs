using UnityEngine;

[CreateAssetMenu(
    fileName = "Department",
    menuName = "Parcel Inspector/Departments/Department")]
public class DepartmentData : ScriptableObject
{
    public DepartmentType Type;

    public string DepartmentName;

    [TextArea]
    public string Description;

    public Sprite Icon;

    public Color ThemeColor;

    public int UnlockDay;

    public int UnlockRank;

    public int BaseSalary;

    public RuleDatabase RuleDatabase;
}