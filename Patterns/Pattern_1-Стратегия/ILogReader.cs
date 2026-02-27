/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 февраля 2026 09:42:40
 * Version: 1.0.192
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}