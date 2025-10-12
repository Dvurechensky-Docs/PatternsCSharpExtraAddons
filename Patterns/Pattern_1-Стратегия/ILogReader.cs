/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 октября 2025 10:58:50
 * Version: 1.0.54
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}