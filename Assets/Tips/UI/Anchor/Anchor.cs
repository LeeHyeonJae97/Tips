using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Anchor : MonoBehaviour
{
    enum Type
    {
        LeftTop,
        Top,
        RightTop,
        Left,
        Center,
        Right,
        LeftBottom,
        Bottom,
        RightBottom,
    }

    [SerializeField]
    Type _type;

#if UNITY_EDITOR
    void Reset()
    {
        Refresh();
    }

    void OnValidate()
    {
        Refresh();
    }
#endif

    void OnEnable()
    {
        Refresh();
    }

    void Refresh()
    {
        var rectTr = GetComponent<RectTransform>();

        switch (_type)
        {
            case Type.LeftTop:
                Update(new Vector2(0, 1));
                break;

            case Type.Top:
                Update(new Vector2(0.5f, 1));
                break;

            case Type.RightTop:
                Update(new Vector2(1, 1));
                break;

            case Type.Left:
                Update(new Vector2(0, 0.5f));
                break;

            case Type.Center:
                Update(new Vector2(0.5f, 0.5f));
                break;

            case Type.Right:
                Update(new Vector2(1, 0.5f));
                break;

            case Type.LeftBottom:
                Update(new Vector2(0, 0));
                break;

            case Type.Bottom:
                Update(new Vector2(0.5f, 0));
                break;

            case Type.RightBottom:
                Update(new Vector2(1, 0));
                break;
        }


        void Update(Vector2 value)
        {
            gameObject.name = $"{_type}";

            rectTr.anchorMax = value;
            rectTr.anchorMin = value;
            rectTr.pivot = value;

            FixPosition();



            void FixPosition()
            {
                var width = GetComponentInParent<Canvas>().GetComponent<RectTransform>().rect.width;
                var height = GetComponentInParent<Canvas>().GetComponent<RectTransform>().rect.height;

                var targetWidth = 1920f;
                var targetHeight = 1080f;

                var ratio = (float)width / height;
                var targetRatio = (float)targetWidth / targetHeight;

                if (ratio > targetRatio)
                {
                    var fix = width * (float)(1 - (targetRatio / ratio)) / 2;

                    rectTr.anchoredPosition = new Vector2(value.x == 0 ? fix : value.x == 1 ? -fix : 0, 0);
                }
                else
                {
                    rectTr.anchoredPosition = new Vector2(0, 0);
                }
            }
        }
    }
}
