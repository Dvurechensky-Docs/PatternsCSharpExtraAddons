/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 января 2026 17:09:11
 * Version: 1.0.145
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}