/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 декабря 2025 13:31:34
 * Version: 1.0.129
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}