﻿namespace Pandoc;

/// <summary>
/// https://jats.nlm.nih.gov/
/// </summary>
public class JatsPublishingOut :
    OutOptions
{
    public override string Format => "jats_publishing";

    /// <summary>
    /// Use only ASCII characters in output
    /// https://pandoc.org/MANUAL.html#option--ascii
    /// </summary>
    public bool Ascii { get; set; }

    public override IEnumerable<string> GetArguments()
    {
        foreach (var argument in base.GetArguments())
        {
            yield return argument;
        }

        if (Ascii)
        {
            yield return "--ascii";
        }
    }
}