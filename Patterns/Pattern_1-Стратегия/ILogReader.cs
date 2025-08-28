/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:07:50
 * Version: 1.0.9
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}