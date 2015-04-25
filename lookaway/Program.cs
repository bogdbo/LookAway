using System;
using System.Windows.Forms;

namespace lookaway
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(args.Length == 2 ? new CountDown(args[0], int.Parse(args[1])) : new CountDown());
    }
  }
}
