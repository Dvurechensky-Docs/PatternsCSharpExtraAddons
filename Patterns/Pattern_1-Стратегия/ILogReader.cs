/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 сентября 2025 14:15:17
 * Version: 1.0.32
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}