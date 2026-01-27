/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 января 2026 10:40:17
 * Version: 1.0.161
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}