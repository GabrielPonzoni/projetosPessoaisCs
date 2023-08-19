/// Neste jogo, o programa gera um número aleatório entre 1 e 100 e o usuário deve adivinhar qual é esse número. 
/// O programa utiliza o if-else e switch case para verificar se o número digitado pelo usuário é maior ou menor 
/// do que o número gerado pelo programa.
/// 
/// O programa também utiliza o conceito de laço de repetição do-while para permitir que o usuário faça várias 
/// tentativas até acertar o número. Quando o usuário acertar o número, o jogo acaba e o programa exibe uma mensagem 
/// indicando que o jogo acabou.

Random numAleatorio = new Random();
int valorRandInteiro = numAleatorio.Next(1,101);
int tentativaAtual = 1;
int tentativaTotal = 5;

void ExibirCabecalho()
{
    Console.WriteLine(@"
================================================
▄▀█ █▀▄ █ █░█ █ █▄░█ █░█ ▄▀█   ▀█▀ █░█ █▀▄ █▀█ █
█▀█ █▄▀ █ ▀▄▀ █ █░▀█ █▀█ █▀█   ░█░ █▄█ █▄▀ █▄█ ▄
================================================"); // Título do jogo
    Console.WriteLine(@"
Bem-Vindo ao jogo de adivinhação! para jogar 
basta escrever um número de 1 a 100 e tente 
acertera o mesmo número que eu pensei!"); // Explicacão do jogo 
}

ExibirCabecalho();
//Console.WriteLine("\nNumero Aleatório: "+ valorRandInteiro);
while (true)
{
    if (tentativaAtual <= tentativaTotal) // 1 <= 5
    {
        Console.WriteLine($"\nVocê está na {tentativaAtual}a tentativa de {tentativaTotal} tentativas.");
        Console.Write("Qual número a máquina chutou?");

        int valorChute = int.Parse(Console.ReadLine()!);
        if (valorChute == valorRandInteiro)
        {
            Console.WriteLine("\nParabéns vc acertou! o número que eu pensei era "+ valorRandInteiro);
            break;
        } else if (valorChute < valorRandInteiro) 
        {
            Console.WriteLine("Infelizmente você errou! (o número é um pouco maior)");
            tentativaAtual++;
        } else if (valorChute > valorRandInteiro)
        {
            Console.WriteLine("Infelizmente você errou! (o número é um pouco menor!)");
            tentativaAtual++;
        } else
        {
            Console.WriteLine("Informação inválida! Tente novamente");
        }
    }
    else
    {
        Console.WriteLine("\nInfelizmente você perdeu ._. o número que eu pensei era " + valorRandInteiro);
        break;
    }
    
}

