namespace ControlEscolar
{
    class ControlEscolarAdmin
    {
        private List<Unidad> _unidades;
        private List<Programa> _programas;
        private List<Materia> _materias;
        private List<Grupo> _grupos;
        private List<CicloEscolar> _ciclos;
        private List<GrupoMateria> _gruposMateria;
        private List<Estudiante> _estudiantes;

        public ControlEscolarAdmin()
        {
            _unidades = new List<Unidad>();
            _programas = new List<Programa>();
            _materias = new List<Materia>();
            _grupos = new List<Grupo>();
            _ciclos = new List<CicloEscolar>();
            _gruposMateria = new List<GrupoMateria>();
            _estudiantes = new List<Estudiante>();
        }
        public void menuPrincipal(){
            int opcionSeleccionada=0;
            
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al Sistema de Control Escolar");
                Console.WriteLine("1.- Administración de Grupos");
                Console.WriteLine("2.- Salir");
                Console.Write("Seleccione una opcion disponible: ");
            } while (!validaMenu(2,ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                
                case 1:
                    menuAdminGrupos();
                    break;
                    case 2:
                    break;
            }

        }

        private void menuAdminGrupos()
        {
            int opcionSeleccionada=0;
            
            do
            {
                Console.Clear();
                Console.WriteLine("Administración de Grupos");
                Console.WriteLine("1.- Unidades");
                Console.WriteLine("2.- Programas");
                Console.WriteLine("3.- Materias");
                Console.WriteLine("4.- Grupos");
                Console.WriteLine("5.- Ciclos Escolares");
                Console.WriteLine("6.- Grupos Materias");
                Console.WriteLine("7.- Regresar...");
                Console.Write("Selecciona una opcion: ");
            } while (!validaMenu(7,ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                
                case 1:
                    menuUnidades();
                    break;
                case 2:
                    menuProgramas();
                    break;
                case 3:
                    menuMaterias();
                    break;
                case 4:
                    menuGrupos();
                    break;
                case 5:
                    menuCiclosEscolares();
                    break;
                case 6:
                    menuGruposMaterias();
                    break;
                case 7:
                    menuPrincipal();
                    break;
            }
        }

        private void menuUnidades()
        {
            int opcionSeleccionada=0;
            
            do
            {
                Console.Clear();
                Console.WriteLine("CRUD Unidades");
                Console.WriteLine("1.- Listar");
                Console.WriteLine("2.- Crear");
                Console.WriteLine("3.- Editar");
                Console.WriteLine("4.- Eliminar");
                Console.WriteLine("5.- Regresar...");
                Console.Write("Selecciona una opcion: ");
            } while (!validaMenu(5,ref opcionSeleccionada));
            Console.Clear();
            switch (opcionSeleccionada)
            {
                
                case 1:
                    listarUnidades();
                    Console.ReadLine();
                    menuUnidades();
                    break;
                case 2:
                    crearUnidad();
                    menuUnidades();
                    break;
                case 3:
                    editarUnidad();
                    menuUnidades();
                    break;
                case 4:
                    eliminarUnidad();
                    menuUnidades();
                    break;
                case 5:
                    menuAdminGrupos();
                    break;
            }
        }

        private void eliminarUnidad()
        {
            if (_unidades.Count > 0)
            {
                string? id;
                Console.WriteLine("Eliminación de Unidad");
                listarUnidades();
                id = pedirValor("Selecciona el Id de la Unidad a Eliminar");
                Unidad? unidad = _unidades.FirstOrDefault(u => u.id_undidad == id);
                if (unidad == null)
                {
                    Console.WriteLine("No existe esa Unidad.");

                }
                else
                {
                    _unidades.Remove(unidad);
                    Console.WriteLine("Unidad Eliminada Correctamente.");
                }
            }
            else
            {
                Console.WriteLine("No existen unidades registradas");
            }
            Console.ReadLine();
        }

        private void editarUnidad()
        {
            if (_unidades.Count > 0)
            {
                string? id;
                Console.WriteLine("Edición de Unidad");
                listarUnidades();
                id = pedirValor("Selecciona el Id de la Unidad a Editar");
                Unidad? unidad = _unidades.FirstOrDefault(u => u.id_undidad == id);
                if (unidad == null)
                {
                    Console.WriteLine("No existe esa Unidad.");

                }
                else
                {
                    unidad.nombre_unidad = pedirValor("Nuevo Nombre");
                    Console.WriteLine("Unidad Editada Correctamente.");
                }
            }
            else
            {
                Console.WriteLine("No existen unidades registradas");
            }
            Console.ReadLine();
        }

        private string pedirValor(string nombreValor){
            string? valor;
            do
            {
                Console.Write($"{nombreValor}: ");
                valor= Console.ReadLine();
                if(valor==null||valor=="")
                {
                    Console.WriteLine($"{nombreValor} inválido");
                }
            } while (valor==null||valor=="");
            return valor;

        }
        private int pedirValorInt(string nombreValor)
        {
            int valor;
           Console.Write($"{nombreValor}");
            while (!int.TryParse(Console.ReadLine(), out valor) ){
                Console.WriteLine("Valor invalido");
                Console.Write($"{nombreValor}");
            }
            return valor;
        }
        private void crearUnidad()
        {
            string? id;
            string? nombre;
            Console.WriteLine("Creación de Unidad");
            id=pedirValor("Id");
            nombre=pedirValor("Nombre");
            Unidad nuevo = new Unidad(id,nombre);
            _unidades.Add(nuevo);
            Console.WriteLine("Unidad Creada Correctamente");
            Console.ReadLine();
        }

        private void listarUnidades()
        {
            if (_unidades.Count()>0)
            {
                foreach (Unidad item in _unidades)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("No existen unidades registradas.");
                Console.ReadLine();
            }
            
            
        }

        private bool validaMenu(int rango, ref int opcionSeleccionada)
        {
            int numero;
            if(int.TryParse(Console.ReadLine(),out numero))
            {
                if (numero<=rango&&numero!=0)
                {
                    opcionSeleccionada=numero;
                    return true;
                }
                else
                {
                    Console.WriteLine("Opción Inválida.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Valor inválido, debes ingresar un número.");
                return false;
            }
        }
        /*              PROGRAMAS                       */
        /*             CRUD Y MENU                      */
        private void menuProgramas()
        {
            int opcionSeleccionada = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("CRUD Programas");
                Console.WriteLine("1.- Listar");
                Console.WriteLine("2.- Crear");
                Console.WriteLine("3.- Editar");
                Console.WriteLine("4.- Eliminar");
                Console.WriteLine("5.- Regresar...");
                Console.Write("Selecciona una opcion: ");
            } while (!validaMenu(5, ref opcionSeleccionada));
            Console.Clear();
            switch (opcionSeleccionada)
            {

                case 1:
                    listarProgramas();
                    Console.ReadLine();
                    menuProgramas();
                    break;
                case 2:
                    crearPrograma();
                    menuProgramas();
                    break;
                case 3:
                    editarPrograma();
                    menuProgramas();
                    break;
                case 4:
                    eliminarPrograma();
                    menuProgramas();
                    break;
                case 5:
                    menuAdminGrupos();
                    break;
            }
        }

        private void eliminarPrograma()
        {
            
            string? id;
            if (_unidades.Count()>0) { 
                Console.WriteLine("Eliminación de Programa");
                listarProgramas();
                id = pedirValor("Selecciona el Id del Programa a eliminar");
                Programa? programa = _programas.FirstOrDefault(p => p.id_programa == id);
                if (programa == null)
                {
                    Console.WriteLine("No existe esa Programa.");

                }
                else
                {
                    _programas.Remove(programa);
                    Console.WriteLine("Programa Eliminada Correctamente.");
                }
            }
            else
            {
                Console.WriteLine("No se puede eliminar, sino existen unidades previamente creadas");
            }
            Console.ReadLine();
        }

        private void editarPrograma()
        {
            if (_unidades.Count() > 0) {
                string? id;
                Console.WriteLine("Edición de Unidad");
                listarProgramas();
                id = pedirValor("Selecciona el Id de la Unidad a Editar");
                Programa? programa = _programas.FirstOrDefault(p => p.id_programa == id);
                if (programa == null)
                {
                    Console.WriteLine("No existe esa Programa");

                }
                else
                {
                    programa.nombre_programa = pedirValor("Nuevo Nombre");
                    Console.WriteLine("Programa Editada Correctamente.");
                }
                
            }
            else
            {
                Console.WriteLine("No se puede editar, sino existen unidades perviamente creadas");
            }
            Console.ReadLine();
        }
    

        private void crearPrograma()
        {
            string? id;
            string? nombre;
            string? idUnidad;
            if (_unidades.Count() > 0)
            {
               Console.WriteLine("Creación de Programa");
                id=pedirValor("Id Programa con caracteres y numeros");
                nombre=pedirValor("Nombre Programa");
                listarUnidades();
                idUnidad = pedirValor("Selecciona el Id de la Unidad a Añadir al Programa");
                Unidad? unidad = _unidades.FirstOrDefault(u => u.id_undidad == idUnidad);
                if (unidad == null)
                {
                    Console.WriteLine("No existe la Unidad");
                }
                else
                {
                    Programa nuevo = new Programa(id, nombre, unidad);
                    _programas.Add(nuevo);
                    Console.WriteLine("Programa creado exitosamente");
                }
            }
            else
            {
                Console.WriteLine("No exiten Unidades registradas, por lo tanto no se puede crear el Programa");
            }
            Console.ReadLine();

        }

        private void listarProgramas()
        {
            if (_programas.Count()>0)
            {
                foreach (Programa item in _programas)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("No existen programas registradas.");
                
            }
            Console.ReadLine();
        }


        /*              MATERIAS                        */
                /*             CRUD Y MENU                      */

           private void menuMaterias(){
                int opcionSeleccionada = 0;

                do
                {
                    Console.Clear();
                    Console.WriteLine("CRUD Materias");
                    Console.WriteLine("1.- Listar");
                    Console.WriteLine("2.- Crear");
                    Console.WriteLine("3.- Editar");
                    Console.WriteLine("4.- Eliminar");
                    Console.WriteLine("5.- Regresar...");
                    Console.Write("Selecciona una opcion: ");
                } while (!validaMenu(5, ref opcionSeleccionada));
                Console.Clear();
                switch (opcionSeleccionada)
                {

                    case 1:
                        listarMaterias();
                        Console.ReadLine();
                        menuMaterias();
                        break;
                    case 2:
                        crearMateria();
                        menuMaterias();
                        break;
                    case 3:
                        editarMateria();
                        menuMaterias();
                        break;
                    case 4:
                        eliminarMateria();
                        menuMaterias();
                        break;
                    case 5:
                        menuAdminGrupos();
                        break;
                }
           }

        private void eliminarMateria()
        {
            if (_materias.Count() > 0)
            {
                int? id;
                Console.WriteLine("Eliminación de Materia");
                listarMaterias();
                id = pedirValorInt("Selecciona el Id de la Materia a Eliminar");
                Materia? materia = _materias.FirstOrDefault(m => m.idMateria == id);
                if (materia == null)
                {
                    Console.WriteLine("No existe esa Materia.");
                }
                else
                {
                    _materias.Remove(materia);
                    Console.WriteLine("Materia Eliminada Correctamente.");
                }
            }
            else
            {
                Console.WriteLine("No se pueden eliminar materias si no sean registrado");
            }
            Console.ReadLine();
        }

        private void editarMateria()
        {
            if (_materias.Count() > 0)
            {
                int? id;
                Console.WriteLine("Edicion de Materia");
                listarMaterias();
                id = pedirValorInt("Selecciona el Id de la Materia a Editar");
                Materia? materia = _materias.FirstOrDefault(m => m.idMateria == id);
                if (materia == null)
                {
                    Console.WriteLine("No existe la Materia.");
                }
                else
                {
                    materia.nombreMateria = pedirValor("Nuevo Nombre");
                    Console.WriteLine("Materia Editada Correctamente.");
                }
            }
            else
            {
                Console.WriteLine("No se pueden eliminar materias si no sean registrado");
            }
            Console.ReadLine();
        }

        private void crearMateria()
        {
            string? nombre;
            Console.WriteLine("Creación de la Materia");
            nombre = pedirValor("Nombre");
            Materia nueva = new Materia(_materias.Count()+1, nombre);
            _materias.Add(nueva);
            Console.WriteLine("Materia Creada Correctamente");
            Console.ReadLine();

        }

        private void listarMaterias()
        {
            if (_materias.Count() > 0)
            {
                foreach (Materia item in _materias)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("No existen materias registradas.");
            }
            Console.ReadLine();
        }

        /*              GRUPOS                      */
        /*             CRUD Y MENU                  */
        private void menuGrupos()
        {
            int opcionSeleccionada = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("CRUD Grupos");
                Console.WriteLine("1.- Listar");
                Console.WriteLine("2.- Crear");
                Console.WriteLine("3.- Editar");
                Console.WriteLine("4.- Eliminar");
                Console.WriteLine("5.- Regresar...");
                Console.Write("Selecciona una opcion: ");
            } while (!validaMenu(5, ref opcionSeleccionada));
            Console.Clear();
            switch (opcionSeleccionada)
            {

                case 1:
                    listarGrupos();
                    Console.ReadLine();
                    menuGrupos();
                    break;
                case 2:
                    crearGrupo();
                    menuGrupos();
                    break;
                case 3:
                    editarGrupo();
                    menuGrupos();
                    break;
                case 4:
                    eliminarGrupo();
                    menuGrupos();
                    break;
                case 5:menuAdminGrupos();
                    break;
            }
        }

