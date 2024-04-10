using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IView<T> where T : IViewData
{
    public void Init(T viewData);
}
