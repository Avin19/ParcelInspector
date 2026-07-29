using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class PlayerInfoPanel : MonoBehaviour
{
    [SerializeField] TMP_Text rankText;
    [SerializeField] TMP_Text xpText;
    [SerializeField] TMP_Text salaryText;
    [SerializeField] TMP_Text coinText;
    [SerializeField] Image xpBar;

    public void Refresh()
    {
        // Debug.Log($"GameManager: {GameManager.Instance}");
        // Debug.Log($"Runtime: {GameManager.Instance?.Runtime}");
        // Debug.Log($"Player: {GameManager.Instance?.Runtime?.Player}");
        // Debug.Log($"PlayerName Text: {GameManager.Instance.Player.PlayerName}");

        if (GameManager.Instance?.Runtime?.Player == null)
            return;

        // playerName.text = GameManager.Instance.Player.PlayerName;
        var progress = GameManager.Instance.Progress;

        var economy = GameManager.Instance.Economy;

        rankText.text = $"Rank {progress.CurrentRank}";

        xpText.text =
            $"{progress.CurrentXP}/{progress.NextRankXP} XP";

        xpBar.fillAmount =
            progress.XPPercentage;

        salaryText.text =
            economy.Salary.ToString();

        coinText.text =
            economy.Coins.ToString();

    }
}