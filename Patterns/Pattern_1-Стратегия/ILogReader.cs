/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 февраля 2026 07:42:02
 * Version: 1.0.170
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}