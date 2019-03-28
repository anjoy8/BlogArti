using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using SqlSugar;
using IRepository;
//using IRepository.BASE;
using Model;
using Repository.sugar;
using Repository.BASE;


namespace Repository
{
    public class SysSampleRepository : BaseRepository<SysSample>, ISysSampleRepository
    {

        //private DbContext context;
        //private SqlSugarClient db;
        //private SimpleClient<SysSample> entityDB;

        //internal SqlSugarClient Db
        //{
        //    get { return db; }
        //    private set { db = value; }
        //}
        //public DbContext Context
        //{
        //    get { return context; }
        //    set { context = value; }
        //}
        //public SysSampleRepository()
        //{
        //    DbContext.Init(BaseDBConfig.ConnectionString);
        //    context = DbContext.GetDbContext();
        //    db = context.Db;
        //    entityDB = context.GetEntityDB<SysSample>(db);
        //}
        //public int Add(SysSample model)
        //{
        //    //返回的i是long类型,这里你可以根据你的业务需要进行处理
        //    var i = db.Insertable(model).ExecuteReturnBigIdentity();
        //    //return i.ObjToInt();
        //    return Convert.ToInt32(i);
        //}

        //public bool Delete(SysSample model)
        //{
        //    var i = db.Deleteable(model).ExecuteCommand();
        //    return i > 0;
        //}

        //public List<SysSample> Query(Expression<Func<SysSample, bool>> whereExpression)
        //{
        //    return entityDB.GetList(whereExpression);

        //}

        public int Sum(int i, int j)
        {
            return i + j;
        }


    }
}
