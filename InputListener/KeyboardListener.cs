using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MFramework.InputListener.Native;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace MFramework.InputListener
{
    public class KeyboardListener : DeviceInputListener
    {
        public bool GetKey(VirtualKeyCode keyCode) =>
            keyStates.TryGetValue(keyCode, out var keyState) && keyState.keyPressed;

        public bool GetKeyDown(VirtualKeyCode keyCode) =>
            keyStates.TryGetValue(keyCode, out var keyState) && keyState.keyDown;

        public bool GetKeyUp(VirtualKeyCode keyCode) =>
            keyStates.TryGetValue(keyCode, out var keyState) && keyState.keyUp;

        public bool GetKeyClick(VirtualKeyCode keyCode) =>
            keyStates.TryGetValue(keyCode, out var keyState) && keyState.click;

        public bool GetKeyDoubleClick(VirtualKeyCode keyCode) =>
            keyStates.TryGetValue(keyCode, out var keyState) && keyState.doubleClick;

        public bool GetKeyLongClick(VirtualKeyCode keyCode) =>
            keyStates.TryGetValue(keyCode, out var keyState) && keyState.longClick;

        private CancellationTokenSource cancelTokenSource;

        private DateTime dateTime;

        private void Start()
        {
            cancelTokenSource = new CancellationTokenSource();
            Listening(cancelTokenSource.Token);
        }


        private async void Listening(CancellationToken cancelToken)
        {
            try
            {
                while (!cancelToken.IsCancellationRequested)
                {
                    foreach (var keyState in keyStates)
                    {
                        keyState.Value.UpdateVirtualKeyState(IsHardwareKeyDown(keyState.Key));
                    }
                    await Task.Delay(10, cancelToken);
                }
            }
            catch (OperationCanceledException)
            {
                // 任务被正常取消，无需记录
            }
            catch (Exception ex)
            {
                Debug.LogError($"Unexpected error in KeyboardListener: {ex}");
            }
        }

        private void OnDestroy()
        {
            if (_instance == this) _instance = null;
            cancelTokenSource?.Cancel();
            cancelTokenSource?.Dispose();
        }

        #region Instance

        private static readonly object _lock = new object();
        private static KeyboardListener _instance;

        public static KeyboardListener Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_lock)
                {
                    _instance = FindObjectOfType<KeyboardListener>();
                    if (_instance != null) return _instance;
                    var listenerObject = new GameObject(nameof(KeyboardListener));
                    _instance = listenerObject.AddComponent<KeyboardListener>();
                    DontDestroyOnLoad(listenerObject);
                }

                return _instance;
            }
        }

        #endregion
    }
}