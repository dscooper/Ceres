using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace CommPort
{
  public class CommPortOptions
  {

    #region GetPortNames
    // -------------------------------------------------------------------------
    /// <summary>
    /// Goes to the operating system and gets a list of the available serial
    /// port names. This does not guarantee that the port is available, only
    /// that it is listed in the registry at the time of the inquiry.
    /// </summary>
    /// <returns>true if executed successfully, false otherwise</returns>
    // -------------------------------------------------------------------------
    public bool GetPortNames()
    {
      bool result = true;   // assume success
      string[] comPorts = null;

      try
      {
        comPorts = SerialPort.GetPortNames();
        CommPortComparator comparator = new CommPortComparator();
        Array.Sort(comPorts, comparator);
      }
      catch (Exception e)
      {
        commPortError.lastError = e.Message;
        result = false;
      }

      // add the port names
      if (comPorts != null)
      {
        foreach (string s in comPorts)
        {
          portNameOptions.Add(s);
        }
      }

      return result;
    } // GetPortNames
    #endregion

    #region DiscoverOptions
    // -------------------------------------------------------------------------
    /// <summary>
    /// This method discovers the available options for the serial port. This 
    /// includes serial port names (as strings), handshake, parity and stop bit
    /// options.
    /// </summary>
    // -------------------------------------------------------------------------
    private void DiscoverOptions()
    {
      // get the serial port names from the OS
      GetPortNames();

      // baud rates and data bit options are hard coded

      // get the Parity options
      foreach (string s in Enum.GetNames(typeof(Parity)))
      {
        parityOptions.Add(s);
      }

      // get the Stop bit options
      foreach (string s in Enum.GetNames(typeof(StopBits)))
      {
        if (s.CompareTo("None") == 0)
          continue;
        stopbitOptions.Add(s);
      }

      // get Handshake (flow control) options
      foreach (string s in Enum.GetNames(typeof(Handshake)))
      {
        flowControlOptions.Add(s);
      }
    } // DiscoverOptions 
    #endregion

    #region ctor
    // -------------------------------------------------------------------------
    /// <summary>
    /// Default constructor
    /// </summary>
    // -------------------------------------------------------------------------
    public CommPortOptions(CommPortErrors errorHandler)
    {
      commPortError = errorHandler;
      portNameOptions = new List<string>();
      baudRateOptions = new List<string>(AllBaudRates);
      databitOptions = new List<string>(AllDataBits);
      parityOptions = new List<string>();
      stopbitOptions = new List<string>();
      flowControlOptions = new List<string>();
      DiscoverOptions();
    } // ctor
    #endregion

    #region properties

    /// <summary>Error class</summary>
    CommPortErrors commPortError;

    /// <summary>Supported data bits </summary>
    private static string[] AllDataBits =
    {
      "8", "7", "6", "5"
    };

    /// <summary>Supported baud rates</summary>
    private static string[] AllBaudRates =
    {
      "1200", "1800", "2400", "4800", "7200", "9600",
      "14400", "19200", "38400", "56000", "57600",
      "115200",
    };

    /// <summary>
    /// A list of serial port string as returned by the operating system.
    /// </summary>
    public List<string> portNameOptions { get; set; }

    /// <summary>A list of baud rate options.</summary>
    public List<string> baudRateOptions { get; set; }

    /// <summary>A list of data bit options.</summary>
    public List<string> databitOptions { get; set; }

    /// <summary>A list of parity bit options.</summary>
    public List<string> parityOptions { get; set; }

    /// <summary>A list of stop bit options.</summary>
    public List<string> stopbitOptions { get; set; }

    /// <summary>A list of flow controlled options.</summary>
    public List<string> flowControlOptions { get; set; }

    #endregion

  } // class CommPortOptions

  // ---------------------------------------------------------------------------
  /// <summary>
  /// Implements a generic comparator to be used in the sorting of the serial
  /// port names. This is a helper class used by the GetPortNames() method.
  /// </summary>
  /// <exception cref="ArgumentException">thrown by Regex.Split</exception>
  /// <exception cref="ArgumentNullException">thrown by Regex.Split</exception>
  /// <exception cref="RegexMatchTimeoutException">thrown by Regex.Split</exception>
  /// <exception cref="FormatException">thrown by Convert.ToInt32</exception>
  /// <exception cref="OverflowException">thrown by Convert.ToInt32</exception>
  // ---------------------------------------------------------------------------
  internal class CommPortComparator : IComparer<string>
  {
    public int Compare(string a, string b)
    {
      int x = 0;
      int y = 0;

      string[] result1 = Regex.Split((string)a, "^[a-zA-Z]+");
      string[] result2 = Regex.Split((string)b, "^[a-zA-Z]+");
      x = Convert.ToInt32(result1[1]);
      y = Convert.ToInt32(result2[1]);

      return (x == y) ? 0 : ((x > y) ? 1 : -1);

    } // Compare
  } // class CommPortComparator

} // namespace CommPort
