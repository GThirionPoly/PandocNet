﻿namespace PandocNet;

public class MultiMdIn :
    InOptions
{
    public override string Format => "markdown_mmd";
    //https://pandoc.org/MANUAL.html#reader-options
    public string? DefaultImageExtension { get; set; }

    public override IEnumerable<string> GetArguments()
    {
        foreach (var argument in base.GetArguments())
        {
            yield return argument;
        }

        if (DefaultImageExtension != null)
        {
            yield return $"--default-image-extension={DefaultImageExtension}";
        }
    }
}