/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2026 06:51:25
 * Version: 1.0.380
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}