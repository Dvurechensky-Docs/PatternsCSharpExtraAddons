/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 февраля 2026 13:13:20
 * Version: 1.0.185
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}