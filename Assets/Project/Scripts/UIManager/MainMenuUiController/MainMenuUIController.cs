using UnityEngine;
public class MainMenuUIController : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private PlayerInfoPanel playerInfoPanel;
    [SerializeField] private ContinuePanel continuePanel;
    [SerializeField] private DailyObjectivePanel objectivePanel;
    [SerializeField] private RulesPanel rulesPanel;
    [SerializeField] private NewsPanel newsPanel;

    [Header("Buttons")]
    [SerializeField] private MainMenuButtons buttons;

    private void Start()
    {

        // Load saved runtime if one exists
        SaveManager.Instance.LoadOrCreateGame();

        // Initialize systems using the final runtime
        RuleManager.Instance.Initialize();
        // ObjectiveManager.Instance.Initialize();
        NewsManager.Instance.Initialize();
        Refresh();
    }

    public void Refresh()
    {
        playerInfoPanel.Refresh();
        continuePanel.Refresh();
        objectivePanel.Refresh();
        rulesPanel.Refresh();
        newsPanel.Refresh();
    }
}