using System;
using System.Net.Security;
using System.Runtime.InteropServices;
namespace Tasks_from_file2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Выведите на экран информацию о каждом типе данных в виде:
            Тип данных – максимальное значение – минимальное значение*/
            Console.WriteLine("Задание 1");
            byte byteMin = byte.MinValue;
            byte byteMax = byte.MaxValue;
            Console.WriteLine($"Тип данных - byte - максимальное значение - {byteMax} - минимальное значение - {byteMin}");
            sbyte sbyteMin = sbyte.MinValue;
            sbyte sbyteMax = sbyte.MaxValue;
            Console.WriteLine($"Тип данных - sbyte - максимальное значение - {sbyteMax} - минимальное значение - {sbyteMin}");
            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            Console.WriteLine($"Тип данных - short - максимальное значение - {sbyteMax} - минимальное значение - {sbyteMin}");
            ushort ushortMin = ushort.MinValue;
            ushort ushortMax = ushort.MaxValue;
            Console.WriteLine($"Тип данных - ushort - максимальное значение - {ushortMax} - минимальное значение - {ushortMin}");
            int intMin = int.MinValue;
            int intMax = int.MaxValue;
            Console.WriteLine($"Тип данных - int - максимальное значение - {intMax} - минимальное значение - {intMin}");
            uint uintMin = uint.MinValue;
            uint uintMax = uint.MaxValue;
            Console.WriteLine($"Тип данных - uint - максимальное значение - {uintMin} - минимальнре значение - {uintMax}");
            ulong ulongMin = ulong.MinValue;
            ulong ulongMax = ulong.MaxValue;
            Console.WriteLine($"Тип данных - ulong - максимальное значение - {ulongMax} - минимальное значение - {ulongMin}");
            float floatMin = float.MinValue;
            float floatMax = float.MaxValue;
            Console.WriteLine($"Тип данных - float - максимальное значение - {floatMax} - минимальное значение - {floatMin}");
            double doubleMin = double.MinValue;
            double doubleMax = double.MaxValue;
            Console.WriteLine($"Тип данных - double - максимальное значение - {doubleMax} - минимальное значение - {doubleMin}");
            char charMin = char.MinValue;
            char charMax = char.MaxValue;
            Console.WriteLine($"Тип данных - char - максимальное значение - {charMax} - минимальное значение - {charMin}");
            decimal decimalMin = decimal.MinValue;
            decimal decimalMax = decimal.MaxValue;
            Console.WriteLine($"Тип данных - decimal - максимальное значение - {decimalMax} - минимальное значение  - {decimalMin}");
            Console.WriteLine(" ");
            /*2. Напишите программу, в которой принимаются данные пользователя в виде имени,
            города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
            переменной, а затем распечатайте всю информацию в правильном формате.*/
            Console.WriteLine("Задание 2");
            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Ваш город: ");
            string town = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Ваш PIN-код: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вас зовут: {name} , Вам: {age} года/лет, Вы живёте в городе: {town} , Ваш PIN-код: {pin} ");
            Console.WriteLine(" ");
            /*3. Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
            строчные.*/
            Console.WriteLine("Задание 3");
            string sentence;
            string then;
            Console.WriteLine("Введите строку, используя заглавные и строчные буквы: ");
            sentence = Console.ReadLine();
            then = "";
            foreach (char word in sentence)
            {
                if (char.IsLower(word))
                    then += char.ToUpper(word);
                if (char.IsUpper(word))
                    then += char.ToLower(word);
            }
            Console.WriteLine($"{then}");
            /*4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести
            на экран.*/
            Console.WriteLine("Задание 4");
            string question = "How are you doing and where are you now";
            string substring = "you";
            int result = question.IndexOf(substring);
            Console.WriteLine(result);
            Console.WriteLine(" ");
            /*5. Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам
          нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
          покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),
          скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка
          обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы
          сэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов
          стерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут
          целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.*/
            Console.WriteLine("Задание 5");
            int normPrice;
            Console.Write("Введите стандартную стоимость (целое число): ");
            normPrice = Convert.ToInt32(Console.ReadLine());
            int salePrice;
            Console.Write("Введите  скидку в Duty Free (целое число без процентного знака): ");
            salePrice = Convert.ToInt32(Console.ReadLine());
            int holidayPrice;
            Console.Write("Введите стоимость отпуска (целое число): ");
            holidayPrice = Convert.ToInt32(Console.ReadLine());
            int answer = holidayPrice / (normPrice * salePrice / 100);
            double answer2 = answer;
            double answer3 = Math.Floor(answer2);
            Console.WriteLine($"Количество бутылок равняется: {answer3}");
        







        }



    }
}

