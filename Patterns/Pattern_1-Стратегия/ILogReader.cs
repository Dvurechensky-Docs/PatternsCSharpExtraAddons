/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 ноября 2025 06:51:47
 * Version: 1.0.100
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}