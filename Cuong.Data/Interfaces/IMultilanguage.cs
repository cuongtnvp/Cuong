using System;
using System.Collections.Generic;
using System.Text;

namespace Cuong.Data.Interfaces
{
   public interface IMultilanguage<T>
    {
        T LanguageId { set; get; }
    }
}
