using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewDataEquipCell : IViewDataReuseCell
{
    public int Id { get; private set; }

    public string Key { get; private set; }

    public event Action<ViewDataEquipCell> OnUpdated;
    public event Action<ViewDataEquipCell> OnSelected;

    public ViewDataEquipCell(int id, string key)
    {
        Id = id;
        Key = key;
    }

    public void Select(bool value)
    {
        OnSelected?.Invoke(this);
    }
}
