/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 декабря 2025 16:09:50
 * Version: 1.0.124
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}