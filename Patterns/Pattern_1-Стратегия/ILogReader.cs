/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 декабря 2025 09:58:13
 * Version: 1.0.132
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}