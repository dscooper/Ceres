using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceres
{
  [JsonObject(MemberSerialization.OptIn)]
  public class CeresProperties
  {
    #region Read
    // -------------------------------------------------------------------------
    /// <summary>
    /// Read the properties from the propertes file.
    /// </summary>
    // -------------------------------------------------------------------------
    public void Read()
    {
      string inputFileName = Path.Combine(propertyFilePath, propertyFileName);

      try
      {
        using (StreamReader file = File.OpenText(inputFileName))
        {
          string data = file.ReadToEnd();
          CeresProperties properties = JsonConvert.DeserializeObject<CeresProperties>(data);

          // copy the data
          Copy(properties);
        }
      }
      catch (Exception ex)
      {
        // ignore file not found. Will be created on Write
        //throw ex; // TODO - remove
      }
    } // Read
    #endregion

    #region Write
    // -------------------------------------------------------------------------
    /// <summary>
    /// Write the properties to the properties file.
    /// </summary>
    // -------------------------------------------------------------------------
    public void Write()
    {
      string s = JsonConvert.SerializeObject(this, Formatting.Indented);
      StringBuilder sb = new StringBuilder(s);
      string outputFileName = Path.Combine(propertyFilePath, propertyFileName);

      using (StreamWriter file = File.CreateText(outputFileName))
      {
        file.Write(sb);
      }
    } // Write
    #endregion

    #region Copy
    // -------------------------------------------------------------------------
    /// <summary>
    /// Helper method that copies all the properties from reading the properties
    /// file into the local instance methods;
    /// </summary>
    /// <param name="properties">The instance variable to copy from.</param>
    // -------------------------------------------------------------------------
    private void Copy(CeresProperties properties)
    {
      mainWindow.size.Width = properties.mainWindow.size.Width;
      mainWindow.size.Height = properties.mainWindow.size.Height;

      mainWindow.serialPortProperties.SerialPort = properties.mainWindow.serialPortProperties.SerialPort;
      mainWindow.serialPortProperties.BaudRate = properties.mainWindow.serialPortProperties.BaudRate;
      mainWindow.serialPortProperties.DataBits = properties.mainWindow.serialPortProperties.DataBits;
      mainWindow.serialPortProperties.Parity = properties.mainWindow.serialPortProperties.Parity;
      mainWindow.serialPortProperties.StopBits = properties.mainWindow.serialPortProperties.StopBits;
      mainWindow.serialPortProperties.Handshake = properties.mainWindow.serialPortProperties.Handshake;

      mainWindow.outTextBox.Font = properties.mainWindow.outTextBox.Font;
      mainWindow.outTextBox.ForeColor = properties.mainWindow.outTextBox.ForeColor;
      mainWindow.outTextBox.BackColor = properties.mainWindow.outTextBox.BackColor;

      mainWindow.inTextBox.Font = properties.mainWindow.inTextBox.Font;
      mainWindow.inTextBox.ForeColor = properties.mainWindow.inTextBox.ForeColor;
      mainWindow.inTextBox.BackColor = properties.mainWindow.inTextBox.BackColor;
    } // Copy
    #endregion

    #region ctor
    // -------------------------------------------------------------------------
    /// <summary>
    /// Defalt constructor
    /// </summary>
    // -------------------------------------------------------------------------
    public CeresProperties()
    {
      mainWindow = new MainWindow();
      propertyFileName = @"Ceres.json";
      propertyFilePath = Application.LocalUserAppDataPath; // Application.CommonAppDataPath; // Application.LocalUserAppDataPath;
    } // ctor

    #region properties and instance variables

    public string propertyFileName
    {
      get { return _propertyFileName; }
      set { _propertyFileName = value; }
    }

    public string propertyFilePath
    {
      get { return _propertyFilePath; }
      set { _propertyFilePath = value; }
    }

    [JsonProperty("MainForm")]
    public MainWindow mainWindow;

    private string _propertyFilePath;
    private string _propertyFileName;

    #endregion
  } // class CeresProperties
  #endregion

  #region MainWindow
  // ---------------------------------------------------------------------------
  /// <summary>
  /// These are properties associated with the MainForm
  /// </summary>
  // ---------------------------------------------------------------------------
  public class MainWindow
  {
    public MainWindow()
    {
      size = new WindowSize();
      serialPortProperties = new SerialPortProperties();
      outTextBox = new OutTextBox();
      inTextBox = new InTextBox();
    }

    [JsonProperty("Size")]
    public WindowSize size;
    [JsonProperty("SerialPortProperties")]
    public SerialPortProperties serialPortProperties;
    [JsonProperty("SendTextBox")]
    public OutTextBox outTextBox;
    [JsonProperty("ReceiveTextBox")]
    public InTextBox inTextBox;
  } // MainWindow
  #endregion

  // ---------------------------------------------------------------------------
  public class WindowSize
  {
    public WindowSize()
    {
      Width = "900";
      Height = "600";
    }

    public string Width { get; set; }
    public string Height { get; set; }
  }

  // ---------------------------------------------------------------------------
  public class SerialPortProperties
  {
    public SerialPortProperties()
    {
      SerialPort = "None";
      BaudRate = "19200";
      DataBits = "8";
      Parity = "None";
      StopBits = "One";
      Handshake = "None";
    }

    public string SerialPort { get; set; }
    public string BaudRate { get; set; }
    public string DataBits { get; set; }
    public string Parity { get; set; }
    public string StopBits { get; set; }
    public string Handshake { get; set; }
  }

  // ---------------------------------------------------------------------------
  public class OutTextBox
  {
    public OutTextBox()
    {
      Font = "Microsoft Sans Serif, 8.25pt";
      ForeColor = "Black";
      BackColor = "White";
    }

    public string Font { get; set; }
    public string ForeColor { get; set; }
    public string BackColor { get; set; }
  }

  // ---------------------------------------------------------------------------
  public class InTextBox
  {
    public InTextBox()
    {
      Font = "Microsoft Sans Serif, 8.25pt";
      ForeColor = "Black";
      BackColor = "White";
    }

    public string Font { get; set; }
    public string ForeColor { get; set; }
    public string BackColor { get; set; }
  }

} // namespace Ceres
