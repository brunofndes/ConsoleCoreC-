using GameTop.Interface;
namespace GameTop.lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Maradona chuta \n";
        }

        public string Corre()
        {
            return "Maradona corre \n";
        }

        public string Passe()
        {
            return "Maradona passa \n";
        }
    }
}