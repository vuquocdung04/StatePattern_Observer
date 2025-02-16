using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverManager : MonoBehaviour
{
    static ObserverManager instance;
    public static ObserverManager Instance => instance;

    private Dictionary<string, List<Action<object>>> _listeners = new Dictionary<string, List<Action<object>>>();

    private void Awake()
    {
        instance = this;
    }


    public bool AddListener(string key, Action<object> value)
    {
        List<Action<object>> actions = new List<Action<object>>();
        if (_listeners.ContainsKey(key))
        {
            actions = _listeners[key];
        }
        else
        {
            _listeners.TryAdd(key, actions);
        }
        _listeners[key].Add(value);
        return true;
    }

    public void Notify(string key, object value)
    {
        if (_listeners.ContainsKey(key))
        {
            foreach (Action<object> a in _listeners[key])
            {
                a?.Invoke(value);
            }
            return;
        }

        Debug.LogErrorFormat("List {0} not exits", key);
    }
}
