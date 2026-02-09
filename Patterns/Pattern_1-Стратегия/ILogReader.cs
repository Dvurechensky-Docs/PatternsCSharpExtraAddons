/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 февраля 2026 06:51:52
 * Version: 1.0.174
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}