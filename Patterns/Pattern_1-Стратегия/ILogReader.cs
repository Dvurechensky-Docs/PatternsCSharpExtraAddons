/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 марта 2026 06:51:58
 * Version: 1.0.210
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}