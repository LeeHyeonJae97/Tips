using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewDataEquipList : IViewData
{
    public List<ViewDataEquipCell> List { get; private set; }

    public event Action<ViewDataEquipList> OnUpdated;

    public ViewDataEquipList(ViewDataEquipFilter viewDataEquipFilter)
    {
        List = new List<ViewDataEquipCell>();

        viewDataEquipFilter.OnUpdated += OnFiltered;
    }

    void OnFiltered(ViewDataEquipFilter viewData)
    {
        // update data

        OnUpdated?.Invoke(this);
    }
}
