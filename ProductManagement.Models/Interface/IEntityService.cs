using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Models.Interface
{
    public interface IEntityService
    {
        void Add();
        void GetAll();
        void Update();
        void Delete();
    }
}


