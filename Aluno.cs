using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolinhaDoCleitoUsandoCollections
{
    internal class Aluno
    {

        public string matricula;
        public string nome;
        public string curso;
        public string[] disciplina;
        public decimal[] notas;
        public decimal media;


        public override string ToString()
        {
            return $"Nome: {nome}, Matrícula: {matricula}, Curso: {curso}, Média:{media}";
        }

    }
}
