using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommPort;
using System.IO;


namespace Ceres
{
  public partial class MainForm : Form
  {

    #region InitializeGUI
    // -------------------------------------------------------------------------
    /// <summary>
    /// 
    /// </summary>
    // -------------------------------------------------------------------------
    private void InitializeGUI()
    {
      PopulateSerialPortProperties();
      InitializeSerialPortProperties();
    } // InitializeGUI
    #endregion

    #region PopulateSerialPortProperties
    // -------------------------------------------------------------------------
    /// <summary>
    /// 
    /// </summary>
    // -------------------------------------------------------------------------
    private void PopulateSerialPortProperties()
    {
      if (commIO != null)
      {
        // fill the serialPortComboBox with serial port names
        foreach (var item in commIO.options.portNameOptions)
        {
          serialPortComboBox.Items.Add(item);
        }

        // fill the baudRateComboBox with baud rate selections
        foreach (var item in commIO.options.baudRateOptions)
        {
          baudRateComboBox.Items.Add(item);
        }

        // fill dataBitsComboBox with data bit selections
        foreach (var item in commIO.options.databitOptions)
        {
          dataBitsComboBox.Items.Add(item);
        }

        // fill the parityComboBox with parity selections
        foreach (var item in commIO.options.parityOptions)
        {
          parityComboBox.Items.Add(item);
        }

        // fill the stopBitsComboBox with stop bit selections
        foreach (var item in commIO.options.stopbitOptions)
        {
          stopBitsComboBox.Items.Add(item);
        }

        // fill the flowcontrolComboBox with flow control selections
        foreach (var item in commIO.options.flowControlOptions)
        {
          handshakeComboBox.Items.Add(item);
        }
      }
    } // PopulateSerialPortProperties 
    #endregion

    #region InitializeSerialPortProperties
    // -------------------------------------------------------------------------
    /// <summary>
    /// 
    /// </summary>
    // -------------------------------------------------------------------------
    private void InitializeSerialPortProperties()
    {
      //int index;

      //if (serialPortComboBox.Items.Count > 0)
      //{
      //  index = serialPortComboBox.FindString(
      //    properties.mainWindow.serialPortProperties.SerialPort);
      //  if (index != -1)
      //  {
      //    serialPortComboBox.Text = serialPortComboBox.Items[index].ToString();
      //  }
      //}

      //if (baudRateComboBox.Items.Count > 0)
      //{
      //  index = baudRateComboBox.FindString(
      //    properties.mainWindow.serialPortProperties.BaudRate);
      //  if (index != -1)
      //  {
      //    baudRateComboBox.Text = baudRateComboBox.Items[index].ToString();
      //  }
      //}

      //if (dataBitsComboBox.Items.Count > 0)
      //{
      //  index = dataBitsComboBox.FindString(
      //    properties.mainWindow.serialPortProperties.DataBits);
      //  if (index != -1)
      //  {
      //    dataBitsComboBox.Text = dataBitsComboBox.Items[index].ToString();
      //  }
      //}

      //if (parityComboBox.Items.Count > 0)
      //{
      //  index = parityComboBox.FindString(
      //    properties.mainWindow.serialPortProperties.Parity);
      //  if (index != -1)
      //  {
      //    parityComboBox.Text = parityComboBox.Items[index].ToString();
      //  }
      //}

      //if (stopBitsComboBox.Items.Count > 0)
      //{
      //  index = stopBitsComboBox.FindString(
      //    properties.mainWindow.serialPortProperties.StopBits);
      //  if (index != -1)
      //  {
      //    stopBitsComboBox.Text = stopBitsComboBox.Items[index].ToString();
      //  }
      //}

      //if (handshakeComboBox.Items.Count > 0)
      //{
      //  index = handshakeComboBox.FindString(
      //    properties.mainWindow.serialPortProperties.Handshake);
      //  if (index != -1)
      //  {
      //    handshakeComboBox.Text = handshakeComboBox.Items[index].ToString();
      //  }
      //}
    } // InitializeSerialPortProperties
    #endregion

    #region UpdateReceiveTextBox
    // -------------------------------------------------------------------------
    /// <summary>
    /// Updates the Receive text box from this, or any other thread.
    /// </summary>
    /// <param name="text">The text to write to the Receive text box.</param>
    // ------------------------------------------------------------------------- 
    public void UpdateReceiveTextBox(string text)
    {
      if (receiveTextBox.InvokeRequired == true)
      {
        UpdateReceiveTextBoxDelegate d =
          new UpdateReceiveTextBoxDelegate(UpdateReceiveTextBox);
        BeginInvoke(d, new object[] { text });
      }
      else
      {
        receiveTextBox.AppendText(text);
        receiveTextBox.AppendText(Environment.NewLine);
        receiveTextBox.ScrollToCaret();

        if (receiveTextBox.Text.Length > 50000)
        {
          receiveTextBox.Clear();
          //passedTestLabel.Text = string.Format( "passed: {0}", passedTests );
          //failedTestsLabel.Text = string.Format( "failed: {0}", failedTests );
        }
      }
    } // UpdateReceiveTextBox
    #endregion

