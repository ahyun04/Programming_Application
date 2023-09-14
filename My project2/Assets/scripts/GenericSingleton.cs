using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSingleton<T> : MonoBehaviour where T : Component
{
    private static T _Instance;

    public static T Instance
    {
        get
        {
            if(Instance == null)
            {
                _Instance = FindObjectOfType<T>();
                if(_Instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).Name;
                    _Instance = obj.AddComponent<T>();
                }
            }
            return _Instance;
        }
    }

    private void Awake()
    {
        if (_Instance == null)
        {
            _Instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else if(_Instance != null)
        {
            Destroy(gameObject);
        }
    }

}
