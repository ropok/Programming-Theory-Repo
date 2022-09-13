using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private static DataManager _instance;
    public string inputCatName;

    public static DataManager Instance
    {
        get
        {
            if (_instance is null)
                Debug.LogError("Data Manager is NULL");
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

}
