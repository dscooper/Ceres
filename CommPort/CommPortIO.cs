using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace CommPort 
{
  public class CommPortIO
  {

    #region ctor
    // -------------------------------------------------------------------------
    /// <summary>
    /// Default constructor
    /// </summary>
    // -------------------------------------------------------------------------
    public CommPortIO()
    {
      errors = new CommPortErrors();
      options = new CommPortOptions(errors);
    } // ctor
    #endregion

    public CommPortOptions options;
    public CommPortErrors errors;

  } // class CommPortIO
} // namespace CommPort
