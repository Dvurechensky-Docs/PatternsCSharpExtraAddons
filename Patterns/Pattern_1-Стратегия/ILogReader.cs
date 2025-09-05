/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 сентября 2025 10:10:00
 * Version: 1.0.17
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}