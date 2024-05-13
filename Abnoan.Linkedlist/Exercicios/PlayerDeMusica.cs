using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Linkedlist.Exercicios
{
    using System;
    using System.Collections.Generic;

    public class PlayerDeMusica
    {
        private LinkedList<string> playlist = new LinkedList<string>();
        private LinkedListNode<string> faixaAtual;

        public void AdicionarMusica(string musica)
        {
            playlist.AddLast(musica);
            if (faixaAtual == null)
            {
                faixaAtual = playlist.First;
            }
        }

        public void ProximaMusica()
        {
            if (faixaAtual?.Next != null)
            {
                faixaAtual = faixaAtual.Next;
            }
            else
            {
                faixaAtual = playlist.First;  // Volta para o início
            }
            Console.WriteLine($"Tocando: {faixaAtual.Value}");
        }

        public void MusicaAnterior()
        {
            if (faixaAtual?.Previous != null)
            {
                faixaAtual = faixaAtual.Previous;
            }
            else
            {
                faixaAtual = playlist.Last;  // Vai para o final
            }
            Console.WriteLine($"Tocando: {faixaAtual.Value}");
        }

        public void TocarMusicaAtual()
        {
            if (faixaAtual != null)
            {
                Console.WriteLine($"Tocando: {faixaAtual.Value}");
            }
        }
    }

}