﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker document = new DocumentWorker();
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();
            Console.WriteLine(new string('-', 50));
            Console.Write("Введите ключ: ");
            var prodDocument = document.AcivateProduct(Console.ReadLine());
            prodDocument.OpenDocument();
            prodDocument.EditDocument();
            prodDocument.SaveDocument();
            Console.ReadKey();
        }
    }
}


//Требуется:
//Создайте класс DocumentWorker.
//В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
//В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт",
//"Редактирование документа доступно в версии Про", "Сохранение документа доступно в
//версии Про".
//Создайте производный класс ProDocumentWorker.
//Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
//"Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных
//форматах доступно в версии Эксперт".
//Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
//Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран
//"Документ сохранен в новом формате".
//В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
//Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается
//экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен
//создаться экземпляр соответствующей версии класса, приведенный к базовому - DocumentWorker.
