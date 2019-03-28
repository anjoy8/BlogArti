using System;
using System.Collections.Generic;
using System.Text;
using IServices;
using IRepository;
using Services.BASE;
using Model;
using System.Linq.Expressions;

namespace Services
{
    public class SysSampleServices : BaseServices<SysSample>, ISysSampleServices
    {
        //普通的仓储例子
        ISysSampleRepository dal;

        public SysSampleServices(ISysSampleRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }

 

        public int Sum(int i, int j)
        {
            return dal.Sum(i, j);
        }
    }
}
