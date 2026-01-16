/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 января 2026 06:51:48
 * Version: 1.0.150
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}