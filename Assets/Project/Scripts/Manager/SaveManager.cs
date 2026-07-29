using System.Collections;
using System.Collections.Generic;
using ParcelInspector.Core.Save;
using ParcelInspector.Core.Runtime;
using UnityEngine;

public class SaveManager : Singleton<SaveManager>
{
    /*
    Create a new save
    Load a save
    Save the current game
    Save settings
    Load settings
    Check if a save exists
    Delete a save
    Backup saves
    Handle save version upgrades\
    */
    private const string saveFile = "save.json";
    protected override void Awake()
    {
        base.Awake();
    }
    public bool HasSave()
    {
        // To DO 
        return false;
    }

    public void CreateNewGame()
    {
        // Reset Runtime 
        GameManager.Instance.InitializeNewGame();

        SaveGame();
    }

    public void SaveGame()
    {
        PlayerSaveData save = BuildSaveData();
        SaveSystem.Save(saveFile, save);
    }
    public void LoadGame()
    {
        PlayerSaveData save = SaveSystem.Load<PlayerSaveData>(saveFile);

        ApplySaveData(save);
    }
    public void DeleteSave()
    {
        SaveSystem.Delete(saveFile);
    }
    public void SaveSetting()
    {
        SaveSystem.Save("settings.json",
               GameManager.Instance.Runtime.Settings);
    }
    public void LoadSettings()
    {
        var settings =
            SaveSystem.Load<SettingsRuntimeData>("settings.json");

        if (settings != null)
            GameManager.Instance.Runtime.Settings = settings;
    }
    private PlayerSaveData BuildSaveData()
    {
        RuntimeData runtime = GameManager.Instance.Runtime;

        PlayerSaveData save = new();

        save.Player.CurrentDay = runtime.Player.CurrentDay;
        save.Player.PlayerName = runtime.Player.PlayerName;

        save.Economy.Coins = runtime.Economy.Coins;
        save.Economy.Salary = runtime.Economy.Salary;

        save.Progress.CurrentXP = runtime.Progress.CurrentXP;

        save.Settings.MasterVolume = runtime.Settings.MasterVolume;

        return save;
    }
    private void ApplySaveData(PlayerSaveData save)
    {
        RuntimeData runtime = GameManager.Instance.Runtime;

        runtime.Player.PlayerName = save.Player.PlayerName;
        runtime.Player.CurrentDay = save.Player.CurrentDay;

        runtime.Economy.Coins = save.Economy.Coins;
        runtime.Economy.Salary = save.Economy.Salary;

        runtime.Progress.CurrentXP = save.Progress.CurrentXP;

        runtime.Settings.MasterVolume = save.Settings.MasterVolume;
    }
}
