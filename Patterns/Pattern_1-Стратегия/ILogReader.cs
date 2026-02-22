/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 февраля 2026 13:31:58
 * Version: 1.0.187
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}