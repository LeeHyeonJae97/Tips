using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Data
{
    [AddComponentMenu("Data/Test")]
    public class Test : MonoBehaviour
    {
        [SerializeField]
        MockData _mockDatum;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                Create(new CharacterDatum());
            }
            else if (Input.GetKeyDown(KeyCode.I))
            {
                Create(new ItemDatum());
            }
        }

        void Create(IDatum datum)
        {
            _mockDatum.Datum = datum;
        }
    }
}
