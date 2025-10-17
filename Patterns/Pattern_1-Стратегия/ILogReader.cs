/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 октября 2025 13:18:05
 * Version: 1.0.59
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}