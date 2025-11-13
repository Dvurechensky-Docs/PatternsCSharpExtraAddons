/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 ноября 2025 06:51:48
 * Version: 1.0.86
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}