/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 января 2026 06:51:55
 * Version: 1.0.140
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}