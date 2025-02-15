using System;
using System.Collections.Concurrent;
using System.Linq;
using MFramework.InputListener.Native;
using UnityEngine;

namespace MFramework.InputListener
{
    public class DeviceInputListener : MonoBehaviour
    {
        internal ConcurrentDictionary<VirtualKeyCode, VirtualKeyState> keyStates =
            new ConcurrentDictionary<VirtualKeyCode, VirtualKeyState>();

        protected virtual void Awake()
        {
            var allKeyCodes = Enum.GetValues(typeof(VirtualKeyCode)).Cast<VirtualKeyCode>();
            foreach (var keyCode in allKeyCodes)
            {
                keyStates.TryAdd(keyCode, new VirtualKeyState());
            }
        }

        protected static bool IsKeyDown(VirtualKeyCode keyCode)
        {
            short result = NativeMethods.GetKeyState((ushort)keyCode);
            return result < 0;
        }

        protected static bool IsKeyUp(VirtualKeyCode keyCode)
        {
            return !IsKeyDown(keyCode);
        }

        protected static bool IsHardwareKeyDown(VirtualKeyCode keyCode)
        {
            var result = NativeMethods.GetAsyncKeyState((ushort)keyCode);
            return (result & 0x8000) != 0;
        }

        protected static bool IsHardwareKeyUp(VirtualKeyCode keyCode)
        {
            return !IsHardwareKeyDown(keyCode);
        }

        protected static bool IsTogglingKeyInEffect(VirtualKeyCode keyCode)
        {
            short result = NativeMethods.GetKeyState((ushort)keyCode);
            return (result & 0x01) == 0x01;
        }
    }
}