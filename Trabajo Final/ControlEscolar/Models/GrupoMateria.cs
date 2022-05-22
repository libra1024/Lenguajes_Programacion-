using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar
{
    internal class GrupoMateria
    {
        int _id_grupo_materia;
        private string? _horario;
        private string? _docente;
        private Grupo _grupo;
        private Materia _materia;
        private Programa _programa;
        public Programa programa
        {
            get { return _programa; }
            set { _programa = value; }
        }
        

        public GrupoMateria(Materia materia, Grupo grupo, Programa programa)
        {
            this._materia = materia;
            this._grupo = grupo;
            this._programa=programa;
        }

        public GrupoMateria(Materia materia, Grupo grupo, Programa programa, 
            string docente, string horario, int id_grupo_materia) : this(materia, grupo, programa)
        {
            this._docente = docente;
            this._horario = horario;
            this._id_grupo_materia = id_grupo_materia;
        }

        public Materia materia
        {
            get { return _materia; }
            set { _materia = value; }
        }


        public Grupo grupo
        {
            get { return _grupo; }
            set { _grupo = value; }
        }


        public string docente
        {
            get { return _docente; }
            set { _docente = value; }
        }

        public string horario
        {
            get { return _horario; }
            set { _horario = value; }
        }

        public int id_grupo_materia
        {
            get{ return _id_grupo_materia; }
            set{ _id_grupo_materia = value; }
        }

        /* private string? _horario;
        private string? _docente;
        private Grupo _grupo;
        private Materia _materia;
        private Programa _programa;*/
        public override string ToString()
        {
            return $"Id: {_id_grupo_materia}, Horario: {_horario}, " +
                $"Docente: {_docente}, Grupo: [{_grupo.ToString()}], " +
                $" Materia: [{_materia.ToString()}, Programa: [{_programa.ToString()}]";
        }

    }
}
