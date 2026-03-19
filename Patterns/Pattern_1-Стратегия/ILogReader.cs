/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 марта 2026 06:51:55
 * Version: 1.0.211
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}