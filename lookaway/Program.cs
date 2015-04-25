using System;
using System.Threading;
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
      if (args.Length == 2)
      {
        Application.Run(new CountDown(args[0], Int32.Parse(args[1])));
      }
      else
      {
        Application.Run(new CountDown());
      }
    }
  }
}
