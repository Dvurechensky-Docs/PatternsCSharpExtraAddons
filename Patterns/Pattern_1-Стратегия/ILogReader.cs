/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 сентября 2025 14:18:29
 * Version: 1.0.39
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}