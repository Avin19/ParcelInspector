using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewsPanel : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TMP_Text title;
    [SerializeField] private TMP_Text description;

    private void OnEnable()
    {
        NewsManager.Instance.OnNewsChanged += OnNewsChanged;
    }

    private void OnDisable()
    {
        NewsManager.Instance.OnNewsChanged -= OnNewsChanged;
    }
    private void OnNewsChanged(NewsData news)
    {
        Refresh();
    }
    public void Refresh()
    {
        NewsData news = NewsManager.Instance.CurrentNews;

        if (news == null)
            return;

        // image.sprite = news.Image;
        title.text = news.Title;
        description.text = news.Description;
    }

    public void Next()
    {
        NewsManager.Instance.NextNews();
    }

    public void Previous()
    {
        NewsManager.Instance.PreviousNews();
    }
}