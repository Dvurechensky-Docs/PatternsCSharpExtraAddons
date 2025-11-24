/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 ноября 2025 12:26:23
 * Version: 1.0.97
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}