using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "MockData", menuName = "ScriptableObject/MockData")]
    public class MockData : ScriptableObject
    {
        public IDatum Datum { set { _datum = value; } }

        [SerializeReference]
        IDatum _datum;

        public void Load<T>(string json) where T : IDatum
        {

        }

        public void Save()
        {

        }
    }
}
