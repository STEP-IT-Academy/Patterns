using Facade.VSFacade;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Применение паттерна Facade на простом примере IDE Microsoft Visual Studio
             * В данном случае IDE MVS2019 скрывает всю сложность процесса компляции и запуска приложения, позволяя нам, нажав одну лишь конпку,
             * получить готовое приложение.
             */

            TextEditor textEditor = new TextEditor();
            Compiler compiler = new Compiler();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiler, clr);

            Programmer programmer = new Programmer();
            programmer.CreateConsoleApp(ide);

            Console.ReadKey();
        }
    }
}
