const double Receita_Farinha = 1;
const double Receita_Agua = 0.7;
const double Receita_Fermento = 0.4;
const double Receita_Sal = 0.02;

double percentualPaoRelativoFarinha = Receita_Farinha + Receita_Agua + Receita_Fermento + Receita_Sal;

double pesoPao, farinha, agua, fermento, sal;

Console.WriteLine("--- Padaria ---\n");

Console.Write("Peso desejado de pão italiano (em gramas)...: ");
pesoPao = Convert.ToDouble(Console.ReadLine());

farinha = pesoPao / percentualPaoRelativoFarinha;

agua = farinha * Receita_Agua;
fermento = farinha * Receita_Fermento;
sal = farinha * Receita_Sal;

Console.WriteLine("\nIngredientes:");

Console.WriteLine($"Farinha....: {farinha:N0} g");
Console.WriteLine($"Água.......: {agua:N0} g");
Console.WriteLine($"Fermento...: {fermento:N0} g");
Console.WriteLine($"Sal........: {sal:N0} g");