        private void eliminarGrupo()
        {
            if (_grupos.Count() > 0)
            {
                int? id;
                Console.WriteLine("Eliminación del Grupo");
                listarGrupos();
                id = pedirValorInt("Selecciona el Id del Grupo a Eliminar");
                Grupo? grupo = _grupos.FirstOrDefault(g => g.id_grupo == id);
                if (grupo == null)
                {
                    Console.WriteLine("No existe ese Grupo.");
                }
                else
                {
                    _grupos.Remove(grupo);
                    Console.WriteLine("Grupo Eliminado Correctamente.");
                }
            }
            else
            {
                Console.WriteLine("No se pueden eliminar grupos sino sean registrado");
            }
            Console.ReadLine();
        }

        private void editarGrupo()
        {
            if (_grupos.Count() > 0)
            {
                int? id;
                Console.WriteLine("Edicion de Grupo");
                listarGrupos();
                id = pedirValorInt("Selecciona el Id del Grupo a Editar");
                Grupo? grupo = _grupos.FirstOrDefault(g => g.id_grupo == id);
                if (grupo == null)
                {
                    Console.WriteLine("No existe el Grupo.");
                }
                else
                {
                    grupo.grado = pedirValor("Nuevo Grado");
                    grupo.nombre = pedirValor("Nuevo Nombre");
                }
            }
            else
            {
                Console.WriteLine("No se pueden eliminar grupos si no sean registrado");
            }
            Console.ReadLine();
        }

