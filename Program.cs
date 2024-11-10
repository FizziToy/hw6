using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

internal class Program
{
    private static async Task Main(string[] args)
    {
        // Вказуємо відносний шлях до файлу JSON
        string path = @"JsonTask.json"; // Змініть на правильний шлях, якщо потрібно

        // Відкриваємо файл і десеріалізуємо в список книг
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            var books = await JsonSerializer.DeserializeAsync<List<Book>>(fs);

            // Виводимо інформацію про кожну книгу
            foreach (var book in books)
            {
                Console.WriteLine($"Назва: {book.Title}, Видавництво: {book.PublishingHouse.Name}, Адреса: {book.PublishingHouse.Adress}");
            }
        }
    }
}
