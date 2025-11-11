/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 ноября 2025 06:53:32
 * Version: 1.0.84
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}