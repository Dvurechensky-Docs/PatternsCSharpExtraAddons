/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 октября 2025 12:24:14
 * Version: 1.0.68
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}