using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewLobby : MonoBehaviour
{
    void OnClickEquipListBtn()
    {
        var viewEquipList = Instantiate(Resources.Load<ViewEquipList>(""));
        var viewDataEquipFilter = new ViewDataEquipFilter();
        viewEquipList.Init(new ViewDataEquipList(viewDataEquipFilter));

        var viewEquipSelected = viewEquipList.GetComponentInChildren<ViewEquipSelected>();
        viewEquipSelected.Init(null);

        for (int i = 0; i < viewEquipList.ViewData.List.Count; i++)
        {
            viewEquipList.ViewData.List[i].OnSelected += viewEquipSelected.Init;
        }
    }
}
