namespace MFramework.InputListener.Native
{
    /// <summary>
    /// VirtualKeyCodes列表（参见：https://learn.microsoft.com/zh-cn/windows/win32/inputdev/virtual-key-codes）
    /// </summary>
    public enum VirtualKeyCode //: UInt16
    {
        /// <summary>
        /// 鼠标左键
        /// </summary>
        LBUTTON = 0x01,

        /// <summary>
        /// 鼠标右键
        /// </summary>
        RBUTTON = 0x02,

        /// <summary>
        /// 控制中断处理
        /// </summary>
        CANCEL = 0x03,

        /// <summary>
        /// 鼠标中键（三键鼠标）-与LBUTTON和RBUTTON不相邻
        /// </summary>
        MBUTTON = 0x04,

        /// <summary>
        /// Windows 2000/XP: X1鼠标按钮-不与LBUTTON和RBUTTON相邻
        /// </summary>
        XBUTTON1 = 0x05,

        /// <summary>
        /// Windows 2000/XP: X2鼠标按钮-不与LBUTTON和RBUTTON相邻
        /// </summary>
        XBUTTON2 = 0x06,

        // 0x07 : Undefined

        /// <summary>
        /// 退格键
        /// </summary>
        BACK = 0x08,

        /// <summary>
        /// TAB键
        /// </summary>
        TAB = 0x09,

        // 0x0A - 0x0B : Reserved

        /// <summary>
        /// 清除键
        /// </summary>
        CLEAR = 0x0C,

        /// <summary>
        /// 回车键
        /// </summary>
        RETURN = 0x0D,

        // 0x0E - 0x0F : Undefined

        /// <summary>
        /// SHIFT键
        /// </summary>
        SHIFT = 0x10,

        /// <summary>
        /// CTRL键
        /// </summary>
        CONTROL = 0x11,

        /// <summary>
        /// ALT键
        /// </summary>
        MENU = 0x12,

        /// <summary>
        /// 暂停键
        /// </summary>
        PAUSE = 0x13,

        /// <summary>
        /// CAPS锁定键
        /// </summary>
        CAPITAL = 0x14,

        /// <summary>
        /// 输入法编辑器（IME）假名模式
        /// </summary>
        KANA = 0x15,

        /// <summary>
        /// IME韩文模式(保持兼容性；用韩语)
        /// </summary>
        HANGEUL = 0x15,

        /// <summary>
        /// IME 韩文模式
        /// </summary>
        HANGUL = 0x15,

        // 0x16 : Undefined

        /// <summary>
        /// IME Junja mode
        /// </summary>
        JUNJA = 0x17,

        /// <summary>
        /// IME 最终模式
        /// </summary>
        FINAL = 0x18,

        /// <summary>
        /// IME Hanja mode
        /// </summary>
        HANJA = 0x19,

        /// <summary>
        /// IME Kanji mode
        /// </summary>
        KANJI = 0x19,

        // 0x1A : Undefined

        /// <summary>
        /// ESC键
        /// </summary>
        ESCAPE = 0x1B,

        /// <summary>
        /// IME convert
        /// </summary>
        CONVERT = 0x1C,

        /// <summary>
        /// IME nonconvert
        /// </summary>
        NONCONVERT = 0x1D,

        /// <summary>
        /// IME accept
        /// </summary>
        ACCEPT = 0x1E,

        /// <summary>
        /// IME mode change request
        /// </summary>
        MODECHANGE = 0x1F,

        /// <summary>
        /// 空格键
        /// </summary>
        SPACE = 0x20,

        /// <summary>
        /// 翻页键
        /// </summary>
        PRIOR = 0x21,

        /// <summary>
        /// 下页键
        /// </summary>
        NEXT = 0x22,

        /// <summary>
        /// 结束键
        /// </summary>
        END = 0x23,

        /// <summary>
        /// Home键
        /// </summary>
        HOME = 0x24,

        /// <summary>
        /// 左方向键
        /// </summary>
        LEFT = 0x25,

        /// <summary>
        /// 向上箭头键
        /// </summary>
        UP = 0x26,

        /// <summary>
        /// 右方向键
        /// </summary>
        RIGHT = 0x27,