        private void crearGrupo()
        {
            string? nombre;
            string? grado;
            Console.WriteLine("Creación del Grupo");
            grado = pedirValor("Grado");
            nombre = pedirValor("Nombre");
            Grupo nuevo = new Grupo(_grupos.Count()+1, grado, nombre);
            _grupos.Add(nuevo);
            Console.WriteLine("Grupo Creado Correctamente");
            Console.ReadLine();
        }

        private void listarGrupos()
        {
            if (_grupos.Count() > 0)
            {
                foreach (Grupo item in _grupos)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("No existen materias registradas.");
            }
            Console.ReadLine();
        }

        /*              CICLOS ESCOLARES            */
            /*             CRUD Y MENU                  */

            private void menuCiclosEscolares()
            {
                int opcionSeleccionada = 0;

                do
                {
                    Console.Clear();
                    Console.WriteLine("CRUD Ciclos Escolares");
                    Console.WriteLine("1.- Listar");
                    Console.WriteLine("2.- Crear");
                    Console.WriteLine("3.- Editar");
                    Console.WriteLine("4.- Eliminar");
                    Console.WriteLine("5.- Regresar...");
                    Console.Write("Selecciona una opcion: ");
                } while (!validaMenu(5, ref opcionSeleccionada));
                Console.Clear();
                switch (opcionSeleccionada)
                {

                    case 1:
                        listarCiclosEscolares();
                        Console.ReadLine();
                        menuCiclosEscolares();
                        break;
                    case 2:
                        crearCicloEscolar();
                        menuCiclosEscolares();
                        break;
                    case 3:
                        editarCicloEscolar();
                        menuCiclosEscolares();
                        break;
                    case 4:
                        eliminarCicloEscolar();
                        menuCiclosEscolares();
                        break;
                    case 5:
                        menuAdminGrupos();
                        break;
                }
            }

