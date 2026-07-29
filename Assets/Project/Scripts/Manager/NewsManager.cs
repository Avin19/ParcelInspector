using System;
using System.Collections.Generic;
using UnityEngine;


public class NewsManager : Singleton<NewsManager>
{
    public event Action<NewsData> OnNewsChanged;

    [SerializeField]
    private NewsDatabase database;

    private readonly List<NewsData> availableNews = new();

    private int currentIndex = -1;

    public NewsData CurrentNews =>
        currentIndex >= 0 && currentIndex < availableNews.Count
            ? availableNews[currentIndex]
            : null;

    public IReadOnlyList<NewsData> AvailableNews => availableNews;

    public void Initialize()
    {
        RefreshNews();
    }

    public void RefreshNews()
    {
        availableNews.Clear();

        int currentDay = GameManager.Instance.Runtime.Player.CurrentDay;

        foreach (var news in database.News)
        {
            if (news.UnlockDay <= currentDay)
                availableNews.Add(news);
        }

        currentIndex = availableNews.Count > 0 ? 0 : -1;

        Notify();
    }

    public void NextNews()
    {
        if (availableNews.Count == 0)
            return;

        currentIndex++;

        if (currentIndex >= availableNews.Count)
            currentIndex = 0;

        Notify();
    }

    public void PreviousNews()
    {
        if (availableNews.Count == 0)
            return;

        currentIndex--;

        if (currentIndex < 0)
            currentIndex = availableNews.Count - 1;

        Notify();
    }

    private void Notify()
    {
        OnNewsChanged?.Invoke(CurrentNews);
    }
}
