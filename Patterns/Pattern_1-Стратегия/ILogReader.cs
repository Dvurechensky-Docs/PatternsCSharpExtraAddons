/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 ноября 2025 06:51:48
 * Version: 1.0.80
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}