using System.Text;

namespace SharpVoronoiLib.UnitTestGenerator;

public static class StringBuilderExtensions
{
    public static void AppendPaddedLine(this StringBuilder stringBuilder, int padding, string text, bool addExtraNewLine = false)
    {
        stringBuilder.Append(' ', padding * 4);
        stringBuilder.AppendLine(text);
        if (addExtraNewLine)
            stringBuilder.AppendLine();
    }
}