using System;
using System.Runtime.InteropServices;

namespace Tumakov_lab3
{
    enum bankAccounts
    {
        Текущий,
        Сберегательный
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Упражнение 3.1 Создать перечислимый тип данных отображающий
           виды банковского счета (текущий и сберегательный). Создать переменную типа
           перечисления, присвоить ей значение и вывести это значение на печать.*/
            Console.WriteLine("Упражнение 3.1");
            bankAccounts yourAccountType = bankAccounts.Текущий;
            Console.WriteLine("Вид банковского счёта - {0}", yourAccountType, (int)yourAccountType);
            Console.WriteLine(" ");
            /*Упражнение 3.2 Создать структуру данных, которая хранит информацию
            о банковском счете – его номер, тип и баланс. Создать переменную такого типа,
            заполнить структуру значениями и напечатать результат.*/
            Console.WriteLine("Упражнение 3.2");
            BankAccount account = new BankAccount();
            account.number = 56927;
            account.type = "Сберегательный счёт";
            account.balance = 4500000;
            account.Print();
            SecondMain();
        }
        /// <summary>
        /// Структура данных, хранящая информацию о банковском счёте
        /// </summary>
        struct BankAccount
        {
            /// <summary>
            /// Выводит информацию о номере банковского счёта
            /// </summary>
            public int number;
            /// <summary>
            /// Выводит информацию о типе банковкого счёта
            /// </summary>
            public string type;
            /// <summary>
            /// Выводит информацию о балнсе банковского счёта
            /// </summary>
            public int balance;
            public void Print()
            {


                Console.WriteLine($"Номер счёта:{number}, тип счёта: {type} , баланс: {balance}");
                Console.WriteLine(" ");
                Console.WriteLine("Домашнее задание 3.1");
            }
        }
        /*Домашнее задание 3.1 Создать перечислимый тип ВУЗ {КГУ, КАИ,
        КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ. Заполнить
        структуру данными и распечатать.*/
        enum ВУЗ
        {
            КГУ,
            КАИ,
            КХТИ
        }
            static void SecondMain()
            {
                Worker worker = new Worker();
                worker.workerName1 = "Иванов Александр Павлович";
                worker.university1 = "КГУ";
                worker.workerName2 = "Королёва Ольга Юрьевна";
                worker.university2 = "КАИ";
                worker.workerName3 = "Зуева Луиза Амировна";
                worker.university3 = "КХТИ";
                worker.Print();

            }
        /// <summary>
        /// Структура данных, хранящая информацию о работниках ВУЗов
        /// </summary>
            struct Worker
            {
            /// <summary>
            /// Выводит информацию об имени первого работника
            /// </summary>
                public string workerName1;
            /// <summary>
            /// Выводит информацию об имени второго работника
            /// </summary>
                public string workerName2;
            /// <summary>
            /// Выводит информацию об имени третьего работника
            /// </summary>
                public string workerName3;
            /// <summary>
            /// Выводит название первого ВУЗа
            /// </summary>
                public string university1;
            /// <summary>
            /// ВЫводит название второго ВУЗа
            /// </summary>
                public string university2;
            /// <summary>
            /// Выводит название третьего ВУЗа
            /// </summary>
                public string university3;
                public void Print()
                {
                    Console.WriteLine($"Имя работника:{workerName1},  ВУЗ: {university1}");
                    Console.WriteLine($"Имя работника:{workerName2},  ВУЗ: {university2}");
                    Console.WriteLine($"Имя работника: {workerName3},  ВУЗ: {university3}");
                }
            }










        }

    }



