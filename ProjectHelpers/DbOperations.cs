namespace Quiz1.ProjectHelpers
{
    /// <summary>
    /// Contains basic database operations for MySql.
    /// </summary>
    public class MySql
    {
        public void Post() => ProjectFunctions.Post(DatabaseTypeEnum.MySql);
        public void Get() => ProjectFunctions.Get(DatabaseTypeEnum.MySql);
        public void Put() => ProjectFunctions.Put(DatabaseTypeEnum.MySql);
        public void Delete() => ProjectFunctions.Delete(DatabaseTypeEnum.MySql);

    }

    /// <summary>
    /// Contains basic database operations for MSSql.
    /// </summary>
    public class MSSql
    {
        public void Post() => ProjectFunctions.Post(DatabaseTypeEnum.MSSql);
        public void Get() => ProjectFunctions.Get(DatabaseTypeEnum.MSSql);
        public void Put() => ProjectFunctions.Put(DatabaseTypeEnum.MSSql);
        public void Delete() => ProjectFunctions.Delete(DatabaseTypeEnum.MSSql);
    }

    /// <summary>
    /// Contains basic database operations for Oracle.
    /// </summary>
    public class Oracle
    {
        public void Post() => ProjectFunctions.Post(DatabaseTypeEnum.Oracle);
        public void Get() => ProjectFunctions.Get(DatabaseTypeEnum.Oracle);
        public void Put() => ProjectFunctions.Put(DatabaseTypeEnum.Oracle);
        public void Delete() => ProjectFunctions.Delete(DatabaseTypeEnum.Oracle);
    }

    /// <summary>
    /// Contains basic database operations for PostgreSql.
    /// </summary>
    public class PostgreSql
    {
        public void Post() => ProjectFunctions.Post(DatabaseTypeEnum.PostgreSql);
        public void Get() => ProjectFunctions.Get(DatabaseTypeEnum.PostgreSql);
        public void Put() => ProjectFunctions.Put(DatabaseTypeEnum.PostgreSql);
        public void Delete() => ProjectFunctions.Delete(DatabaseTypeEnum.PostgreSql);
    }

    /// <summary>
    /// Contains basic database operations for Mongo.
    /// </summary>
    public class Mongo
    {
        public void Post() => ProjectFunctions.Post(DatabaseTypeEnum.Mongo);
        public void Get() => ProjectFunctions.Get(DatabaseTypeEnum.Mongo);
        public void Put() => ProjectFunctions.Put(DatabaseTypeEnum.Mongo);
        public void Delete() => ProjectFunctions.Delete(DatabaseTypeEnum.Mongo);
    }

    /// <summary>
    /// Helper class that performs common database operations by type.
    /// </summary>
    public static class ProjectFunctions
    {
        /// <summary>
        /// Helper function that performs Post operations by type.
        /// </summary>
        /// <param name="databaseType"></param>
        public static void Post(DatabaseTypeEnum databaseType)
        {
            try
            {
                switch (databaseType)
                {
                    case DatabaseTypeEnum.MySql:
                        Console.WriteLine(ProjectConstants.Post + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.MySql + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.MSSql:
                        Console.WriteLine(ProjectConstants.Post + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.MSSql + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.Oracle:
                        Console.WriteLine(ProjectConstants.Post + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.Oracle + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.PostgreSql:
                        Console.WriteLine(ProjectConstants.Post + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.PostgreSql + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.Mongo:
                        Console.WriteLine(ProjectConstants.Post + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.Mongo + ProjectConstants.RightBracket);
                        break;
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        /// <summary>
        /// Helper function that performs Get operations by type.
        /// </summary>
        /// <param name="databaseType"></param>
        public static void Get(DatabaseTypeEnum databaseType)
        {
            try
            {
                switch (databaseType)
                {
                    case DatabaseTypeEnum.MySql:
                        Console.WriteLine(ProjectConstants.Get + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.MySql + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.MSSql:
                        Console.WriteLine(ProjectConstants.Get + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.MSSql + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.Oracle:
                        Console.WriteLine(ProjectConstants.Get + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.Oracle + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.PostgreSql:
                        Console.WriteLine(ProjectConstants.Get + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.PostgreSql + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.Mongo:
                        Console.WriteLine(ProjectConstants.Get + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.Mongo + ProjectConstants.RightBracket);
                        break;
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        /// <summary>
        /// Helper function that performs Put operations by type.
        /// </summary>
        /// <param name="databaseType"></param>
        public static void Put(DatabaseTypeEnum databaseType)
        {
            try
            {
                switch (databaseType)
                {
                    case DatabaseTypeEnum.MySql:
                        Console.WriteLine(ProjectConstants.Put + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.MySql + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.MSSql:
                        Console.WriteLine(ProjectConstants.Put + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.MSSql + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.Oracle:
                        Console.WriteLine(ProjectConstants.Put + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.Oracle + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.PostgreSql:
                        Console.WriteLine(ProjectConstants.Put + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.PostgreSql + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.Mongo:
                        Console.WriteLine(ProjectConstants.Put + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.Mongo + ProjectConstants.RightBracket);
                        break;
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        /// <summary>
        /// Helper function that performs Delete operations by type.
        /// </summary>
        /// <param name="databaseType"></param>
        public static void Delete(DatabaseTypeEnum databaseType)
        {
            try
            {
                switch (databaseType)
                {
                    case DatabaseTypeEnum.MySql:
                        Console.WriteLine(ProjectConstants.Delete + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.MySql + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.MSSql:
                        Console.WriteLine(ProjectConstants.Delete + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.MSSql + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.Oracle:
                        Console.WriteLine(ProjectConstants.Delete + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.Oracle + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.PostgreSql:
                        Console.WriteLine(ProjectConstants.Delete + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.PostgreSql + ProjectConstants.RightBracket);
                        break;
                    case DatabaseTypeEnum.Mongo:
                        Console.WriteLine(ProjectConstants.Delete + ProjectConstants.Space + ProjectConstants.LeftBracket + ProjectConstants.Mongo + ProjectConstants.RightBracket);
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
