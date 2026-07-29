using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(
    fileName = "SceneDatabase",
    menuName = "Parcel Inspector/Database/Scene Database")]
public class SceneDatabase : ScriptableObject
{
    public List<SceneData> Scenes;

    public SceneData Get(SceneType type)
    {
        return Scenes.Find(s => s.SceneType == type);
    }
}
