using System;
using System.Collections.Generic;
namespace ParcelInspector.Core.Runtime
{
    [Serializable]
    public class NewsRuntimeData
    {
        public List<NewsData> CurrentNews = new();

        public int CurrentIndex = 0;
    }
}