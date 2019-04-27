using Cuong.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cuong.Data.Interfaces
{
  public  interface ISwitchable
    {
        Status Status { set; get; }
    }
}
