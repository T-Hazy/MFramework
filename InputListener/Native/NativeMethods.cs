using System;
using System.Runtime.InteropServices;
namespace MFramework.InputListener.Native
{
    internal static class NativeMethods
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern short GetAsyncKeyState(ushort virtualKeyCode);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern short GetKeyState(ushort virtualKeyCode);

        [DllImport("user32.dll")]
        public static extern IntPtr GetMessageExtraInfo();

        /// <summary>
        ///用于查找单键输入的键盘输入扫描码。当扫描未设置时，一些应用程序不接收输入。
        /// </summary>
        /// <param name="uCode"></param>
        /// <param name="uMapType"></param>
        [DllImport("user32.dll")]
        public static extern uint MapVirtualKey(uint uCode, uint uMapType);
    }
}