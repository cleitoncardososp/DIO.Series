using System;

namespace DIO.Series.Classes
{
    public class Serie
    {
        public int Id {get; private set;}
        public Genero Genero {get; private set;}
        public string Titulo {get; private set;}
        public string Descricao {get; private set;}
        public int Ano {get; private set;}
        public bool Excluido {get; private set;}

        //Métodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public void Excluir()
        {
            Excluido = true;
        }

        public override string ToString()
        {
            return 
                "Gênero : " + Genero +
                "\nTitulo : " + Titulo +
                "\nDescricao : " + Descricao +
                "\nAno de Lançamento : " + Ano +
                "\nExcluído : " + Excluido;
        }
    }
}
