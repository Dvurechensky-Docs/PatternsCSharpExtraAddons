/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2025 14:25:58
 * Version: 1.0.63
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}