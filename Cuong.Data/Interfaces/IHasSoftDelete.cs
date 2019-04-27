using System;
using System.Collections.Generic;
using System.Text;

namespace Cuong.Data.Interfaces
{
  public  interface IHasSoftDelete
    {
        bool IsDeleted { set; get; }
    }
}
