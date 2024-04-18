using System;
using System.IO;

class Document
{
    public string Content;
    public string FilePath;

    public Document(string filePath)
    {
        FilePath = filePath;
    }

    public void CreateDocument()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        FilePath = Path.Combine(desktopPath, "MyDocument.txt");

        using (StreamWriter writer = File.CreateText(FilePath))
        {
            Console.WriteLine($"Документ создан на рабочем столе в файле 'MyDocument.txt'");
        }
    }

    public void FillDocument()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        if (File.Exists(FilePath))
        {
            Console.WriteLine("Введите содержимое документа:");
            Content = Console.ReadLine();
            File.WriteAllText(FilePath, Content);
            Console.WriteLine($"Документ заполнен текстом");
        }
        else
        {
            Console.WriteLine($"Документ не найден");
        }
    }

    public void CopyDocument()
    {
        if (File.Exists(FilePath))
        {
            string testFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "test");
            string newFilePath = Path.Combine(testFolderPath, "MyDocument.txt");
            if (!File.Exists(newFilePath))
            {
                File.Copy(FilePath, newFilePath, true);
                Console.WriteLine("Документ скопирован в папку 'test'");
            }
            else
            {
                Console.WriteLine("Файл с таким именем уже существует");
            }

        }
        else
        {
            Console.WriteLine("Документ не найден для копирования");
        }
    }

    public void MoveDocument()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string testFolderPath = Path.Combine(desktopPath, "test");

        if (File.Exists(FilePath) && FilePath.StartsWith(testFolderPath))
        {
            string newFilePath = Path.Combine(desktopPath, Path.GetFileName(FilePath));
            if (!File.Exists(newFilePath))
            {
                File.Move(FilePath, newFilePath);
                Console.WriteLine("Документ перемещен на рабочий стол");
                FilePath = newFilePath;
            }
            else
            {
                Console.WriteLine("Файл с таким именем уже существует");
            }
        }
        else if (File.Exists(FilePath) && FilePath.StartsWith(desktopPath))
        {
            string newFilePath = Path.Combine(testFolderPath, Path.GetFileName(FilePath));
            if (!File.Exists(newFilePath))
            {
                File.Move(FilePath, newFilePath);
                Console.WriteLine("Документ перемещен в папку 'test'");
                FilePath = newFilePath;
            }
            else
            {
                Console.WriteLine("Файл с таким именем уже существует");
            }
        }
        else
        {
            Console.WriteLine("Документ не найден для перемещения");
        }
    }

    public void DeleteDocument()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string testFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "test");
        string testFilePath = Path.Combine(testFolderPath, "MyDocument.txt");
        string deskFilePath = Path.Combine(desktopPath, Path.GetFileName(FilePath));
        if (FilePath == null)
        {
            FilePath = deskFilePath;
        }
        else if (File.Exists(testFilePath))
        {
            File.Delete(testFilePath);
            Console.WriteLine("Документ успешно удален");
            FilePath = deskFilePath;
        }else if (File.Exists(deskFilePath))
        {
            File.Delete(deskFilePath);
            Console.WriteLine("Документ успешно удален");
            FilePath = testFilePath;
        }
        else
        {
            Console.WriteLine("Документ не найден для удаления");
        }
    }
}

 class EncryptedDocument : Document
{
    public EncryptedDocument(string filePath) : base(filePath)
    {
    }

    public void EncryptDocument()
    {
        
        if (File.Exists(FilePath))
        {
            string content = File.ReadAllText(FilePath);
            string removeChars = "Этот текст зашифрован";

            content = content.Replace(removeChars, "");
            string ContentEncrypted = "Этот текст зашифрован " + content;

            File.WriteAllText(FilePath, ContentEncrypted);

            Console.WriteLine("Документ зашифрован");
        }else
        {
            Console.WriteLine("Документ не найден для шифрования ");
        }
    }

    public void DecryptDocument()
    {
        
        if (File.Exists(FilePath))
        {
            string content = File.ReadAllText(FilePath);
            string removeChars = "Этот текст зашифрован"; 

            content = content.Replace(removeChars, "");
            string ContentDecrypted = "Этот текст расшифрован" + content;

            File.WriteAllText(FilePath, ContentDecrypted);

            Console.WriteLine("Документ расшифрован");
        }
        else
        {
            Console.WriteLine("Документ не найден для расшифровки");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Определить класс «Документ» с поддержкой операций создания, копирования, перемещения, удаления, наполнения содержимым. Унаследовать от него класс «Зашифрованный документ» с поддержкой функций шифрования и дешифрации содержимого.");
        
        Document doc = null;

        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string folderPath = Path.Combine(desktopPath, "test");
        Directory.CreateDirectory(folderPath);

        while (true)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Создать документ");
            Console.WriteLine("2. Зпаолнить документ текстом");
            Console.WriteLine("3. Копия документа");
            Console.WriteLine("4. Переместить документ");
            Console.WriteLine("5. Удалить документ");
            Console.WriteLine("6. Зашифровать документ");
            Console.WriteLine("7. Расшифровать документ");
            Console.WriteLine("10. Выход");

            int operation;
            if (!int.TryParse(Console.ReadLine(), out operation))
            {
                Console.WriteLine("Неверный выбор. Пожалуйста, выберите один из предложенных вариантов.");
                continue;
            }

            switch (operation)
            {
                case 1:
                    doc = new Document("");
                    doc.CreateDocument();
                    break;
                case 2:
                    if (doc != null)
                    doc.FillDocument();
 
                    break;
                case 3:
                    if (doc != null)
                    {
                        doc.CopyDocument();
                    }
                    else
                    {
                        Console.WriteLine("Документ еще не создан");
                    }
                    break;
                case 4:
                    if (doc != null)
                    {
                        doc.MoveDocument();
                    }
                    else
                    {
                        Console.WriteLine("Документ еще не создан");
                    }
                    break;
                case 5:
                    if (doc != null)
                    {
                        doc.DeleteDocument();
                    }
                    else
                    {
                        Console.WriteLine("Документ еще не создан");
                    }
                    break;
                case 10:
                    return;
                case 6:
                    if (doc == null)
                    {
                        Console.WriteLine("Документ еще не создан");
                        break;
                    }

                    EncryptedDocument encryptedDoc = new EncryptedDocument(doc.FilePath);
                    encryptedDoc.EncryptDocument();
                    doc = encryptedDoc;
                    break;
                case 7:
                    if (doc == null)
                    {
                        Console.WriteLine("Документ еще не создан");
                        break;
                    }
                    if (doc is EncryptedDocument encryptedDocument)
                    {
                        encryptedDocument.DecryptDocument();
                    }
                    else
                    {
                        Console.WriteLine("Этот документ не зашифрован");
                    }
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }
    }
}