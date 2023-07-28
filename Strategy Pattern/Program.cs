/*
 * Static + dynamic initialization applied
 * 
using static Strategy_Pattern.Strategy_Pattern_1.SD;
using Strategy_Pattern.Strategy_Pattern_1;

var tp = new TextProcessor<MarkdownListStrategy>();
tp.SetOutputFormat(OutputFormat.Markdown);
tp.AppendList(new[] { "foo", "bar", "baz" });
Console.WriteLine(tp);

var tp2 = new TextProcessor<HtmlListStrategy>();
tp2.SetOutputFormat(OutputFormat.Html);
tp2.AppendList(new[] { "foo", "bar", "baz" });
Console.WriteLine(tp2);
*/