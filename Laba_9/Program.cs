using System.Security.Cryptography;

// Класс Документ
public class Document
{
    // Поле для хранения содержимого документа
    protected string content;

    // Конструктор для создания нового документа
    public Document(string content)
    {
        this.content = content;
    }

    // Метод для копирования содержимого другого документа
    public void CopyFrom(Document document)
    {
        this.content = document.Content;
    }

    // Метод для перемещения содержимого другого документа
    public void MoveFrom(Document document)
    {
        // Здесь должен быть код для перемещения содержимого, но новичок может
        // просто скопировать содержимое и очистить исходный объект
        CopyFrom(document);
        document.Clear();
    }

    // Метод для удаления содержимого текущего документа
    public void Clear()
    {
        this.content = null;
    }

    // Метод для получения содержимого документа
    public string Content
    {
        get => content;
        set => content = value;
    }
}

// Класс Зашифрованный документ
public class EncryptedDocument : Document
{
    // Поле для хранения ключа шифрования
    private byte[] key;

    // Конструктор для создания зашифрованного документа
    public EncryptedDocument(string content, byte[] key) : base(content)
    {
        this.key = key;
    }

    // Метод для шифрования содержимого документа
    public void Encrypt()
    {
        // Здесь должен быть код для шифрования содержимого, но новичок может
        // просто записать его в файл, используя ключ шифрования
        SaveToFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Encrypted_{DateTime.Now:yyyyMMdd_HHmmss}.txt"), key);
    }

    // Метод для дешифрации содержимого документа
    public void Decrypt()
    {
        // Здесь должен быть код для дешифрации содержимого, но новичок может
        // просто считать содержимое из файла, используя ключ шифрования
        LoadFromFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Encrypted_{DateTime.Now:yyyyMMdd_HHmmss}.txt"), key);
    }

    // Методы для сохранения и загрузки содержимого из файла
    private void SaveToFile(string path, byte[] key)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            using (ICryptoTransform encryptor = aes.CreateEncryptor())
            using (MemoryStream ms = new MemoryStream())
            using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
            using (StreamWriter sw = new StreamWriter(cs))
            {
                sw.Write(this.content);
                sw.Flush();
                cs.FlushFinalBlock();
                File.WriteAllBytes(path, ms.ToArray());
            }
        }
    }

    private void LoadFromFile(string path, byte[] key)
    {
        if (!File.Exists(path))
        {
            throw new FileNotFoundException("Файл не найден", path);
        }

        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            using (ICryptoTransform decryptor = aes.CreateDecryptor())
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (CryptoStream cs = new CryptoStream(fs, decryptor, CryptoStreamMode.Read))
            using (StreamReader sr = new StreamReader(cs))
            {
                this.content = sr.ReadToEnd();
            }
        }
    }
}

