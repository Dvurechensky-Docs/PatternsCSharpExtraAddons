/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 сентября 2025 11:06:18
 * Version: 1.0.13
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}