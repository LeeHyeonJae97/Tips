using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BattleManager
{
    public static bool IsEnableAutopilot { get; set; }

    static List<Character> _turns;
    static List<Character> _characters;
    static UIController _uiController;
    static Autopilot _autopilot;
    static int _index;

    public static void Init(List<Character> characters)
    {
        _turns = new List<Character>(_characters);
        _characters = characters;
        _uiController = new GameObject().AddComponent<UIController>();
        _autopilot = new Autopilot();
    }

    public static bool TryBattle()
    {
        // NOTE :
        // need to set all characters' action
        //
        if (_index < _turns.Count) return false;

        if (_turns.Count == 0) return true;

        foreach (var turn in _turns)
        {
            turn.DoAction();
        }

        Update();

        return true;
    }

    public static bool SetAction(int actionId)
    {
        _turns[_index++].ActionId = actionId;

        return _index == _turns.Count;
    }

    static void Update()
    {
        _turns.Sort((l, r) => r.ActionPoint.CompareTo(l.ActionPoint));
        _index = 0;

        // NOTE :
        // if enabled autopilot, run the autopilot or,
        // set active ui for the player to control characters
        //
        if (IsEnableAutopilot)
        {
            _autopilot.Run();
        }
        else
        {
            _uiController.SetActive(true);
        }
    }
}
