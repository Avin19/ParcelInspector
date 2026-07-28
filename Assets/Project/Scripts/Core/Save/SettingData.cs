using System;

namespace ParcelInspector.Save
{
    [Serializable]
    public class SettingsData
    {
        public float MasterVolume = 1f;
        public float MusicVolume = 1f;
        public float SfxVolume = 1f;

        public bool Fullscreen = true;
        public bool VSync = true;

        public string Language = "English";
    }
}