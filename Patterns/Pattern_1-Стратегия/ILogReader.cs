/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 марта 2026 07:55:38
 * Version: 1.0.215
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}