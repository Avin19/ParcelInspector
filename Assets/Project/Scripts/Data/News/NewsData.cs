using UnityEngine;


[CreateAssetMenu(
    fileName = "News",
    menuName = "Parcel Inspector/News/News")]
public class NewsData : ScriptableObject
{
    [Header("Identity")]
    public int Id;
    public string Title;

    [TextArea(4, 10)]
    public string Description;

    public Sprite Thumbnail;

    [Header("Classification")]
    public NewsType Type;
    public NewsPriority Priority;

    [Header("Availability")]
    public int UnlockDay = 1;
    public int MinimumRank = 1;
    public DepartmentType Department = DepartmentType.None;

    [Header("Story")]
    public bool StoryNews;
    public bool BreakingNews;
    public bool OneTimeOnly;
    public bool ShowPopup;

    [Header("Requirements")]
    public string RequiredStoryFlag;
    public RuleCategory RequiredRule = RuleCategory.Barcode;

    [Header("Gameplay Effects")]
    public bool UnlockRule;
    public RuleData RuleToUnlock;

    public bool UnlockDepartment;
    public DepartmentData DepartmentToUnlock;

    public int RewardXP;
    public int RewardCoins;

    [Header("Presentation")]
    public AudioClip NewsSound;
    public Color HeadlineColor = Color.white;
}
