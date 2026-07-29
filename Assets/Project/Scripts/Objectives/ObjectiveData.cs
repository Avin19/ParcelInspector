using UnityEngine;

[CreateAssetMenu(menuName = "Parcel Inspector/Objective")]
public class ObjectiveData : ScriptableObject
{
    public string Id;

    public string Title;

    public string Description;

    public ObjectiveType Type;

    public int TargetValue;

    public int RewardXP;

    public int RewardCoins;
}