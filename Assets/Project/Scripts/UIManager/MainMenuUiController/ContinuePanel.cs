using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ContinuePanel : MonoBehaviour
{
    [SerializeField] TMP_Text dayText;
    [SerializeField] TMP_Text departmentText;
    [SerializeField] Button continueButton;

    public void Refresh()
    {
        bool hasSave = SaveManager.Instance.HasSave();

        continueButton.interactable = hasSave;

        if (!hasSave)
            return;

        var player = GameManager.Instance.Runtime.Player;

        dayText.text = $"DAY {player.CurrentDay}";
        // departmentText.text = player.DepartmentName;
    }
}