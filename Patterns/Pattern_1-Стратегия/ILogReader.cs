/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 ноября 2025 06:51:44
 * Version: 1.0.74
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}