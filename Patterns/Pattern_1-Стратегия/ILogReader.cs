/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 сентября 2025 06:51:51
 * Version: 1.0.27
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}