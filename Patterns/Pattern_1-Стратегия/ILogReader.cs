/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:43:06
 * Version: 1.0.240
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}