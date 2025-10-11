/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 октября 2025 08:49:23
 * Version: 1.0.53
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}