/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 сентября 2025 06:51:52
 * Version: 1.0.29
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}