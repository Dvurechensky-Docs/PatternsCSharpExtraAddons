/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 сентября 2025 15:29:56
 * Version: 1.0.24
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}