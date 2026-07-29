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
        var progress = GameManager.Instance.Runtime.Progress;

        var economy = GameManager.Instance.Runtime.Economy;

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