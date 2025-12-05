/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 декабря 2025 14:56:18
 * Version: 1.0.108
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}