/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 сентября 2025 06:51:53
 * Version: 1.0.28
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}