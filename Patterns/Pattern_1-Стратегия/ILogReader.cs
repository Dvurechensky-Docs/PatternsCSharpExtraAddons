/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 августа 2025 06:51:54
 * Version: 1.0.10
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}