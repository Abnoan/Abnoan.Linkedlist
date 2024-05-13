
using Abnoan.Linkedlist.Exercicios;

internal class Program
{
    private static void Main(string[] args)
    {
        // Cria uma nova LinkedList de inteiros
        LinkedList<int> numbers = new LinkedList<int>();

        // Adiciona um elemento no início da lista
        numbers.AddFirst(10); // LinkedList: 10
                              // Adiciona outro elemento no início
        numbers.AddFirst(5); // LinkedList: 5, 10

        // Adiciona um elemento no final da lista
        numbers.AddLast(20); // LinkedList: 5, 10, 20
                             // Adiciona outro elemento no final
        numbers.AddLast(25); // LinkedList: 5, 10, 20, 25

        // Dada a LinkedList anterior: 5, 10, 20, 25

        // Remove o primeiro elemento
        numbers.RemoveFirst(); // LinkedList após a remoção: 10, 20, 25

        // Remove o último elemento
        numbers.RemoveLast(); // LinkedList após a remoção: 10, 20

        #region Iterando
        numbers = new LinkedList<int>();
        numbers.AddLast(10);
        numbers.AddLast(20);
        numbers.AddLast(30);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        LinkedList<string> frutas = new LinkedList<string>();
        frutas.AddLast("Uva");
        frutas.AddLast("Banana");
        frutas.AddLast("Mamão");

        // Obtendo o primeiro nó
        LinkedListNode<string> node = frutas.First;

        // Navegando para o próximo nó
        while (node != null)
        {
            Console.WriteLine(node.Value);
            node = node.Next;
        }


        // Criando uma LinkedList de strings para os dias da semana
        LinkedList<string> dias = new LinkedList<string>();

        // Adicionando alguns dias na LinkedList
        LinkedListNode<string> seg = dias.AddLast("Segunda-feira");
        dias.AddLast("Quarta-feira");
        dias.AddLast("Sexta-feira");

        // Adicionando terça-feira depois de segunda-feira
        dias.AddAfter(seg, "Terça-feira");

        // Encontrar o nó de quarta-feira para inserir quinta-feira antes de sexta-feira
        LinkedListNode<string> qua = dias.Find("Quarta-feira");
        dias.AddBefore(qua.Next, "Quinta-feira");

        // Iterando sobre a LinkedList para exibir os dias da semana
        Console.WriteLine("Dias da semana:");
        foreach (var dia in dias)
        {
            Console.WriteLine(dia);
        }
        #endregion

        #region Exercicios
        #region Editor de Texto
        // Instanciando e testando o Editor de Texto
        EditorDeTexto editor = new EditorDeTexto("Olá Mundo");
        editor.Inserir('!');
        editor.MoverCursorParaTras();
        editor.Inserir(' ');
        Console.WriteLine("Conteúdo do editor após inserções:");
        editor.Exibir();

        // Deletando um caractere
        editor.Deletar();
        Console.WriteLine("Conteúdo do editor após deletar:");
        editor.Exibir();

        #endregion

        #region Gerenciador de Tarefas

        // // Instanciando e testando o Gerenciador de Tarefas
        // GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();
        // gerenciador.AdicionarTarefa("Estudar C#");
        // gerenciador.AdicionarTarefa("Ler documentação do .NET");
        // Console.WriteLine("Tarefas pendentes:");
        // gerenciador.MostrarTarefas();

        // // Completando uma tarefa
        // gerenciador.CompletarTarefa();
        // Console.WriteLine("Tarefas após completar uma:");
        // gerenciador.MostrarTarefas();

        #endregion

        #region Player de Música

        // // Instanciando e testando o Player de Música
        // PlayerDeMusica player = new PlayerDeMusica();
        // player.AdicionarMusica("Música 1");
        // player.AdicionarMusica("Música 2");
        // player.AdicionarMusica("Música 3");

        // // Tocando músicas
        // Console.WriteLine("Tocando músicas:");
        // player.TocarMusicaAtual();
        // player.ProximaMusica();
        // player.TocarMusicaAtual();
        // player.ProximaMusica();
        // player.TocarMusicaAtual();

        // // Voltando para a música anterior
        // Console.WriteLine("Voltando para a música anterior:");
        // player.MusicaAnterior();
        // player.TocarMusicaAtual();

        #endregion

        #endregion
    }
}