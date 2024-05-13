using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Linkedlist.Exercicios
{
    using System;
    using System.Collections.Generic;

    public class GerenciadorDeTarefas
    {
        private LinkedList<string> tarefas = new LinkedList<string>();

        public void AdicionarTarefa(string tarefa)
        {
            tarefas.AddLast(tarefa);
        }

        public void CompletarTarefa()
        {
            if (tarefas.First != null)
            {
                tarefas.RemoveFirst();
            }
        }

        public void MostrarTarefas()
        {
            foreach (string tarefa in tarefas)
            {
                Console.WriteLine(tarefa);
            }
        }
    }

}