        /// <summary>
        /// 向下箭头键
        /// </summary>
        DOWN = 0x28,

        /// <summary>
        /// 选择键
        /// </summary>
        SELECT = 0x29,

        /// <summary>
        /// 打印键
        /// </summary>
        PRINT = 0x2A,

        /// <summary>
        /// 执行键
        /// </summary>
        EXECUTE = 0x2B,

        /// <summary>
        /// 打印屏幕键
        /// </summary>
        SNAPSHOT = 0x2C,

        /// <summary>
        /// 插入键
        /// </summary>
        INSERT = 0x2D,

        /// <summary>
        /// 删除键
        /// </summary>
        DELETE = 0x2E,

        /// <summary>
        /// 帮助键
        /// </summary>
        HELP = 0x2F,

        /// <summary>
        /// 0键
        /// </summary>
        VK_0 = 0x30,

        /// <summary>
        /// 1键
        /// </summary>
        VK_1 = 0x31,

        /// <summary>
        /// 2键
        /// </summary>
        VK_2 = 0x32,

        /// <summary>
        /// 3 键
        /// </summary>
        VK_3 = 0x33,

        /// <summary>
        /// 4 键
        /// </summary>
        VK_4 = 0x34,

        /// <summary>
        /// 5 键
        /// </summary>
        VK_5 = 0x35,

        /// <summary>
        /// 6 键
        /// </summary>
        VK_6 = 0x36,

        /// <summary>
        /// 7 键
        /// </summary>
        VK_7 = 0x37,

        /// <summary>
        /// 8 键
        /// </summary>
        VK_8 = 0x38,

        /// <summary>
        /// 9 键
        /// </summary>
        VK_9 = 0x39,

        //
        // 0x3A - 0x40 : Udefined
        //

        /// <summary>
        /// A 键
        /// </summary>
        VK_A = 0x41,

        /// <summary>
        /// B 键
        /// </summary>
        VK_B = 0x42,

        /// <summary>
        /// C 键
        /// </summary>
        VK_C = 0x43,

        /// <summary>
        /// D 键
        /// </summary>
        VK_D = 0x44,

        /// <summary>
        /// E 键
        /// </summary>
        VK_E = 0x45,

        /// <summary>
        /// F 键
        /// </summary>
        VK_F = 0x46,

        /// <summary>
        /// G 键
        /// </summary>
        VK_G = 0x47,

        /// <summary>
        /// H 键
        /// </summary>
        VK_H = 0x48,

        /// <summary>
        /// I 键
        /// </summary>
        VK_I = 0x49,

        /// <summary>
        /// J 键
        /// </summary>
        VK_J = 0x4A,

        /// <summary>
        /// K 键
        /// </summary>
        VK_K = 0x4B,

        /// <summary>
        /// L 键
        /// </summary>
        VK_L = 0x4C,

        /// <summary>
        /// M 键
        /// </summary>
        VK_M = 0x4D,

        /// <summary>
        /// N 键
        /// </summary>
        VK_N = 0x4E,

        /// <summary>
        /// O 键
        /// </summary>
        VK_O = 0x4F,

        /// <summary>
        /// P 键
        /// </summary>
        VK_P = 0x50,

        /// <summary>
        /// Q 键
        /// </summary>
        VK_Q = 0x51,

        /// <summary>
        /// R 键
        /// </summary>
        VK_R = 0x52,

        /// <summary>
        /// S 键
        /// </summary>
        VK_S = 0x53,

        /// <summary>
        /// T 键
        /// </summary>
        VK_T = 0x54,

        /// <summary>
        /// U 键
        /// </summary>
        VK_U = 0x55,

        /// <summary>
        /// V 键
        /// </summary>
        VK_V = 0x56,

        /// <summary>
        /// W 键
        /// </summary>
        VK_W = 0x57,

        /// <summary>
        /// X 键
        /// </summary>
        VK_X = 0x58,

        /// <summary>
        /// Y 键
        /// </summary>
        VK_Y = 0x59,

        /// <summary>
        /// Z 键
        /// </summary>
        VK_Z = 0x5A,

        /// <summary>
        /// Windows左键（微软自然键盘）
        /// </summary>
        LWIN = 0x5B,

        /// <summary>
        /// Windows右键（自然键盘）
        /// </summary>
        RWIN = 0x5C,

