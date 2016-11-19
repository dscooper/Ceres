using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ceres
{
  public class SendTextBox : TextBox
  {

    // Handling the keyboard inputs
    //  Key events occur in the following order:
    //  1. KeyDown
    //  2. KeyPress
    //  3. KeyUp
    //
    //  To handle keyboard events only at the form level and not enable other
    //  controls to receive keyboard events, set the KeyPressEventArgs.Handled
    //  property in your form's KeyPress event-handling method to true. Certain
    //  keys, such as the TAB, RETURN, ESC, and arrow keys are handled by
    //  controls automatically. To have these keys raise the KeyDown event, you
    //  must override the IsInputKey method in each control on your form. The
    //  code for the override of the IsInputKey would need to determine if one
    //  of the special keys is pressed and return a value of true. Instead of
    //  overriding the IsInputKey method, you can handle the PreviewKeyDown
    //  event and set the IsInputKeyproperty to true. For a code example, 
    //  see the PreviewKeyDown event.
    //

    // -------------------------------------------------------------------------
    /// <summary>
    /// Raises the KeyDown event.
    /// </summary>
    /// <param name="e">A KeyEventArgs that contains the event data.</param>
    // -------------------------------------------------------------------------
    protected override void OnKeyDown(KeyEventArgs e)
    {
      base.OnKeyDown(e);
    }

    // -------------------------------------------------------------------------
    /// <summary>
    /// Raises the KeyPress event.
    /// Note : This method is called multiple times if the user holds a key.
    /// </summary>
    /// <param name="e">A KeyPressEventArgs that contains the event data.</param>
    // -------------------------------------------------------------------------
    protected override void OnKeyPress(KeyPressEventArgs e)
    {
      base.OnKeyPress(e);
    }

    // -------------------------------------------------------------------------
    /// <summary>
    /// Raises the KeyUp event.
    /// </summary>
    /// <param name="e">A KeyEventArgs that contains the event data.</param>
    // -------------------------------------------------------------------------
    protected override void OnKeyUp(KeyEventArgs e)
    {
      base.OnKeyUp(e);
    }

    #region ctor
    // -------------------------------------------------------------------------
    /// <summary>
    /// Default constructor
    /// </summary>
    // -------------------------------------------------------------------------
    public SendTextBox()
    {
      Dock = DockStyle.Fill;
      Location = new System.Drawing.Point(3, 16);
      Multiline = true;
      Name = "sendTextBox";
      ScrollBars = System.Windows.Forms.ScrollBars.Both;
      Size = new System.Drawing.Size(691, 213);
      TabIndex = 0;
      WordWrap = false;
    } // ctor
    #endregion

  } // class SendTextBox
} // namespace Ceres
