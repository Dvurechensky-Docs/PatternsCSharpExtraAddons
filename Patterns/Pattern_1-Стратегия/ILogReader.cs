/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 февраля 2026 06:51:50
 * Version: 1.0.171
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}