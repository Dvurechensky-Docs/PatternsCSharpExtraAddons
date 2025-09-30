/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 сентября 2025 06:51:50
 * Version: 1.0.42
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}