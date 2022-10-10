
using SampleDataLibrary;

NamesSampleData namesSample = new();
NumericSampleData numericSample = new();

Console.WriteLine("Names:");
for (int i = 1; i < 31; i++)
{
    Console.WriteLine($"{i}. {namesSample.SampleFirstName()} {namesSample.SampleLastName()} ");
}

Console.WriteLine("\n\n\n\nBools:");
for (int i = 1; i < 31; i++)
{
    Console.WriteLine($"{i}. {numericSample.SampleBool()} ");
}

Console.WriteLine("\n\n\n\nInts from 0 to 99:");
for (int i = 1; i < 31; i++)
{
    Console.WriteLine($"{i}. {numericSample.SampleInt(0, 99)} ");
}

Console.WriteLine("\n\n\n\nDoubles from 1 to 19:");
for (int i = 1; i < 31; i++)
{
    Console.WriteLine($"{i}. {numericSample.SampleDouble(1, 19)} ");
}

Console.WriteLine("\n\n\n\nPhone numbers:");
for (int i = 1; i < 6; i++)
{
    Console.WriteLine(numericSample.SamplePhoneNumber("{0:(###) ###-####}"));
}

Console.WriteLine("\n\n\n\nZip Codes:");
for (int i = 1; i < 6; i++)
{
    Console.WriteLine(numericSample.SampleZipCode("{0:#####-####}"));
}