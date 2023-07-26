/*
 * Interpreter Pattern
 * 
using Interpreter_pattern.Interpreter_Pattern;

var input = "(13+4)-(12+1)";
var tokens = HelperMethods.Lex(input);
Console.WriteLine(string.Join("\t", tokens));

var parsed = HelperMethods.Parse(tokens);
Console.WriteLine($"{input} = {parsed.Value}");
*/