        /// <summary>
        /// 应用程序键（自然键盘）
        /// </summary>
        APPS = 0x5D,

        // 0x5E : reserved

        /// <summary>
        /// 电脑睡眠键
        /// </summary>
        SLEEP = 0x5F,

        /// <summary>
        ///数字键盘0键
        /// </summary>
        NUMPAD0 = 0x60,

        /// <summary>
        /// 数字键盘1键
        /// </summary>
        NUMPAD1 = 0x61,

        /// <summary>
        /// 数字键盘2键
        /// </summary>
        NUMPAD2 = 0x62,

        /// <summary>
        /// 数字键盘3键
        /// </summary>
        NUMPAD3 = 0x63,

        /// <summary>
        /// 数字键盘4键
        /// </summary>
        NUMPAD4 = 0x64,

        /// <summary>
        /// 数字键盘5键
        /// </summary>
        NUMPAD5 = 0x65,

        /// <summary>
        /// 数字键盘6键
        /// </summary>
        NUMPAD6 = 0x66,

        /// <summary>
        /// 数字键盘7键
        /// </summary>
        NUMPAD7 = 0x67,

        /// <summary>
        /// 数字键盘8键
        /// </summary>
        NUMPAD8 = 0x68,

        /// <summary>
        /// 数字键盘9键
        /// </summary>
        NUMPAD9 = 0x69,

        /// <summary>
        /// 乘法键
        /// </summary>
        MULTIPLY = 0x6A,

        /// <summary>
        /// 加法键
        /// </summary>
        ADD = 0x6B,

        /// <summary>
        /// 分隔符键
        /// </summary>
        SEPARATOR = 0x6C,

        /// <summary>
        /// 减法键
        /// </summary>
        SUBTRACT = 0x6D,

        /// <summary>
        /// 小数点键
        /// </summary>
        DECIMAL = 0x6E,

        /// <summary>
        /// 分号键
        /// </summary>
        DIVIDE = 0x6F,

        /// <summary>
        /// F1 键
        /// </summary>
        F1 = 0x70,

        /// <summary>
        /// F2 键
        /// </summary>
        F2 = 0x71,

        /// <summary>
        /// F3 键
        /// </summary>
        F3 = 0x72,

        /// <summary>
        /// F4 键
        /// </summary>
        F4 = 0x73,

        /// <summary>
        /// F5 键
        /// </summary>
        F5 = 0x74,

        /// <summary>
        /// F6 键
        /// </summary>
        F6 = 0x75,

        /// <summary>
        /// F7 键
        /// </summary>
        F7 = 0x76,

        /// <summary>
        /// F8 键
        /// </summary>
        F8 = 0x77,

        /// <summary>
        /// F9 键
        /// </summary>
        F9 = 0x78,

        /// <summary>
        /// F10 键
        /// </summary>
        F10 = 0x79,

        /// <summary>
        /// F11 键
        /// </summary>
        F11 = 0x7A,

        /// <summary>
        /// F12 键
        /// </summary>
        F12 = 0x7B,

        /// <summary>
        /// F13 键
        /// </summary>
        F13 = 0x7C,

        /// <summary>
        /// F14 键
        /// </summary>
        F14 = 0x7D,

        /// <summary>
        /// F15 键
        /// </summary>
        F15 = 0x7E,

        /// <summary>
        /// F16 键
        /// </summary>
        F16 = 0x7F,

        /// <summary>
        /// F17 键
        /// </summary>
        F17 = 0x80,

        /// <summary>
        /// F18 键
        /// </summary>
        F18 = 0x81,

        /// <summary>
        /// F19 键
        /// </summary>
        F19 = 0x82,

        /// <summary>
        /// F20 键
        /// </summary>
        F20 = 0x83,

        /// <summary>
        /// F21 键
        /// </summary>
        F21 = 0x84,

        /// <summary>
        /// F22 键
        /// </summary>
        F22 = 0x85,

        /// <summary>
        /// F23 键
        /// </summary>
        F23 = 0x86,

        /// <summary>
        /// F24 键
        /// </summary>
        F24 = 0x87,

        //
        // 0x88 - 0x8F : Unassigned
        //

