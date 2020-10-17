using System;

namespace Facade.VSFacade
{
    /// <summary>
    /// Текстовый редактор
    /// </summary>
    class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Написание кода на ЯП С#");
        }

        public void SaveCode()
        {
            Console.WriteLine("Сохранение кода, написанного на ЯП С#");
        }
    }
}
