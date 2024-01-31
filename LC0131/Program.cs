// MIS3013 001
// January 31, 2024
// Helen Sniezek
// 113552793

bool b1;// b1, bool, simple, not expensive
// the address of the bool space is stored on b1
b1 = true;// assignment right Byte, 0:false 1:true
// RAM memory

Console.WriteLine(b1);// Writeline function
// Writeline()
//
// parameters, ingredients

// char
char c1;// char simple not expensive
//
c1 = '+';// ' 'assignment, char
c1 = '*';// assignment, 2 Bytes, int

// string
// complex
string str1;// str1, string, complex, expensive
// 0
str1 = "\tMIS\n\t3013\n";// assignment, str1, string complex
// 112
// positive address
Console.Write(str1);

// string.Format()
double p1;// p1 double simple not expensive
// 114 
p1 = 0.12 + 0.2;// assignment, 0.32 

double m1;// m1 double, simple, not expensive
// 115
m1 = 20.5 + 6 + p1;// assignment, CPU, 26.82

double g1;//
// 116
g1 = 96.6;// 

str1 = string.Format($"Percent is {p1:P1} Money {m1:C1} grade {g1:F6}");// Format: name of the function
Console.WriteLine(str1);

// 113
// assignment 
// Format() : call
// final product: string
// 

Console.WriteLine("Input the name:");

string nameStr;// 
nameStr = Console.ReadLine();// string
Console.WriteLine("Input the balance:");
string balStr;
balStr = Console.ReadLine();

double balDbl;
balDbl = Convert.ToDouble(balStr);

string mesStr;
mesStr = string.Format($"The current balance is {balDbl:C2}");
Console.WriteLine(mesStr);

balDbl = balDbl * 1.08;

mesStr = string.Format($"The new balance is {balDbl:C2}");
Console.WriteLine(mesStr);
