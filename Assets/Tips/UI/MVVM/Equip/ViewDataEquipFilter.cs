using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewDataEquipFilter : IViewData
{
    public event Action<ViewDataEquipFilter> OnUpdated;

    public void Clear()
    {
        // clear data

        OnUpdated?.Invoke(this);
    }
}
