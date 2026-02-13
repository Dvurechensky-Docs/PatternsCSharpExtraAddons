/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 февраля 2026 11:50:08
 * Version: 1.0.178
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}