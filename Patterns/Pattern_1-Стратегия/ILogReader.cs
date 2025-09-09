/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 сентября 2025 11:12:00
 * Version: 1.0.21
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}