        /// <summary>
        /// 数字键盘锁键
        /// </summary>
        NUMLOCK = 0x90,

        /// <summary>
        /// 滚动锁键
        /// </summary>
        SCROLL = 0x91,

        // 0x92 - 0x96 : OEM Specific

        // 0x97 - 0x9F : Unassigned

        //
        // L* & R* - left and right Alt, Ctrl and Shift virtual keys.
        // Used only as parameters to GetAsyncKeyState() and GetKeyState().
        // No other API or message will distinguish left and right keys in this way.
        //

        /// <summary>
        /// 左SHIFT键-仅用作GetAsyncKeyState（）和GetKeyState（）的参数
        /// </summary>
        LSHIFT = 0xA0,

        /// <summary>
        /// 右SHIFT键-仅用作GetAsyncKeyState（）和GetKeyState（）的参数
        /// </summary>
        RSHIFT = 0xA1,

        /// <summary>
        /// 左控制键-仅用作GetAsyncKeyState（）和GetKeyState（）的参数
        /// </summary>
        LCONTROL = 0xA2,

        /// <summary>
        /// 右控制键-仅用作GetAsyncKeyState（）和GetKeyState（）的参数
        /// </summary>
        RCONTROL = 0xA3,

        /// <summary>
        /// 左菜单键-仅用作GetAsyncKeyState（）和GetKeyState（）的参数
        /// </summary>
        LMENU = 0xA4,

        /// <summary>
        /// 右菜单键-仅用作GetAsyncKeyState（）和GetKeyState（）的参数
        /// </summary>
        RMENU = 0xA5,

        /// <summary>
        /// Windows 2000/XP：浏览器返回键
        /// </summary>
        BROWSER_BACK = 0xA6,

        /// <summary>
        /// Windows 2000/XP：浏览器转发键
        /// </summary>
        BROWSER_FORWARD = 0xA7,

        /// <summary>
        /// Windows 2000/XP：浏览器刷新键
        /// </summary>
        BROWSER_REFRESH = 0xA8,

        /// <summary>
        /// Windows 2000/XP：浏览器停止键
        /// </summary>
        BROWSER_STOP = 0xA9,

        /// <summary>
        /// Windows 2000/XP：浏览器搜索键
        /// </summary>
        BROWSER_SEARCH = 0xAA,

        /// <summary>
        /// Windows 2000/XP：浏览器收藏夹键
        /// </summary>
        BROWSER_FAVORITES = 0xAB,

        /// <summary>
        /// Windows 2000/XP：浏览器开始和主键
        /// </summary>
        BROWSER_HOME = 0xAC,

        /// <summary>
        /// Windows 2000/XP：音量静音键
        /// </summary>
        VOLUME_MUTE = 0xAD,

        /// <summary>
        /// Windows 2000/XP：音量调低键
        /// </summary>
        VOLUME_DOWN = 0xAE,

        /// <summary>
        /// Windows 2000/XP：音量增大键
        /// </summary>
        VOLUME_UP = 0xAF,

        /// <summary>
        /// Windows 2000/XP：下一个轨道键
        /// </summary>
        MEDIA_NEXT_TRACK = 0xB0,

        /// <summary>
        /// Windows 2000/XP：上一个轨道键
        /// </summary>
        MEDIA_PREV_TRACK = 0xB1,

        /// <summary>
        /// Windows 2000/XP：停止媒体键
        /// </summary>
        MEDIA_STOP = 0xB2,

        /// <summary>
        /// Windows 2000/XP：播放/暂停媒体键
        /// </summary>
        MEDIA_PLAY_PAUSE = 0xB3,

        /// <summary>
        /// Windows 2000/XP：启动邮件键
        /// </summary>
        LAUNCH_MAIL = 0xB4,

        /// <summary>
        /// Windows 2000/XP：选择“媒体键”
        /// </summary>
        LAUNCH_MEDIA_SELECT = 0xB5,

        /// <summary>
        /// Windows 2000/XP：启动应用程序1键
        /// </summary>
        LAUNCH_APP1 = 0xB6,

        /// <summary>
        /// Windows 2000/XP：启动应用程序2键
        /// </summary>
        LAUNCH_APP2 = 0xB7,

