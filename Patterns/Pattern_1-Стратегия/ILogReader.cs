/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 ноября 2025 06:51:51
 * Version: 1.0.79
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}