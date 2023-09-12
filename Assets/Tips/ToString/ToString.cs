using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ���ڿ��� ǥ���ϴ� �������� ��Ŀ� ����
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
