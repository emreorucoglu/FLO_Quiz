using Quiz1;
using Quiz1.ProjectHelpers;

namespace Flo.Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Strategy strategy = new Strategy();
                strategy.Execute((int)DatabaseTypeEnum.MySql);
                strategy.Execute((int)DatabaseTypeEnum.MSSql);
                strategy.Execute((int)DatabaseTypeEnum.Oracle);
                strategy.Execute((int)DatabaseTypeEnum.PostgreSql);
                strategy.Execute((int)DatabaseTypeEnum.Mongo);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
