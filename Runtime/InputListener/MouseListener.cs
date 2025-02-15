using System;
using UnityEngine;

namespace MFramework.InputListener
{
    public class MouseListener : DeviceInputListener
    {
        #region Instance

        private static readonly object _lock = new object();
        private static MouseListener _instance;

        public static MouseListener Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_lock)
                {
                    _instance = FindObjectOfType<MouseListener>();
                    if (_instance != null) return _instance;
                    var listenerObject = new GameObject(nameof(MouseListener));
                    _instance = listenerObject.AddComponent<MouseListener>();
                    DontDestroyOnLoad(listenerObject);
                }

                return _instance;
            }
        }

        #endregion

        private void OnDestroy()
        {
            if (_instance == this) _instance = null;
        }
    }
}