/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 октября 2025 06:51:53
 * Version: 1.0.43
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}