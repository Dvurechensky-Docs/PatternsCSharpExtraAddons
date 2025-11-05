/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 ноября 2025 06:51:47
 * Version: 1.0.78
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}