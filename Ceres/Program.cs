using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceres
{
  static class Program
  {
    // -------------------------------------------------------------------------
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    // -------------------------------------------------------------------------
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      mainForm = new MainForm();
      Application.Run(mainForm);
    } // Main

    // -------------------------------------------------------------------------
    /// <summary>
    /// Property to get access to MainForm
    /// </summary>
    // -------------------------------------------------------------------------
    static public MainForm mainForm
    {
      get { return _mainForm; }
      private set { _mainForm = value; }
    }

    #region properties
    static private MainForm _mainForm;
    #endregion
  } // class Program
} // namespace Ceres
