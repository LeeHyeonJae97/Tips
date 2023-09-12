using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public interface IDatum
    {

    }

    public interface IData
    {

    }

    public class CharacterData : IData
    {
        List<CharacterDatum> _data;

        public CharacterDatum this[int index] { get { return _data[index]; } }

        public CharacterDatum Find(int id)
        {
            return _data.Find((datum) => datum.Id == id);
        }

        public List<CharacterDatum> Find(string key)
        {
            return _data.FindAll((datum) => datum.Key.Equals(key));
        }

        public static void Load()
        {
            // TODO :
            // Get data from server and parse it and add them to DataManager
            //

            DataContainer.Add<CharacterData>(new CharacterData());
        }
    }

    public class ItemData : IData
    {
        Dictionary<string, ItemDatum> _data;

        public ItemDatum this[string key] { get { return _data[key]; } }

        public static void Load()
        {
            // TODO :
            // Get data from server and parse it and add them to DataManager
            //

            DataContainer.Add<ItemData>(new ItemData());
        }
    }

    [System.Serializable]
    public class CharacterDatum : IDatum
    {
        public int Id { get { return _id; } }

        public string Key { get { return _key; } }

        public int Level { get { return _level; } }

        public int Exp { get { return _exp; } }

        [SerializeField]
        int _id;

        [SerializeField]
        string _key;

        [SerializeField]
        int _level;

        [SerializeField]
        int _exp;
    }

    [System.Serializable]
    public class ItemDatum : IDatum
    {
        public string Key { get { return _key; } }

        public string Name { get { return _name; } }

        public string Desc { get { return _desc; } }

        public int Grade { get { return _grade; } }

        [SerializeField]
        string _key;

        [SerializeField]
        string _name;

        [SerializeField]
        string _desc;

        [SerializeField]
        int _grade;
    }
}
