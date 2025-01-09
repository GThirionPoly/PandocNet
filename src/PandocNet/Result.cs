namespace Pandoc;

public record Result(string Command)
{
    public string Command { get; } = Command;
}