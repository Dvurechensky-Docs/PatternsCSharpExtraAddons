/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 октября 2025 06:51:50
 * Version: 1.0.65
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}