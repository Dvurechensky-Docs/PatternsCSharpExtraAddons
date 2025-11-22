/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 ноября 2025 10:17:18
 * Version: 1.0.95
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}