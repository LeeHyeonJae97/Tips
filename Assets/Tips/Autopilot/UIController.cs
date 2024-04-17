using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    Button _btnBattle;

    [SerializeField]
    Button _btnAtk;

    [SerializeField]
    Button _btnDef;

    [SerializeField]
    Button _btnRun;

    [SerializeField]
    Button _btnDoNothing;

    void Start()
    {
        _btnBattle.onClick.AddListener(OnClickBtnBattle);
        _btnAtk.onClick.AddListener(OnClickBtnAtk);
        _btnDef.onClick.AddListener(OnClickBtnDef);
        _btnRun.onClick.AddListener(OnClickBtnRun);
        _btnDoNothing.onClick.AddListener(OnClickBtnDoNothing);
    }

    public void SetActive(bool value)
    {
        gameObject.SetActive(value);
    }

    void OnClickBtnBattle()
    {
        if (!BattleManager.TryBattle())
        {
            // TODO :
            // show message to set action
            //
        }
    }

    void OnClickBtnAtk()
    {
        BattleManager.SetAction(0);
    }

    void OnClickBtnDef()
    {
        BattleManager.SetAction(1);
    }

    void OnClickBtnRun()
    {
        BattleManager.SetAction(2);
    }

    void OnClickBtnDoNothing()
    {
        BattleManager.SetAction(3);
    }
}
