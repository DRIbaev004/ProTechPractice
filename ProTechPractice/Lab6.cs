using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProTechPractice
{
    internal class Lab6 : Lab5
    {
        // метод для удаления символа 
        public static void DeleteSymbol()
        {
            if (flag)
            {
                int range = GetRandomNum(0, correctedLine.Length);
                correctedLine = correctedLine.Remove(range, 1);
                Console.WriteLine(correctedLine);
            }
            else 
            {
                Console.WriteLine("Введены неверные символы:");
            }
            flag = true;
        }
        // генерация случайного числа
        private static int GetRandomNum(int min, int max)
        {
            int randomNum;
            try
            {
                // URL для получения случайного числа через удалённый API
                string url = $"https://www.random.org/integers/?num=1&min={min}&max={max - 1}&col=1&base=10&format=plain&rnd=new";
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = client.GetAsync(url).Result; 
                    randomNum = int.Parse(response.Content.ReadAsStringAsync().Result); 
                    Console.WriteLine($"\nСлучайное число {randomNum}, успешно получено через API.");
                }
            }
            catch (Exception ex)
            {
                // Если возникло исключение при использовании удалённого API, выводим сообщение об ошибке
                Console.WriteLine($"\nНе удалось получить случайное число через удалённый API, число будет получено средствами .NET.");
                Random rnd = new Random(); // Генерируем случайное число средствами .NET
                randomNum = rnd.Next(min, max);
                Console.WriteLine($"Случайное число {randomNum}");
            }
            // Возвращаем сгенерированное случайное число
            return randomNum;
        }
    }
}
