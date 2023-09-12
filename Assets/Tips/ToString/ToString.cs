using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 개수를 문자열로 표시하는 여러가지 방식에 대응
//

public static class Count
{
    public static string ToString(int count, char delimeter = ',')
    {
        return $"{count}";
    }

    public static string ToString(int count, int padding)
    {
        return $"{count}".PadLeft(padding, '0');
    }

    public static string ToString(int count, Color color)
    {
        return $"[{ColorUtility.ToHtmlStringRGBA(color)}]{count}[-]";
    }
}
