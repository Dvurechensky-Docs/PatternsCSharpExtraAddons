/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 февраля 2026 06:52:01
 * Version: 1.0.191
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}