        private void eliminarCicloEscolar()
        {
            if (_ciclos.Count() > 0)
            {
                int id;
                Console.WriteLine("Eliminacion de Ciclo Escolar");
                listarCiclosEscolares();
                id = pedirValorInt("Selecciona el Id del Ciclo Escolar a Eliminar");
                CicloEscolar? ciclo = _ciclos.FirstOrDefault(c => c.idCiclo == id);
                if (ciclo != null)
                {
                    Console.WriteLine("No existe este Ciclo Escolar.");
                }
                else
                {
                    _ciclos.Remove(ciclo);
                    Console.WriteLine("Ciclo Escolar Eliminado Correctamente");
                }
            }
            else
            {
                Console.WriteLine("No se pueden eliminar ciclos escolares sino sean registrado");
            }
            Console.ReadLine();
         }

         private void editarCicloEscolar()
         {
            if (_ciclos.Count() > 0)
            {
                int id;
                Console.WriteLine("Edicion de Ciclo Escolar");
                listarCiclosEscolares();
                id = pedirValorInt("Selecciona el Id del Ciclo Escolar a Editar");
                CicloEscolar? ciclo = _ciclos.FirstOrDefault(c => c.idCiclo == id);
                if (ciclo == null)
                {
                    Console.WriteLine("No existe ese Ciclo Escolar.");
                }
                else
                {
                    ciclo.Descripcion = pedirValor("Nueva Descripcion");
                    Console.WriteLine("Ciclo Escolar Editada Correctamente");
                }
            }
            else
            {
                Console.WriteLine("No se pueden eliminar ciclos escolares si no sean registrado");
            }
            Console.ReadLine();
         }

