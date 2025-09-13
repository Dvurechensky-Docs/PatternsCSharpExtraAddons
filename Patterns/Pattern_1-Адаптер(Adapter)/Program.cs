﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 сентября 2025 06:51:53
 * Version: 1.0.25
 */

/*
 * СТРУКТУРНЫЕ ПАТТЕРНЫ
 * 
 * Глава_12: Адаптер (Adapter)
 * 
 * - преобразует интерфейс одного класса в интерфейс другого, который 
 *   ожидают клиенты. Адаптер делает возможной совместную работу 
 *   классов с несовместимыми интерфейсами
 */

class Motorcycle { }

/// <summary>
/// Что адаптируем
/// </summary>
class Voskhod : Motorcycle 
{
    public void Sound() => Console.WriteLine("DRDRDR");
}

/// <summary>
/// Цель на которую нужно ориентироваться при адаптации
/// </summary>
interface Isport
{
    void MakeNoise();
}

/// <summary>
/// Пример готового объекта aдаптированного под цель
/// </summary>
class Honda : Motorcycle, Isport
{
    public void MakeNoise() => Console.WriteLine("hooondaaa");
}

/// <summary>
/// Адаптер
/// Адаптирует простой класс под цель
/// </summary>
class TuningVoskhod : Isport
{
    Voskhod moto;
    public TuningVoskhod(Voskhod moto) => this.moto = moto;
    public void MakeNoise()
    {
        Console.WriteLine("trsh");
        moto.Sound();
    }
}

class Program
{
    public static void Main(string[] args)
    { 
        var tun = new TuningVoskhod(new Voskhod());
        tun.MakeNoise();
    }
}