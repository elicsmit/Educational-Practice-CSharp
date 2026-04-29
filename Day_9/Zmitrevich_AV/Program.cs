using System;
using System.IO;
using System.Linq;

namespace Zmitrevich_AV
{
    public class FileManager
    {
        public void CreateAndWrite(string path, string text)
        {
            File.WriteAllText(path, text);
            Console.WriteLine($"Файл создан: {path}");
        }

        public void ReadAndPrint(string path)
        {
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                Console.WriteLine($"Содержимое {Path.GetFileName(path)}: {content}");
            }
        }

        public void SafeDelete(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine($"Файл удален: {path}");
            }
            else
            {
                Console.WriteLine("Ошибка: Файл не существует, удаление невозможно.");
            }
        }

        public void CopyFile(string source, string destination)
        {
            File.Copy(source, destination, true);
            if (File.Exists(destination))
                Console.WriteLine($"Файл скопирован в: {destination}");
        }

        public void MoveFile(string source, string destination)
        {
            if (File.Exists(source))
            {
                File.Move(source, destination);
                Console.WriteLine($"Файл перемещен в: {destination}");
            }
        }

        public void RenameFile(string path, string newName)
        {
            string directory = Path.GetDirectoryName(path);
            string newPath = Path.Combine(directory, newName);
            File.Move(path, newPath);
            Console.WriteLine($"Файл переименован в: {newName}");
        }

        public void DeleteByPattern(string directory, string pattern)
        {
            var files = Directory.GetFiles(directory, pattern);
            foreach (var file in files)
            {
                File.Delete(file);
                Console.WriteLine($"Удален файл по шаблону: {Path.GetFileName(file)}");
            }
        }

        public void ListFiles(string directory)
        {
            Console.WriteLine($"Список файлов в {directory}:");
            var files = Directory.GetFiles(directory);
            foreach (var file in files) Console.WriteLine("- " + Path.GetFileName(file));
        }

        public void SetReadOnly(string path, bool readOnly)
        {
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.IsReadOnly = readOnly;
            Console.WriteLine($"Атрибут ReadOnly для {path} установлен в: {readOnly}");
        }
    }

    public class FileInfoProvider
    {
        public void PrintFileInfo(string path)
        {
            FileInfo info = new FileInfo(path);
            if (info.Exists)
            {
                Console.WriteLine($" Информация о файле: {info.Name} ");
                Console.WriteLine($"Размер: {info.Length} байт");
                Console.WriteLine($"Создан: {info.CreationTime}");
                Console.WriteLine($"Изменен: {info.LastWriteTime}");
            }
        }

        public void CompareFilesSize(string path1, string path2)
        {
            long size1 = new FileInfo(path1).Length;
            long size2 = new FileInfo(path2).Length;

            if (size1 > size2) Console.WriteLine($"{path1} больше чем {path2}");
            else if (size1 < size2) Console.WriteLine($"{path2} больше чем {path1}");
            else Console.WriteLine("Файлы равны по размеру.");
        }

        public void CheckPermissions(string path)
        {
            FileInfo fi = new FileInfo(path);
            Console.WriteLine($"Доступ к {fi.Name}:");
            Console.WriteLine($"- Чтение: {!fi.IsReadOnly}");
            Console.WriteLine($"- Запись: {!fi.IsReadOnly}");
        }
    }

    class Program
    {
        static void Main()
        {
            FileManager fm = new FileManager();
            FileInfoProvider info = new FileInfoProvider();

            string myFile = "zmitrevich.av.ii";
            string copyFile = "copy_zmitrevich.ii";
            string renamedFile = "zmitrevich.av.io";
            string subDir = Path.Combine(Directory.GetCurrentDirectory(), "TestFolder");

            fm.CreateAndWrite(myFile, "Hello World!");
            fm.ReadAndPrint(myFile);

            info.PrintFileInfo(myFile);

            fm.CopyFile(myFile, copyFile);

            info.CompareFilesSize(myFile, copyFile);

            Directory.CreateDirectory(subDir);
            fm.MoveFile(copyFile, Path.Combine(subDir, copyFile));

            fm.RenameFile(myFile, renamedFile);

            fm.ListFiles(Directory.GetCurrentDirectory());

            fm.SetReadOnly(renamedFile, true);
            try { File.WriteAllText(renamedFile, "New data"); }
            catch (UnauthorizedAccessException) { Console.WriteLine("Запись запрещена (ошибка обработана)."); }
            fm.SetReadOnly(renamedFile, false); 

            info.CheckPermissions(renamedFile);

            fm.SafeDelete("non_existent.txt");

            fm.DeleteByPattern(Directory.GetCurrentDirectory(), "*.ii");
            fm.DeleteByPattern(subDir, "*.ii");

            fm.SafeDelete(renamedFile);

            Directory.Delete(subDir, true);
        }
    }
}
