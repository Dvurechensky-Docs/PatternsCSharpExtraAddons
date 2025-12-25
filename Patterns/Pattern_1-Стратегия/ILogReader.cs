/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 декабря 2025 09:30:33
 * Version: 1.0.128
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}