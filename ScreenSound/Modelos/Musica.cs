using System;

namespace ScreenSound.Modelos
{
    class Musica
    {
        public string Nome { get;}
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string DescricaoResumida => $"A Música {Nome} pertence a banda {Artista}";


        public Musica(Banda artista, string nome)
        {
            this.Artista = artista;
            this.Nome = nome;
        }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Artista: {this.Artista}");
            Console.WriteLine($"Duração: {this.Duracao}");
            if (this.Disponivel == true)
            {
                Console.WriteLine("Disponível no plano\n");
            }
            else
            {
                Console.WriteLine("Adquira o plano Plus+\n");
            }


        }
    }
}
