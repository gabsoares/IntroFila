namespace IntroFila
{
    internal class FilaPessoa
    {
        Pessoa? head, tail;

        public FilaPessoa()
        {
            this.head = null;
            this.tail = null;
        }

        public void Push(Pessoa aux)
        {
            if (IsEmpty())
            {
                //As duas variáveis recebem o auxiliar | tail recebe aux (ou seja, tail vira aux) e head recebe aux por meio do tail
                head = tail = aux;
            }
            else
            {
                //Tail seta o next como auxiliar
                this.tail.setNext(aux);
                //Tai recebe o valor do auxiliar
                this.tail = aux;
            }
        }

        public void Pop()
        {
            //Se a fila não tiver vazia
            if (!IsEmpty())
            {
                //Se o tail e head apontarem para o mesmo objeto, vai ter apenas um elemento na fila, sendo assim o próximo será null deixando a fila vazia
                if (tail == head)
                {
                    head = tail = null;
                }
                else
                {
                    //Quando tiver mais de um elemento, a cabeça apontará para o próximo elemento dela, assim removendo o anterior
                    this.head = this.head.getNext();
                }
            }
        }

        public void RunOver()
        {
            Pessoa aux = this.head;
            if (IsEmpty())
            {
                Console.WriteLine("Não da pra imprimir uma fila vazia.");
            }
            else
            {
                do
                {
                    //Imprimo o auxiliar
                    Console.WriteLine(aux.ToString());
                    //O auxiliar recebe o proximo da fila
                    aux = aux.getNext();
                    //Enquanto auxiliar for diferente de nulo
                } while (aux != null);
                Console.WriteLine("Fim da impressão");
            }
        }

        public bool IsEmpty()
        {
            return head == null && tail == null;
        }
    }
}
