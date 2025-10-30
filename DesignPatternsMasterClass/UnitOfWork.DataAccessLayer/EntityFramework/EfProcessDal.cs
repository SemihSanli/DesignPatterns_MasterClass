using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccessLayer.Abstract;
using UnitOfWork.DataAccessLayer.Concrete;
using UnitOfWork.DataAccessLayer.Repositories;

namespace UnitOfWork.DataAccessLayer.EntityFramework
{
    public class EfProcessDal : GenericRepository<Process>, IProcessDal
    {
        public EfProcessDal(Context context) : base(context)
        {

        }
    }
}
