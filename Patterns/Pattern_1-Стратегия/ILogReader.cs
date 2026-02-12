/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 февраля 2026 10:32:57
 * Version: 1.0.177
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}