using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCalses;

namespace bibliotecaControlador
{
    public class DaoModelo
    {
        private List<Modelo> modelos;

        public DaoModelo()
        {
            modelos = new List<Modelo>();
        }
        public bool Grabar(Modelo m1)
        {
            if (ExisteCita(m1.CodigoCita) == false)
            {
                modelos.Add(m1);
                return true;
            }
            return false;
        }
        public bool Eliminar(int codigo) {
            foreach (var item in modelos)
            {
                if (item.CodigoCita==codigo)
                {
                    modelos.Remove(item);
                    return false;
                }
            }

            return false;
        }

        public bool Modificar(Modelo m1)
        {
            foreach (var item in modelos)
            {
                if (item.CodigoCita==m1.CodigoCita)
                {
                    modelos.Remove(item);
                    modelos.Add(m1);
                    return true;
                }
            }
            return false;
        }

        public List<Modelo> Listar()
        {
            return modelos;
        }

        private bool ExisteCita(int codigoCita)
        {
            foreach (Modelo mod in modelos)
            {
                if (mod.CodigoCita==codigoCita)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
