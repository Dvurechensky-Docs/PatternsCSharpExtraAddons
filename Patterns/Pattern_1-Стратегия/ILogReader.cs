/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 сентября 2025 06:51:55
 * Version: 1.0.36
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}