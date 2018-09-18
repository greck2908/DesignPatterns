﻿using System;

namespace FactoryMethod
{
    /// <summary>
    /// Паттерн фабричный метод
    /// это паттерн, который определяет интерфейс для создания объектов некоторого класса, но непосредственное решение о том,
    /// объект какого класса создавать происходит в подклассах. То есть паттерн предполагает, что базовый класс делегирует
    /// создание объектов классам-наследникам.
    /// Когда надо применять паттерн?
    /// - Когда заранее неизвестно, объекты каких типов необходимо создавать
    /// - Когда система должна быть независимой от процесса создания новых объектов и расширяемой:
    /// в нее можно легко вводить новые классы, объекты которых система должна создавать.
    /// - Когда создание новых объектов необходимо делегировать из базового класса классам наследникам
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Фабричный метод";
            // Выбираем строительную организцию
            Developer developer = new PanelDeveloper("ООО Кирпич - Строй");

            // Строим кирпичный домик при помощи фабричного метода
            House brickHouse = developer.Create();

            developer = new WoodDeveloper("Частный зстройщик");

            House woodHouse = developer.Create();

            Console.ReadKey();
        }

        abstract class House
        {

        }

        // Строительная компания
        abstract class Developer
        {
            public string Name { get; set; }

            public Developer(string name)
            {
                Name = name;
            }

            public abstract House Create();
        }

        /// <summary>
        /// Классы строительных компаний
        /// </summary>
        /// <param name="args"></param>
        class PanelDeveloper : Developer
        {
            public PanelDeveloper(string name) : base(name)
            {
            }

            public override House Create()
            {
                return new PanelHouse();
            }
        }

        class WoodDeveloper : Developer
        {
            public WoodDeveloper(string name) : base(name)
            {
            }

            public override House Create()
            {
                return new WoodHouse();
            }
        }

        /// <summary>
        /// Классы видов домов
        /// </summary>
        /// <param name="args"></param>
        class PanelHouse : House
        {
            public PanelHouse()
            {
                Console.WriteLine("Панельный дом построен");
            }
        }

        class WoodHouse : House
        {
            public WoodHouse()
            {
                Console.WriteLine("Деревянный дом построен");
            }
        }

    }
}
