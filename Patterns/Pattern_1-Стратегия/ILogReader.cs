/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 марта 2026 07:33:12
 * Version: 1.0.213
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}