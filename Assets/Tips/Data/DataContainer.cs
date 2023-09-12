using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class DataContainer
    {
        static Dictionary<string, IData> Data { get; set; }

        public static T Get<T>() where T: class, IData
        {
            return Data[typeof(T).ToString()] as T;            
        }

        public static void Add<T>(T data) where T : IData
        {
            Data[typeof(T).ToString()] = data;
        }
    }
}
