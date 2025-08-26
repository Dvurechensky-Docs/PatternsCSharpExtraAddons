/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 августа 2025 04:30:44
 * Version: 1.0.5
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}