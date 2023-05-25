using Quiz1.ProjectHelpers;

namespace Quiz1
{
    public class Strategy
    {
        public void Execute(int provider)
        {
            try
            {
                switch (provider)
                {
                    case (int)DatabaseTypeEnum.MySql:
                        #region Database Operation
                        MySql mysql = new MySql();
                        mysql.Post();
                        mysql.Get();
                        mysql.Put();
                        mysql.Delete();
                        #endregion
                        break;
                    case (int)DatabaseTypeEnum.MSSql:
                        #region Database Operation
                        MSSql mssql = new MSSql();
                        mssql.Post();
                        mssql.Get();
                        mssql.Put();
                        mssql.Delete();
                        #endregion
                        break;
                    case (int)DatabaseTypeEnum.Oracle:
                        #region Database Operation
                        Oracle oracle = new Oracle();
                        oracle.Post();
                        oracle.Get();
                        oracle.Put();
                        oracle.Delete();
                        #endregion
                        break;
                    case (int)DatabaseTypeEnum.PostgreSql:
                        #region Database Operation
                        PostgreSql postgresql = new PostgreSql();
                        postgresql.Post();
                        postgresql.Get();
                        postgresql.Put();
                        postgresql.Delete();
                        #endregion
                        break;
                    case (int)DatabaseTypeEnum.Mongo:
                        #region Database Operation
                        Mongo mongo = new Mongo();
                        mongo.Post();
                        mongo.Get();
                        mongo.Put();
                        mongo.Delete();
                        #endregion
                        break;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }
    }
}
