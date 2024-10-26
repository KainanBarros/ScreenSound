﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ScreenSound
{
    class Album
    {
        private List<Musica> musicas = new List<Musica>();
        public string Nome { get; set; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);


        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicaDoAlbum()
        {
            Console.WriteLine($"Lista de música do álbum: {this.Nome}:\n");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome}");
            }
            Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {this.DuracaoTotal}");
        }
    }
}