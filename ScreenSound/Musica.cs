using System;

namespace ScreenSound
{
    class Musica
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string DescricaoResumida => $"A Música {this.Nome} pertence a banda {this.Artista}";


        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Artista: {this.Artista}");
            Console.WriteLine($"Duração: {this.Duracao}");
            if (this.Disponivel == true)
            {
                Console.WriteLine("Disponível no plano");
            }
            else
            {
                Console.WriteLine("Adquira o plano Plus+");
            }


        }
    }
}
