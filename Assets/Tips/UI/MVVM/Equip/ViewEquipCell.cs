using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewEquipCell : MonoBehaviour, IView<ViewDataEquipCell>
{
    public ViewDataEquipCell ViewData { get; private set; }

    public void Init(ViewDataEquipCell viewData)
    {
        if (ViewData != null)
        {
            ViewData.OnUpdated -= OnViewDataUpdated;
            ViewData.OnSelected -= OnViewDataSelected;
        }
        ViewData = viewData;
        if (ViewData != null)
        {
            ViewData.OnUpdated += OnViewDataUpdated;
            ViewData.OnSelected += OnViewDataSelected;
        }
    }

    void OnClickBtn()
    {
        ViewData.Select(true);
    }

    void OnViewDataUpdated(ViewDataEquipCell viewData)
    {
        // update ui
    }

    void OnViewDataSelected(ViewDataEquipCell viewData)
    {
        // update ui
    }
}
