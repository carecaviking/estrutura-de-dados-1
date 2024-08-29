
// Array Unidimensional
int[] numbers;
numbers = new int [5];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

// Declaração inciaçozada 
string[] names = 
     {"Eu", "Tu", "Ele", "Nós", "Vós", "Eles"};

// Exemplo Vetor com o nome dos meses
string[] months = new string[12];
for(int i = 1; i <= 12; i++)
{
    DateTime FirtDay = 
        new DateTime(DateTime.Now.Year, i, 1);
    string name = 
        FirtDay.ToString("MMM");
    
    months[i-1] = name;
    
}

foreach(string m in months)
{
    Console.WriteLine(m);
}