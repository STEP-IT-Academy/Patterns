using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Реализация паттерна Composite представлена на примере файловой системы ОС Windows 
             * Мы можем создать разную файловую систему, которая будет стандратной для нашей ОС, к примеру, 
             * это может быть система FAT, HPFS, NTFS.
             * Далее создается директория, в которой можно создавать том(ы). 
             * Далее на логическом диске можно создавать папки и файлы. И т.д.
             */

            // Для примера задаем(создаем) файловую систему по умолчанию для нашего ПК. Пусть это будет система типа FAT.
            Component FAT_FileSystem = new FileSystem("Файловая система типа FAT");

            // Создаем том
            Component diskC = new Directory("Диск С");

            // Создаем папку
            Component folder1 = new Folder("Папка \"Паттерны проектирования\"");

            // Создаем файлы
            Component file1 = new File("\"Вводная лекция.docx \"", 2);
            Component file2 = new File("\"Паттерн Composite.docx \"", 5);

            // Добавлем в папку "folder1" файл "file1"
            folder1.Add(file1);

            // Добавлем на логический диск "diskC" папку "folder1"
            diskC.Add(folder1);

            // Добавлеям на логический диск "diskC" файл "file2"
            diskC.Add(file2);

            // Добавляем в файловую систему "FAT" том "diskC"
            FAT_FileSystem.Add(diskC);

            // Вывод на консоль занимаемого места
            FAT_FileSystem.ShowSize();
            diskC.ShowSize();
            folder1.ShowSize();
            file1.ShowSize();
            file2.ShowSize();

            // Чтобы убдеиться в правильной иерархии и размещении файлов и диска, посчтиаем занимаемый ими(файлами и дисками) объем (в мб.)
            Console.WriteLine($"Общий размер {FAT_FileSystem.Name} составляет {FAT_FileSystem.CalculateTotalSize()} мб.");
            Console.ReadKey();
        }
    }
}