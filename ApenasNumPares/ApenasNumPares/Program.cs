/// Crie uma lista de inteiros utilizando 
/// o List<int> e utilize o for e o foreach para iterar sobre essa lista e exibir apenas 
/// os números pares.
/// No for, comece o índice em 0 e incremente a cada iteração. Defina a condição de continuação 
/// do loop como i < numeros.Count, ou seja, o loop continuará enquanto o valor de i for menor 
/// do que o número de elementos na lista. Acesse o valor de cada elemento utilizando a sintaxe 
/// numeros[i].
/// Já no foreach, ao invés de utilizar um loop for com um contador i e acessar os elementos da 
/// lista através do índice i, é utilizado o foreach para percorrer a lista e acessar diretamente 
/// cada elemento com a variável número. Em seguida, é verificado se o número é par utilizando o 
/// operador de módulo (%) e, caso seja, o número é impresso no console.

List<int> listaDeNumeros = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("Nosso vetor de inteiros é composto por:"); 
for (int i = 0; i < listaDeNumeros.Count; i++)
{
    if (i < (listaDeNumeros.Count - 1))
    {
        Console.Write($"{listaDeNumeros[i]},"); 
    }
    else
    {
        Console.Write($"{listaDeNumeros[i]}.");
    }
}
Console.WriteLine();
Console.Write("[MÉTODO FOR]Dentro dele os seguites números são pares: ");

for (int i = 0; i < listaDeNumeros.Count; i++)
{
    if (listaDeNumeros[i] % 2 == 0)
        Console.Write($"{listaDeNumeros[i]} ");
}

Console.WriteLine();
Console.Write("[MÉTODO FOREACH]Dentro dele os seguites números são pares: ");

foreach (int i in listaDeNumeros)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
}

Console.WriteLine();
