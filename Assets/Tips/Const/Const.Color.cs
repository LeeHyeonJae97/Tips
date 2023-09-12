using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class Const
{
    // const로 선언할 수 없는 경우 static readonly로 선언
    //
    public static readonly Color red = Color.red;
    public static readonly Color blue = Color.blue;

    public const string hexRed = "#FF0000";
    public const string hexBlue = "#0000FF";
}
