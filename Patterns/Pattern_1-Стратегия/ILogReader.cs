/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 03:39:52
 * Version: 1.0.4
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}