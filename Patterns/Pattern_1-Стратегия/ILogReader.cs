/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 октября 2025 06:51:55
 * Version: 1.0.44
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}