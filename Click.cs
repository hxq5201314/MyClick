using System.Runtime.InteropServices;

namespace MyClick
{
    public partial class Click : Form
    {
        // mouse_event 标志:左键按下/抬起
        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;

        // 全局热键 F1 启停
        private const int WM_HOTKEY = 0x0312;
        private const int HOTKEY_ID = 0x9001;
        private const uint VK_F1 = 0x70;

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, IntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private System.Windows.Forms.Timer clickTimer;
        private System.Windows.Forms.Timer bufferTimer;
        private int bufferCountdown;
        private int currentIntervalSec;
        private int currentClickCount;
        private bool isRunning;

        public Click()
        {
            InitializeComponent();
            clickTimer = new System.Windows.Forms.Timer();
            clickTimer.Tick += ClickTimer_Tick;
            bufferTimer = new System.Windows.Forms.Timer();
            bufferTimer.Tick += BufferTimer_Tick;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            // 注册全局热键 F1
            RegisterHotKey(Handle, HOTKEY_ID, 0, VK_F1);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            clickTimer?.Stop();
            bufferTimer?.Stop();
            UnregisterHotKey(Handle, HOTKEY_ID);
            base.OnFormClosing(e);
        }

        protected override void WndProc(ref Message m)
        {
            // 处理全局热键消息
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
            {
                ToggleRunning();
            }
            base.WndProc(ref m);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ToggleRunning();
        }

        private void ToggleRunning()
        {
            if (isRunning) Stop();
            else Start();
        }

        private void Start()
        {
            int intervalSec = (int)numericInterval.Value;
            int clickCount = (int)numericCount.Value;
            int bufferSec = (int)numericBuffer.Value;

            if (intervalSec <= 0) intervalSec = 1;
            if (clickCount <= 0) clickCount = 1;

            currentIntervalSec = intervalSec;
            currentClickCount = clickCount;
            isRunning = true;
            buttonStart.Text = "停止";

            if (bufferSec > 0)
            {
                // 进入缓冲倒计时
                bufferCountdown = bufferSec;
                bufferTimer.Interval = 1000;
                bufferTimer.Start();
                UpdateStatus($"状态: 缓冲 {bufferCountdown} 秒");
            }
            else
            {
                StartClicking();
            }
        }

        private void StartClicking()
        {
            clickTimer.Interval = currentIntervalSec * 1000;
            clickTimer.Start();
            UpdateStatus("状态: 运行中");
            PerformClicks(currentClickCount);
        }

        private void Stop()
        {
            clickTimer.Stop();
            bufferTimer.Stop();
            isRunning = false;
            buttonStart.Text = "开始";
            UpdateStatus("状态: 已停止");
        }

        private void BufferTimer_Tick(object? sender, EventArgs e)
        {
            bufferCountdown--;
            if (bufferCountdown <= 0)
            {
                bufferTimer.Stop();
                StartClicking();
            }
            else
            {
                UpdateStatus($"状态: 缓冲 {bufferCountdown} 秒");
            }
        }

        private void ClickTimer_Tick(object? sender, EventArgs e)
        {
            PerformClicks(currentClickCount);
        }

        private void PerformClicks(int count)
        {
            for (int i = 0; i < count; i++)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero);
            }
        }

        private void UpdateStatus(string text)
        {
            labelStatus.Text = text;
        }
    }
}
