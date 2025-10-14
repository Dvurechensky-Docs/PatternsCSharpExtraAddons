/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 октября 2025 10:14:49
 * Version: 1.0.56
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}