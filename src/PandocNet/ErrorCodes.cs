﻿namespace Pandoc;

//https://pandoc.org/MANUAL.html#exit-codes
static class ErrorCodes
{
    public static string GetErrorType(int exitCode)
    {
        return exitCode switch
        {
            3 => "PandocFailOnWarningError",
            4 => "PandocAppError",
            5 => "PandocTemplateError",
            6 => "PandocOptionError",
            21 => "PandocUnknownReaderError",
            22 => "PandocUnknownWriterError",
            24 => "PandocCiteprocError",
            25 => "PandocBibliographyError",
            31 => "PandocEpubSubdirectoryError",
            43 => "PandocPDFError",
            44 => "PandocXMLError",
            47 => "PandocPDFProgramNotFoundError",
            61 => "PandocHttpError",
            62 => "PandocShouldNeverHappenError",
            63 => "PandocSomeError",
            64 => "PandocParseError",
            65 => "PandocParsecError",
            67 => "PandocSyntaxMapError",
            83 => "PandocFilterError",
            91 => "PandocMacroLoop",
            92 => "PandocUTF8DecodingError",
            93 => "PandocIpynbDecodingError",
            94 => "PandocUnsupportedCharsetError",
            97 => "PandocCouldNotFindDataFileError",
            99 => "PandocResourceNotFound",
            _ => "PandocUnknownError"
        };
    }
}