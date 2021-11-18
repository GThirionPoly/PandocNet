﻿using CliWrap;
using VerifyNUnit;
using NUnit.Framework;
using PandocNet;

[TestFixture]
public class Samples
{
    [Test]
    public async Task Streams()
    {
        var engine = new PandocEngine();
        using (var inStream = File.OpenRead("sample.md"))
        using (var outStream = File.OpenWrite("output.html"))
        {
            await engine.Convert(
                inStream,
                outStream,
                new CommonMarkIn(),
                new HtmlOut());
        }

        await Verifier.VerifyFile("output.html");
    }

    [Test]
    public async Task Content()
    {
        var engine = new PandocEngine();
        var result = await engine.ConvertContent(@"*text*",
            new CommonMarkIn(),
            new HtmlOut());

        await Verifier.Verify(result).UseExtension("html");
    }
}