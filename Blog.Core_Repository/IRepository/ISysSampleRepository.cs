using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using IRepository.BASE;
using Model;


namespace IRepository
{
   public interface ISysSampleRepository: IBaseRepository<SysSample>
    {
        int Sum(int i,int j);

    }
}
