using System.IO;
using UnityEngine;

namespace ParcelInspector.Core.Save
{
    public static class SaveSystem
    {
        private static readonly string SaveDirectory =
            Application.persistentDataPath;

        public static void Save<T>(string fileName, T data)
        {
            string path = Path.Combine(SaveDirectory, fileName);

            string json = JsonUtility.ToJson(data, true);

            File.WriteAllText(path, json);
        }

        public static T Load<T>(string fileName)
        {
            string path = Path.Combine(SaveDirectory, fileName);

            if (!File.Exists(path))
                return default;

            string json = File.ReadAllText(path);

            return JsonUtility.FromJson<T>(json);
        }

        public static bool Exists(string fileName)
        {
            return File.Exists(Path.Combine(SaveDirectory, fileName));
        }

        public static void Delete(string fileName)
        {
            string path = Path.Combine(SaveDirectory, fileName);

            if (File.Exists(path))
                File.Delete(path);
        }
    }
}