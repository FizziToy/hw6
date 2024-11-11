using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

internal class Program
{
    private static async Task Main(string[] args)
    {
        string path = @"JsonTask.json"; 
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            var books = await JsonSerializer.DeserializeAsync<List<Book>>(fs);

            foreach (var book in books)
            {
                Console.WriteLine($"Назва: {book.Title}, Видавництво: {book.PublishingHouse.Name}, Адреса: {book.PublishingHouse.Adress}");
            }
        }
    }
}
