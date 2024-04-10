using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewEquipSelected : MonoBehaviour, IView<ViewDataEquipCell>
{
    ViewDataEquipCell ViewData { get; set; }

    public void Init(ViewDataEquipCell viewData)
    {
        if (ViewData != null)
        {
            ViewData.Select(false);
            ViewData.OnUpdated -= OnViewDataUpdated;
        }
        ViewData = viewData;
        if (ViewData != null)
        {
            ViewData.Select(true);
            ViewData.OnUpdated += OnViewDataUpdated;
        }

        OnViewDataUpdated(ViewData);
    }

    void OnViewDataUpdated(ViewDataEquipCell viewData)
    {
        if (viewData != null)
        {
            // update ui

            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
