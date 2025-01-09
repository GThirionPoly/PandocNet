namespace Pandoc;

public record StringResult(string Command, string Value)
{
    public string Command { get; } = Command;
    public string Value { get; } = Value;

    public override string ToString() => Value;
    public static implicit operator string(StringResult x) => x.Value;
}