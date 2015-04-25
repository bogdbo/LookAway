using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace lookaway
{
  public partial class CountDown : Form
  {
    private const UInt32 SWP_NOSIZE = 0x0001;
    private const UInt32 SWP_NOMOVE = 0x0002;
    private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
    private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
    private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
    private static readonly IntPtr HWND_TOP = new IntPtr(0);
    private static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
    private int duration = 20;

    protected override bool ShowWithoutActivation
    {
      get { return true; }
    }

    public CountDown()
    {
      InitializeComponent();
      TopMost = true;
      label.Text = "Start";
    }

    public CountDown(string message = "Start", int duration = 20)
      : this()
    {
      this.duration = duration + 1;
      label.Text = message;
    }

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy,
      uint uFlags);

    private void CountDown_Load(object sender, EventArgs e)
    {
      SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
      BackColor = Color.LimeGreen;
      TransparencyKey = Color.LimeGreen;
      CenterToScreen();
      timer.Interval = 1000;
      Thread.Sleep(1000);
      timer.Start();
    }

    private void Tick(object sender, EventArgs e)
    {
      label.Text = (--duration).ToString();
      if (duration == 0)
      {
        Application.Exit();
      }
    }
  }
}