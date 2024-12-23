﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ScreenSound.Modelos
{
    class Album
    {
        private List<Musica> musicas = new List<Musica>();
        public string Nome { get;}
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public Album(string nome)
        {
            this.Nome = nome;  
        }

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicaDoAlbum()
        {
            Console.WriteLine($"Lista de música do álbum: {Nome}:\n");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome}");
            }
            Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
        }
    }
}