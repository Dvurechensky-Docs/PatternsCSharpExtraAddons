/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 февраля 2026 13:23:58
 * Version: 1.0.183
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}