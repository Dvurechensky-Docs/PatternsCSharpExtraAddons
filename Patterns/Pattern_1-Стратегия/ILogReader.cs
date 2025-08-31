/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2025 07:39:40
 * Version: 1.0.12
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}