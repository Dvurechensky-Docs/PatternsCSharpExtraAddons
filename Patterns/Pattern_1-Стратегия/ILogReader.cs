/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 ноября 2025 17:23:07
 * Version: 1.0.75
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}