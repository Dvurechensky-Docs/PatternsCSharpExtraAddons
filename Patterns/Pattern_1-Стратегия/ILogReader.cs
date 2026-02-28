/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 февраля 2026 15:55:30
 * Version: 1.0.193
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}