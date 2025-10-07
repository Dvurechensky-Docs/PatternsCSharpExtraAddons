/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 октября 2025 08:38:41
 * Version: 1.0.49
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}