using System;

namespace Facade.VSFacade
{
    /// <summary>
    /// Общеязыковая среда выполнения - CLR
    /// </summary>
    class CLR
    {
        public void Execute()
        {
            Console.WriteLine("Выполнение приложения");
        }

        public void Finish()
        {
            Console.WriteLine("Завершение работы приложения");
        }
    }
}
