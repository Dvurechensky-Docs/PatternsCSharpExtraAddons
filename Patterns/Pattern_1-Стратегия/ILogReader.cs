/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 января 2026 10:23:45
 * Version: 1.0.141
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}