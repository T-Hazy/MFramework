using MFramework.InputListener.Native;

namespace MFramework.InputListener
{
    public static class InputListener
    {
        public static KeyboardListener keyboard => KeyboardListener.Instance;
        public static MouseListener mouse => MouseListener.Instance;
        public static bool GetKey(VirtualKeyCode keyCode) => keyboard.GetKey(keyCode);
        public static bool GetKeyDown(VirtualKeyCode keyCode) => keyboard.GetKeyDown(keyCode);
        public static bool GetKeyUp(VirtualKeyCode keyCode) => keyboard.GetKeyUp(keyCode);
        public static bool GetKeyClick(VirtualKeyCode keyCode) => keyboard.GetKeyClick(keyCode);
        public static bool GetKeyDoubleClick(VirtualKeyCode keyCode) => keyboard.GetKeyDoubleClick(keyCode);
        public static bool GetKeyLongClick(VirtualKeyCode keyCode) => keyboard.GetKeyLongClick(keyCode);
    }
}