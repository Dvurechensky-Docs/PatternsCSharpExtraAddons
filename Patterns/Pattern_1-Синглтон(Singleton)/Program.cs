﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2025 14:25:58
 * Version: 1.0.63
 */

/*
 * ПОРОЖДАЮЩИЕ ПАТТЕРНЫ
 * 
 * Глава_8: Сиглтон, Одиночка (Singleton)
 * 
 * - гантирует, что у класса есть только один экземпляр, 
 *   и предоставляет глобальную точку доступа к нему
 */
class Singleton
{
    private Singleton()
    {
        Data = 28;
        MoreData = 90;
    }

    public int Data { get; set; }
    public int MoreData { get; set; }
   
    /// <summary>
    /// Отложенный синглтон (ленивый одиночка)
    /// </summary>
    static Lazy<Singleton> uniqueInstance = new Lazy<Singleton>(() => new Singleton());
    public static Singleton Instance => uniqueInstance.Value;
}

class Program
{
    public static void Main()
    {
        Console.WriteLine(Singleton.Instance.Data);
    }
}