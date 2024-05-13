using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Linkedlist.Exercicios
{
    using System;
    using System.Collections.Generic;

    public class EditorDeTexto
    {
        private LinkedList<char> conteudo = new LinkedList<char>();
        private LinkedListNode<char> cursor;

        public EditorDeTexto(string textoInicial)
        {
            foreach (char c in textoInicial)
            {
                conteudo.AddLast(c);
            }
            cursor = conteudo.First;
        }

        public void Inserir(char caractere)
        {
            if (cursor == null)
            {
                conteudo.AddFirst(caractere);
                cursor = conteudo.First;
            }
            else
            {
                conteudo.AddAfter(cursor, caractere);
            }
        }

        public void Deletar()
        {
            if (cursor != null)
            {
                LinkedListNode<char> proximo = cursor.Next;
                conteudo.Remove(cursor);
                cursor = proximo;
            }
        }

        public void MoverCursorParaFrente()
        {
            if (cursor?.Next != null)
            {
                cursor = cursor.Next;
            }
        }

        public void MoverCursorParaTras()
        {
            if (cursor?.Previous != null)
            {
                cursor = cursor.Previous;
            }
        }

        public void Exibir()
        {
            foreach (var ch in conteudo)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
        }
    }

}