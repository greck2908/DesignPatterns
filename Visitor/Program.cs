﻿using System;

namespace Visitor
{
    /// <summary>
    /// Паттерн Посетитель (Visitor) позволяет определить операцию для объектов других классов без изменения этих классов.
    /// При использовании паттерна Посетитель определяются две иерархии классов: одна для элементов, для которых надо определить новую операцию,
    /// и вторая иерархия для посетителей, описывающих данную операцию.
    /// Когда использовать данный паттерн?
    /// - Когда имеется много объектов разнородных классов с разными интерфейсами, и требуется выполнить ряд операций над каждым из этих объектов
    /// - Когда классам необходимо добавить одинаковый набор операций без изменения этих классов
    /// - Когда часто добавляются новые операции к классам, при этом общая структура классов стабильна и практически не изменяется
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Visitor";

            var struture = new Bank();
            struture.Add(new Person{Name = "Вася пупкин", Number = "812233652"});
            struture.Add(new Company() {Name = "Microsoft", RegNumber = "ewuir85669", Number = "322567268" });

            struture.Accept(new HtmlVisitor());
            struture.Accept(new XmlVisitor());
            
            Console.ReadKey();
        }
    }
}
