using System;
using GameTop.Interface;
namespace GameTop.lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome; 
        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }
        

        public string Chuta()
        {
             return $"{_Nome} está comendo travisti \n";
        }
        public string Corre()
        {
            return $"{_Nome} está chupando rola \n";
        }

        public string Passe()
        {
            return $"{_Nome} está passando \n";
        }
        
    }
}