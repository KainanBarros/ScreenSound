using ScreenSound.Modelos;

namespace ScreenSound
{
    class Program
    {
        static void Main(string[] args)
        {
            Banda queen = new Banda("Queen");

            Album albumDoQueen = new Album();
            albumDoQueen.Nome = "A nigth at the opera";

            Musica musica1 = new Musica(queen);
            musica1.Nome = "Love of my life";
            musica1.Duracao = 213;

            Musica musica2 = new Musica(queen);
            musica2.Nome = "Bohemian Rhapsody";
            musica2.Duracao = 354;

            albumDoQueen.AdicionarMusica(musica1);
            albumDoQueen.AdicionarMusica(musica2);

            //albumDoQueen.ExibirMusicaDoAlbum();

            queen.AdicionarAlbum(albumDoQueen);

            queen.ExibirDiscografia();
        }
    }
}