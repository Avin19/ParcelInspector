using UnityEngine;
public class MainMenuUIController : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private PlayerInfoPanel playerInfoPanel;
    [SerializeField] private ContinuePanel continuePanel;
    [SerializeField] private DailyObjectivePanel objectivePanel;
    [SerializeField] private RulesPanel rulesPanel;
    //[SerializeField] private NewsPanel newsPanel;

    // [Header("Buttons")]
    // [SerializeField] private MainMenuButtons buttons;

    private void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        playerInfoPanel.Refresh();
        // continuePanel.Refresh();
        // objectivePanel.Refresh();
        // rulesPanel.Refresh();
        // newsPanel.Refresh();
    }
}