         private void crearCicloEscolar()
         {
             String descripcion;
             Console.WriteLine("Creacion del Ciclo Escolar");
             descripcion = pedirValor("Descripcion");
             CicloEscolar nuevo = new CicloEscolar(_ciclos.Count+1, descripcion);
             _ciclos.Add(nuevo);
             Console.WriteLine("Ciclo Escolar Creado Correctamente");
             Console.ReadLine();
         }

         private void listarCiclosEscolares()
         {
             if (_ciclos.Count() > 0)
             {
                 foreach(CicloEscolar item in _ciclos)
                 {
                     Console.WriteLine(item.ToString());
                 }
             }
             else
             {
                 Console.WriteLine("No existen ciclos escolares registrados");
             }
             Console.ReadLine();
         }

         /*             GRUPOS MATERIAS                        */
            /*             CRUD Y MENU                      */
            private void menuGruposMaterias()
            {
                int opcionSeleccionada = 0;

                do
                {
                    Console.Clear();
                    Console.WriteLine("CRUD Grupos-Materias");
                    Console.WriteLine("1.- Listar");
                    Console.WriteLine("2.- Crear");
                    Console.WriteLine("3.- Editar");
                    Console.WriteLine("4.- Eliminar");
                    Console.WriteLine("5.- Regresar...");
                    Console.Write("Selecciona una opcion: ");
                } while (!validaMenu(5, ref opcionSeleccionada));
                Console.Clear();
                switch (opcionSeleccionada)
                {

                    case 1:
                        listarGruposMaterias();
                        Console.ReadLine();
                        menuUnidades();
                        break;
                    case 2:
                        crearGrupoMateria();
                        menuGruposMaterias();
                        break;
                    case 3:
                        editarGrupoMateria();
                        menuGruposMaterias();
                        break;
                    case 4:
                        eliminarGrupoMateria();
                        menuGruposMaterias();
                        break;
                    case 5:
                        menuAdminGrupos();
                        break;
                }
            }

        private void eliminarGrupoMateria()
        {
            int id;
            if (_gruposMateria.Count() > 0)
            {
                Console.WriteLine("Eliminacion de Grupos-Materia");
                listarGruposMaterias();
                id = pedirValorInt("Selecciona el Id de los Grupos-Materia a Eliminar");
                GrupoMateria? grupoMateria = _gruposMateria.FirstOrDefault(gm => gm.id_grupo_materia == id);
                if (grupoMateria == null)
                {
                    Console.WriteLine("No existe ese Ciclo Escolar.");
                }
                else
                {

                    _gruposMateria.Remove(grupoMateria);
                }
            }
            else
            {
                Console.WriteLine("No se puede editar si no existen grupos-materias previamente registrados");
            }
            Console.ReadLine();
        }

