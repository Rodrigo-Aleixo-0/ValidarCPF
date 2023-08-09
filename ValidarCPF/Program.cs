Console.WriteLine("*-----------------* Validar CPF *-----------------*");
Console.WriteLine();
Console.Write("Digite seu CPF: ");
string cpf = Console.ReadLine();

int num1 = 10;
int num2 = 11;

int digito_1 = 0;
int digito_2 = 0;

int soma = 0;

for(int i = 0; i < 9; i++)
{
    int atual = int.Parse(cpf[i].ToString());

    soma += (atual * num1);

    num1 -= 1;
}

if(soma % 11 < 2)
{
    digito_1 = 0;
} 
else
{
    digito_1 = 11 - (soma % 11);
}

soma = 0;

for (int i = 0; i < 10; i++)
{
    int atual = int.Parse(cpf[i].ToString());

    soma += (atual * num2);

    num2 -= 1;
}

if (soma % 11 < 2)
{
    digito_2 = 0;
}
else
{
    digito_2 = 11 - (soma % 11);
}

num1 = int.Parse(cpf[9].ToString());
num2 = int.Parse(cpf[10].ToString());

if ((digito_1 == num1) && (digito_2 == num2))
{
    Console.WriteLine();
    Console.WriteLine("CPF VALIDO.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("CPF INVALIDO.");
}
