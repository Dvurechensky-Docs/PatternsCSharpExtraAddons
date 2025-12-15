/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 декабря 2025 06:51:49
 * Version: 1.0.118
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}