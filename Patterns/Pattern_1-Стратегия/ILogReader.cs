/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 февраля 2026 11:32:12
 * Version: 1.0.172
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}