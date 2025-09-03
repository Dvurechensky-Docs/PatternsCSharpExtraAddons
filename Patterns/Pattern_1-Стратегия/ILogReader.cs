/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:56:58
 * Version: 1.0.15
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}