using System;

namespace ParcelInspector.Core.Runtime
{
    [Serializable]
    public class StoryRuntimeData
    {
        public int CurrentChapter;

        public int CurrentEvent;

        public bool InvestigationUnlocked;
    }
}