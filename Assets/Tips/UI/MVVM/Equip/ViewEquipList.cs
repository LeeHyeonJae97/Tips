using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewEquipList : MonoBehaviour, IView<ViewDataEquipList>
{
    public ViewDataEquipList ViewData { get; private set; }

    public void Init(ViewDataEquipList viewData)
    {
        ViewData = viewData;
        ViewData.OnUpdated += OnViewDataUpdated;
    }

    void OnViewDataUpdated(ViewDataEquipList viewData)
    {

    }
}
