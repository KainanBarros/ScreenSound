using ScreenSound.Modelos;

namespace ScreenSound
{
    class Program
    {
        static void Main(string[] args)
        {
            Banda queen = new Banda("Queen");

            Album albumDoQueen = new Album("A nigth at the opera");

            Musica musica1 = new Musica(queen, "Love of my life")
            {
                Duracao = 213,
                Disponivel = true
            };

            Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
            {
                Duracao = 354,
                Disponivel = true
            };

            albumDoQueen.AdicionarMusica(musica1);
            albumDoQueen.AdicionarMusica(musica2);
            queen.AdicionarAlbum(albumDoQueen);

            musica1.ExibirFichaTecnica();
            musica2.ExibirFichaTecnica();

            albumDoQueen.ExibirMusicaDoAlbum();
            queen.ExibirDiscografia();

        }
    }
}