using System;
using System.Collections.Generic;

namespace ScreenSound
{
    class Banda
    {
        private List<Album> albuns = new List<Album>();

        public string Nome { get; set; }

        public Banda(string nome)
        {
            this.Nome = nome;
        }

        public void AdicionarAlbum(Album album)
        {
            albuns.Add(album);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {this.Nome}");
            foreach (Album album in albuns)
            {
                Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
            }

        }
    }
}