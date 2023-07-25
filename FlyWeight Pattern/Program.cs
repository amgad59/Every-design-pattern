/*
 * 
 * FlyWeight Pattern Formatting Text test
 *  
 * 
using FlyWeight_Pattern.FlyWeightPattern_2;

var ft = new FormattedText("This is a brave new world");
ft.Capitalize(10, 15);
Console.WriteLine(ft);

var bft = new OptimizedFormattedText("This is a brave new world");
bft.addFormatting(10, 15).Capitalize = true;
Console.WriteLine(bft);

*/