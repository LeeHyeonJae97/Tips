using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewEquipFilter : MonoBehaviour, IView<ViewDataEquipFilter>
{
    public ViewDataEquipFilter ViewData { get; private set; }

    public void Init(ViewDataEquipFilter viewData)
    {
        ViewData = viewData;
        ViewData.OnUpdated += OnViewDataUpdated;

        OnViewDataUpdated(viewData);
    }

    void OnClickClearBtn()
    {
        ViewData.Clear();
    }

    void OnViewDataUpdated(ViewDataEquipFilter viewData)
    {

    }
}
