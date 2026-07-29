using UnityEngine;


[CreateAssetMenu(
    fileName = "Scene",
    menuName = "Parcel Inspector/Scene")]
public class SceneData : ScriptableObject
{
    public SceneType SceneType;

    // Optional if using NaughtyAttributes/Odin
    public string SceneName;

    public GameState GameState;
}
