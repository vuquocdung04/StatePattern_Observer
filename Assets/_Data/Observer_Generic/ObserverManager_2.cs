using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObserverManager_2<T> : MonoBehaviour
{
    static List<Action<T>> listeners = new List<Action<T>>();


    #region Co tham tri
    public static void AddObserver(Action<T> callback)
    {
        // contains ton tai
        if(!listeners.Contains(callback))
            listeners.Add(callback);
    }
    public static void RemoveObserver(Action<T> callback)
    {
        if (!listeners.Contains(callback))
            return;
        listeners.Remove(callback);
    }
    public static void Notify(T callback)
    {
        if (listeners.Count == 0)
            return;
        foreach (Action<T> action in listeners)
        {
            action?.Invoke(callback);
        }
    }
    #endregion


}
