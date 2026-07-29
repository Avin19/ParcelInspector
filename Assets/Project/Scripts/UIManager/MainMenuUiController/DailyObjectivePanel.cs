using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DailyObjectivePanel : MonoBehaviour
{
    [SerializeField] TMP_Text description;
    [SerializeField] Slider progress;

    public void Refresh()
    {
        // var objective =ObjectiveManager.Instance.CurrentObjective;

        //description.text = objective.Description;

        //progress.value = objective.Progress;
    }
}