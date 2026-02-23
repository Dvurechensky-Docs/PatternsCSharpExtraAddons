/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 февраля 2026 14:22:35
 * Version: 1.0.188
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}