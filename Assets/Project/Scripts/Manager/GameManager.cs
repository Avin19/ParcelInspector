using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ParcelInspector.Core.Runtime;


public class GameManager : Singleton<GameManager>
{


    public GameState Curremtstate { get; private set; }
    public PlayerRuntimeData Player => Runtime.Player;

    public RuleRuntimeData Rules => Runtime.Rules;

    public ObjectiveRuntimeData Objectives => Runtime.Objectives;

    public NewsRuntimeData News => Runtime.News;

    public EconomyRuntimeData Economy => Runtime.Economy;

    public ProgressRuntimeData Progress => Runtime.Progress;

    public SettingsRuntimeData Settings => Runtime.Settings;

    public event Action<GameState> OnGameStateChanged;

    public void SetState(GameState _state)
    {
        Curremtstate = _state;
        OnGameStateChanged?.Invoke(_state);
    }

    protected override void Awake()
    {
        base.Awake();

        Debug.Log("GameManager Initialized");
    }

    void Start()
    {
        SetState(GameState.BootStrap);
    }
    #region Runtime
    public RuntimeData Runtime { get; private set; }

    public void InitializeNewGame()
    {
        Runtime = new RuntimeData();
    }

    public void ApplyRuntime(RuntimeData runtime)
    {
        Runtime = runtime;
    }

    #endregion
}

public enum GameState
{
    BootStrap,
    MainMenu,
    Loading,
    Playing,
    Paused,
    ShiftCOmplete,
    GameOver,
    Settings,
    Quitting
}
