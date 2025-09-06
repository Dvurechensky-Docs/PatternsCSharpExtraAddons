/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 сентября 2025 11:46:13
 * Version: 1.0.18
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}