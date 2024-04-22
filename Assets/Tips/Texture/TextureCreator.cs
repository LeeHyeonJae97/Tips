using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TextureCreator
{
    public static void Create(string path, int width, int height)
    {
        var texture = new Texture2D(width, height);
        var bytes = texture.EncodeToPNG();

        File.WriteAllBytes(path, bytes);
    }

    public static void Load(string path, Texture2D texture)
    {
        var bytes = File.ReadAllBytes(path);

        texture.LoadImage(bytes);
        texture.Apply();
    }
}
