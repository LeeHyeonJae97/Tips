using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int ActionPoint { get; private set; }

    public int ActionId { get; set; }

    public void DoAction()
    {
        switch (ActionId)
        {
            case 0:
                Attack();
                break;
            case 1:
                Defense();
                break;
            case 2:
                Run();
                break;
            case 3:
                DoNothing();
                break;
        }
    }

    void Attack()
    {
        // TODO :
        //
    }

    void Defense()
    {
        // TODO :
        //
    }

    void Run()
    {
        // TODO :
        //
    }

    void DoNothing()
    {
        // TODO :
        //
    }
}
