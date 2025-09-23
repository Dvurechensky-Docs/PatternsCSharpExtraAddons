/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 сентября 2025 17:15:25
 * Version: 1.0.35
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}