using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace TASK6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            string json = File.ReadAllText(@"C:\Users\mbezv\source\repos\TASK6\TASK6\book.json", Encoding.UTF8);

            List<Book> books = JsonSerializer.Deserialize<List<Book>>(json);

            foreach (var book in books)
            {
                Console.WriteLine($"Назва: {book.Name}\nВидавництво: {book.PublishingHouse.Name}\nАдреса: {book.PublishingHouse.Adress}\n");
            }

            var options = new JsonSerializerOptions { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,  WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(books, options);

            Console.WriteLine(jsonString);
        }
    }



}