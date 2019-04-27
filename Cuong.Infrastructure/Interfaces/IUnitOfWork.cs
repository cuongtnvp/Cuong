using System;
using System.Collections.Generic;
using System.Text;

namespace Cuong.Infrastructure.Interfaces
{
   public interface IUnitOfWork:IDisposable
    {
        /// <summary>
        /// Call Save Change for DbContext
        /// </summary>
        void Commit();
    }
}
