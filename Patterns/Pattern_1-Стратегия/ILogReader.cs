/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 ноября 2025 09:08:14
 * Version: 1.0.101
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}