        private void editarGrupoMateria()
        {
            int id;
            if (_gruposMateria.Count()>0)
            {
                Console.WriteLine("Edicion de Grupos-Materia");
                listarGruposMaterias();
                id = pedirValorInt("Selecciona el Id de los Grupos-Materia a Editar");
                GrupoMateria? grupoMateria = _gruposMateria.FirstOrDefault(gm => gm.id_grupo_materia == id);
                if (grupoMateria == null)
                {
                    Console.WriteLine("No existe ese Ciclo Escolar.");
                }
                else
                {
                    grupoMateria.horario = pedirValor("Nuevo Horario");
                    grupoMateria.docente = pedirValor("Nuevo Docente");
                    Console.WriteLine("Ciclo Escolar Editada Correctamente");
                }
            }
            else
            {
                Console.WriteLine("No se puede editar si no existen grupos-materias previamente registrados");
            }
            Console.ReadLine();
        }

        private void crearGrupoMateria()
        {
            string? horario;
            string? docente;
            string? idPrograma;
            int idGrupo;
            int idMateria;
            if (_programas.Count() > 0 & _grupos.Count()>0 & _materias.Count()>0)
            {
                Console.WriteLine("Creacion de Grupo y Materia");
                horario = pedirValor("Horario");
                docente = pedirValor("Docente");
                Console.WriteLine("Lista de Grupos");
                listarGrupos();
                idGrupo = pedirValorInt("Selecciona un Id de los grupos mostrados");
                Console.WriteLine("Lista de Materias");
                listarMaterias();
                idMateria = pedirValorInt("Selecciona un Id de las materias mostradas");
                Console.WriteLine("Lista de Programas");
                listarProgramas();
                idPrograma = pedirValor("Selecciona un Id de los programas creados");
                Grupo? grupo = _grupos.FirstOrDefault(g=>g.id_grupo==idGrupo);
                Materia? materia = _materias.FirstOrDefault(m=>m.idMateria==idMateria);
                Programa? programa = _programas.FirstOrDefault(p=>p.id_programa==idPrograma);
                if (grupo == null & materia == null & programa == null )
                {
                    Console.WriteLine("No se puede crear Grupo-Materia, porque no existe el grupo, la materia y el programa");
                }
                else
                {
                    GrupoMateria nuevo = new GrupoMateria(materia, grupo, programa, docente, horario,_gruposMateria.Count()+1);
                    _gruposMateria.Add(nuevo);
                    Console.WriteLine("Se creo exitosamente el Grupo y Materia");
                }

            }
            else
            {
                Console.WriteLine("No se puede crear un grupo-materia, sino hay materias, grupos y programas registrados");
            }
            Console.ReadLine();
        }

        private void listarGruposMaterias()
        {
            if(_gruposMateria.Count() > 0)
            {
                foreach(GrupoMateria item in _gruposMateria)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("No existen grupos y materias registrados");
            }
            Console.ReadLine();
        }
        public void inicializarValores()
        {
            Unidad unidad1 = new Unidad("E70", "Ingenieria Electrica");
            Unidad unidad2 = new Unidad("E71", "Ingenieria");
            _unidades.Add(unidad1);
            _unidades.Add(unidad2);
            Programa programa1 = new Programa("A78", "Ingenieria en Computacion", unidad1);
            Programa programa2 = new Programa("A79", "Ingenieria en Computacion", unidad2);
            _programas.Add(programa1);
            _programas.Add(programa2);
            Materia materia1 = new Materia(_materias.Count() + 1, "Fisica");
            Materia materia2 = new Materia(_materias.Count() + 2, "Electronica");
            _materias.Add(materia1);
            _materias.Add(materia2);
            Grupo grupo1 = new Grupo(_grupos.Count() + 1, "4", "Z");
            Grupo grupo2 = new Grupo(_grupos.Count() + 2, "5", "A");
            _grupos.Add(grupo1);
            _grupos.Add(grupo2);
            CicloEscolar cicloEscolar1 = new CicloEscolar(_ciclos.Count()+1, "2022-2023");
            CicloEscolar cicloEscolar2 = new CicloEscolar(_ciclos.Count() + 2, "2023-2024");
            _ciclos.Add(cicloEscolar1);
            _ciclos.Add(cicloEscolar2);
            GrupoMateria grupoMateria1 = new GrupoMateria(materia1,grupo1, programa1, "Camerana", 
                "10-11",_gruposMateria.Count()+1);
            GrupoMateria grupoMateria2 = new GrupoMateria(materia2, grupo2, programa1, "Virtual",
               "12-13", _gruposMateria.Count() + +2);
            _gruposMateria.Add(grupoMateria1);
            _gruposMateria.Add(grupoMateria2);

        }
    }
}