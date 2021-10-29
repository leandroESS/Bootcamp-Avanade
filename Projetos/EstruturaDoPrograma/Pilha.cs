using System;

namespace EstruturaDoPrograma
{
    public class Pilha
    {
        Posicao primeiro;
        public void Empilha(object item)
        {
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha()
        {
            if(primeiro == null) // se tiver vazia não tem como, dai dá erro
            {
                throw new InvalidOperationException("Pilha vazia");
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo; // agora o primeiro é o proximo
            return  resultado;
        }

        class Posicao
        {
            public Posicao proximo;
            public object item;

            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }
        
    }
}