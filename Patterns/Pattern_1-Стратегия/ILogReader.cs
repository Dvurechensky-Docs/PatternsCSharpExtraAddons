/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 января 2026 11:24:28
 * Version: 1.0.142
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}