        //
        // 0xB8 - 0xB9 : Reserved
        //

        /// <summary>
        /// 用于杂字；它可以因键盘而异。Windows 2000/XP：对于美国标准键盘，‘;:’键
        /// </summary>
        OEM_1 = 0xBA,

        /// <summary>
        /// Windows 2000/XP：对于任何国家/地区，使用“+”键
        /// </summary>
        OEM_PLUS = 0xBB,

        /// <summary>
        /// Windows 2000/XP：对于任何国家/地区，‘,’键
        /// </summary>
        OEM_COMMA = 0xBC,

        /// <summary>
        /// Windows 2000/XP：对于任何国家/地区，“-”键
        /// </summary>
        OEM_MINUS = 0xBD,

        /// <summary>
        /// Windows 2000/XP：对于任何国家/地区，的关键
        /// </summary>
        OEM_PERIOD = 0xBE,

        /// <summary>
        /// 用于杂字；它可以因键盘而异。Windows 2000/XP：对于美国标准键盘，'/'键
        /// </summary>
        OEM_2 = 0xBF,

        /// <summary>
        /// 用于杂字；它可以因键盘而异。Windows 2000/XP：对于美国标准键盘，“~”键
        /// </summary>
        OEM_3 = 0xC0,

        //
        // 0xC1 - 0xD7 : Reserved
        //

        //
        // 0xD8 - 0xDA : Unassigned
        //

        /// <summary>
        /// 用于杂字；它可以因键盘而异。Windows 2000/XP：对于美国标准键盘，'[{'键
        /// </summary>
        OEM_4 = 0xDB,

        /// <summary>
        /// 用于杂字；它可以因键盘而异。Windows 2000/XP：对于美国标准键盘，‘\|’键
        /// </summary>
        OEM_5 = 0xDC,

        /// <summary>
        /// 用于杂字；它可以因键盘而异。Windows 2000/XP：对于美国标准键盘，']}'键
        /// </summary>
        OEM_6 = 0xDD,

        /// <summary>
        /// 用于杂字；它可以因键盘而异。Windows 2000/XP：对于美国标准键盘，“单引号/双引号”键
        /// </summary>
        OEM_7 = 0xDE,

        /// <summary>
        /// 用于杂字；它可以因键盘而异。
        /// </summary>
        OEM_8 = 0xDF,

        //
        // 0xE0 : Reserved
        //

        //
        // 0xE1 : OEM Specific
        //

        /// <summary>
        /// Windows 2000/XP：使用RT 102键键盘上的尖括号键或反斜杠键
        /// </summary>
        OEM_102 = 0xE2,

        //
        // (0xE3-E4) : OEM specific
        //

        /// <summary>
        /// Windows 95/98/Me, Windows NT 4.0， Windows 2000/XP: IME进程键
        /// </summary>
        PROCESSKEY = 0xE5,

        //
        // 0xE6 : OEM specific
        //

        /// <summary>
        /// Windows 2000/XP：用来传递Unicode字符，就好像它们是击键一样。PACKET键是用于非键盘输入法的32位虚拟键值的低位。有关更多信息，请参见KEYBDINPUT， SendInput， WM_KEYDOWN和WM_KEYUP中的注释        /// </summary>
        PACKET = 0xE7,

        //
        // 0xE8 : Unassigned
        //

        //
        // 0xE9-F5 : OEM specific
        //

        /// <summary>
        /// 注意键
        /// </summary>
        ATTN = 0xF6,

        /// <summary>
        /// CrSel关键
        /// </summary>
        CRSEL = 0xF7,

        /// <summary>
        /// ExSel关键
        /// </summary>
        EXSEL = 0xF8,

        /// <summary>
        /// 擦除EOF键
        /// </summary>
        EREOF = 0xF9,

        /// <summary>
        /// 播放键
        /// </summary>
        PLAY = 0xFA,

        /// <summary>
        /// 放大键
        /// </summary>
        ZOOM = 0xFB,

        /// <summary>
        /// 保留
        /// </summary>
        NONAME = 0xFC,

        /// <summary>
        /// PA1键
        /// </summary>
        PA1 = 0xFD,

        /// <summary>
        ///清除键
        /// </summary>
        OEM_CLEAR = 0xFE,
    }
}