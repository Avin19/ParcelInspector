using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameState Curremtstate { get; private set; }

    public event Action<GameState> OnGameStateChanged;

    public void SetState(GameState _state)
    {
        Curremtstate = _state;
        OnGameStateChanged?.Invoke(_state);
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        SetState(GameState.BootStrap);
    }
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
