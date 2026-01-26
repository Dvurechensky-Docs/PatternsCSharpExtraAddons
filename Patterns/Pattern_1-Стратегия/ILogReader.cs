/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 января 2026 06:51:49
 * Version: 1.0.160
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}