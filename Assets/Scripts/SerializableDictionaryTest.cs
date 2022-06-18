using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class SerializableDictionaryTest : MonoBehaviour
{
    public MyDictionary myDictionary;

    // Start is called before the first frame update
    void Start()
    {
        myDictionary.Add("goku", new GameObject("Goku"));
        foreach (var kvp in myDictionary)
        {
            Debug.Log($"{kvp.Key} : {kvp.Value}");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

[System.Serializable]
public class MyDictionary : SerializableDictionary<string, GameObject>
{

}

#if UNITY_EDITOR
[CustomPropertyDrawer(typeof(MyDictionary))]
public class MyDictionaryDrawer : SerializableDictionaryDrawer<string, GameObject>
{

}
#endif
