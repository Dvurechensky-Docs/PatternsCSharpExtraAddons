/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 ноября 2025 14:33:00
 * Version: 1.0.102
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}