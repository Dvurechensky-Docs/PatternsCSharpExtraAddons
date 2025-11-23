/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 ноября 2025 06:51:46
 * Version: 1.0.96
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}