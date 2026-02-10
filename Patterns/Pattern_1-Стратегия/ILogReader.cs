/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 февраля 2026 10:33:20
 * Version: 1.0.175
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}