#nullable enable
using System.Diagnostics;

namespace MFramework.InputListener
{
    internal class VirtualKeyState
    {
        public bool keyDown { get; private set; }
        public bool keyPressed { get; private set; }
        public bool keyUp { get; private set; }
        public bool click { get; private set; }
        public bool doubleClick { get; private set; }
        public bool longPressed { get; private set; }
        public bool longClick { get; private set; }

        private const int LONG_PRESS_THRESHOLD = 350; // 长按阈值(毫秒)
        private const int CLICK_THRESHOLD = 300; // 单击最大持续时间(毫秒)
        private const int DOUBLE_CLICK_THRESHOLD = 300; // 双击间隔时间(毫秒)

        private Stopwatch? pressedStopwatch;
        private Stopwatch? releaseStopwatch;

        private volatile bool previouslyKeyDown;

        //private volatile bool previouslyKeyPressed;
        private volatile bool previouslyKeyUp = true;

        internal void UpdateVirtualKeyState(bool currentState)
        {
            keyDown = !previouslyKeyDown && currentState;
            keyPressed = currentState;
            keyUp = !previouslyKeyUp && !currentState;
            if (keyDown && pressedStopwatch == null) pressedStopwatch = Stopwatch.StartNew();
            // 当按下按键且按下时长有值时获取按下消逝时间
            var pressedElapsedTime = keyPressed && pressedStopwatch != null
                ? (int)pressedStopwatch.ElapsedMilliseconds
                : -1;
            longClick = pressedElapsedTime > 0 && (pressedElapsedTime % LONG_PRESS_THRESHOLD) == 0;

            // 抬起时
            if (keyUp)
            {
                if (pressedStopwatch != null)
                {
                    var elapsedTime = (int)pressedStopwatch.ElapsedMilliseconds;
                    click = elapsedTime < CLICK_THRESHOLD;

                    pressedStopwatch.Stop();
                    pressedStopwatch = null;
                }

                if (releaseStopwatch != null)
                {
                    var elapsedTime = (int)releaseStopwatch.ElapsedMilliseconds;
                    doubleClick = elapsedTime < CLICK_THRESHOLD;

                    releaseStopwatch.Stop();
                    releaseStopwatch = null;
                }

                releaseStopwatch = Stopwatch.StartNew();
            }
            // 抬起过后
            else
            {
                click = false;
                doubleClick = false;
            }

            //记录状态
            previouslyKeyDown = currentState;
            previouslyKeyUp = !currentState;
        }
    }
}