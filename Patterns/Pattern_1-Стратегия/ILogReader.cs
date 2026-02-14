/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 февраля 2026 10:03:08
 * Version: 1.0.179
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}