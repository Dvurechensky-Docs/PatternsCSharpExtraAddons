/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 ноября 2025 08:15:47
 * Version: 1.0.92
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}