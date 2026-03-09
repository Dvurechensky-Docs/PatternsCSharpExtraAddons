/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 марта 2026 06:52:00
 * Version: 1.0.202
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}