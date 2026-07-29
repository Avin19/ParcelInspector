using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Parcel Inspector/Database/News Database")]
public class NewsDatabase : ScriptableObject
{
    [SerializeField]
    private List<NewsData> news = new();

    public IReadOnlyList<NewsData> News => news;

    public List<NewsData> GetAvailableNews(int day)
    {
        List<NewsData> result = new();

        foreach (var item in news)
        {
            if (item.UnlockDay <= day)
                result.Add(item);
        }

        return result;
    }

    public NewsData GetById(int id)
    {
        return news.Find(n => n.Id == id);
    }
}