/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 февраля 2026 09:14:09
 * Version: 1.0.176
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}