    #region OnFormLoad
    // -------------------------------------------------------------------------
    /// <summary>
    /// Occurs before a form is displayed for the first time.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    // -------------------------------------------------------------------------
    private void OnFormLoad(object sender, EventArgs e)
    {
      //Height = Convert.ToInt32(properties.mainWindow.size.Height);
      //Width = Convert.ToInt32(properties.mainWindow.size.Width);

    } // OnFormLoad
    #endregion

    #region OnFormClosed
    // -------------------------------------------------------------------------
    /// <summary>
    /// Occurs after the form is closed.
    /// The FormClosed event occurs after the form has been closed by the user
    /// or by the Close method or the Exit method of the Application class. To
    /// prevent a form from closing, handle the FormClosing event and set the
    /// Cancel property of the CancelEventArgs passed to your event handler to
    /// true.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    // -------------------------------------------------------------------------
    private void OnFormClosed(object sender, FormClosedEventArgs e)
    {

    } // OnFormClosed
    #endregion

    #region OnFormClosing
    // -------------------------------------------------------------------------
    /// <summary>
    /// Occurs before the form is closed.
    /// The FormClosing event occurs as the form is being closed. When a form is
    /// closed, it is disposed, releasing all resources associated with the 
    /// form. If you cancel this event, the form remains opened. To cancel the
    /// closure of a form, set the Cancel property of the FormClosingEventArgs
    /// passed to your event handler to true
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    // -------------------------------------------------------------------------
    private void OnFormClosing(object sender, FormClosingEventArgs e)
    {
      //properties.mainWindow.size.Height =  Convert.ToString(Height);
      //properties.mainWindow.size.Width = Convert.ToString(Width);

      //properties.mainWindow.serialPortProperties.SerialPort = serialPortComboBox.Text;
      //properties.mainWindow.serialPortProperties.BaudRate = baudRateComboBox.Text;
      //properties.mainWindow.serialPortProperties.DataBits = dataBitsComboBox.Text;
      //properties.mainWindow.serialPortProperties.Parity = parityComboBox.Text;
      //properties.mainWindow.serialPortProperties.StopBits = stopBitsComboBox.Text;
      //properties.mainWindow.serialPortProperties.Handshake = handshakeComboBox.Text;

      //properties.mainWindow.outTextBox.Font = sendTextBox.Font.Name;
      //properties.mainWindow.outTextBox.ForeColor = sendTextBox.ForeColor.Name;
      //properties.mainWindow.outTextBox.BackColor = sendTextBox.BackColor.Name;

      //properties.mainWindow.inTextBox.Font = receiveTextBox.Font.Name;
      //properties.mainWindow.inTextBox.ForeColor = receiveTextBox.ForeColor.Name;
      //properties.mainWindow.inTextBox.BackColor = receiveTextBox.BackColor.Name;

      // this is benign, you can safely attempt to disconnect from a closed
      // serial port.
      //      commPort.ClosePort();

      e.Cancel = false;
    } // OnFormClosing
    #endregion

    // -------------------------------------------------------------------------
    /// <summary>
    /// Called when the user selects File | Exit from the main menu. 
    /// Application.Exit() will invoke the FormClosing event before actually
    /// closing. If that event returns e.Cancel == true the form will not
    /// actually close but will continue to operate.
    /// </summary>
    /// <param name="sender">The source of the event. </param>
    /// <param name="e">An EventArgs that contains no event data.</param>
    /// <see cref="MainForm_FormClosing"/>
    // -------------------------------------------------------------------------
    private void Exit_OnClick(object sender, EventArgs e)
    {
      Application.Exit();
    }

    #region ctor
    // -------------------------------------------------------------------------
    /// <summary>
    /// Default constructor
    /// </summary>
    // -------------------------------------------------------------------------
    public MainForm()
    {
      InitializeComponent();
      sendTextBox = new SendTextBox();
      sendGroupBox.Controls.Add(sendTextBox);
      commIO = new CommPortIO();
      InitializeGUI();
    } // ctor
    #endregion

    #region instance variables

    // ----- delegates ---------------------------------------------------------
    private delegate void UpdateReceiveTextBoxDelegate(string text);

    // ----- instance variables ------------------------------------------------
    private CommPortIO commIO;
    private SendTextBox sendTextBox;

    #endregion

  } // class MainForm
} // namespace Ceres
