/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 сентября 2025 14:29:56
 * Version: 1.0.22
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}