using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommPort
{
  public class CommPortErrors
  {
    #region properties

    // -------------------------------------------------------------------------
    /// <summary>
    /// Returns true if an error has occured and an error message is ready, 
    /// false othwise.
    /// </summary>
    // -------------------------------------------------------------------------
    public bool errorOccured
    {
      get;
      private set;
    } // errorOccured

    // -------------------------------------------------------------------------
    /// <summary>
    /// Represents the last error seen by the serial port. Sets the <i>errorOccured</i>
    /// flag to <i>true</i> on write and <i>false</i> read.
    /// </summary>
    // -------------------------------------------------------------------------
    public string lastError
    {
      get
      {
        errorOccured = false;
        return _lastError.ToString();
      }
      set
      {
        if (_lastError.Length > 0)
        {
          _lastError.Remove(0, _lastError.Length);
        }

        _lastError.AppendFormat("CommPort: {0}", value);
        errorOccured = true;
      }
    }

    #endregion

    #region ctor
    // -------------------------------------------------------------------------
    /// <summary>
    /// Default constructor
    /// </summary>
    // -------------------------------------------------------------------------
    public CommPortErrors()
    {
      _lastError.Append("No error");

      // create the errors
      errorDirectory = new System.Collections.Generic.Dictionary<SerialError, string>();
      errorDirectory.Add(SerialError.RXOver, errorStrings[0]);
      errorDirectory.Add(SerialError.Overrun, errorStrings[1]);
      errorDirectory.Add(SerialError.RXParity, errorStrings[2]);
      errorDirectory.Add(SerialError.Frame, errorStrings[3]);
      errorDirectory.Add(SerialError.TXFull, errorStrings[4]);
    } // ctor
    #endregion

    #region instance variables
    /// <summary>The string that holds the current error</summary>
    private StringBuilder _lastError = new StringBuilder();

    /// <summary>
    /// Directory of error strings associated with the ErrorReceived event.
    /// </summary>
    Dictionary<SerialError, string> errorDirectory;

    /// <summary>
    /// The error strings associated with the ErrorReceived event.
    /// </summary>
    static private string[] errorStrings =
    {
      // SerialError.RXOver (1)
      "An input buffer overflow has occurred. There is either no room in the input " +
        "buffer, or a character was received after the end-of-file (EOF) character.",

      // SerialError.Overrun (2)
      "A character-buffer overrun has occurred. The next character is lost.",

      // SerialError.RXParity (4)
      "The hardware detected a parity error.",

      // SerialError.Frame (8)
      "The hardware detected a framing error.",

      // SerialError.TXFull (256)
      "The application tried to transmit a character, but the output buffer was full."
    };
    #endregion
  } // class CommPortErrors
} // namespace CommPort
