/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 ноября 2025 12:21:57
 * Version: 1.0.93
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}