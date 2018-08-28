using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalses
{
    public class Modelo
    {
        private int _codigoCita;
        private DateTime _fechaEveneto;
        private string _nombreEvento;
        private string _nombreModelo;
        private int _edad;
        private TipoSexo _sexo;
        private TipoServicio _servicio;
        private int _valor;
        public int Valor
        {
            get { return _valor; }
            set {
                if (value>=50000 && value<=170000)
                {
                    _valor = value;
                }
                else
                {
                    throw new ArgumentException("valor evento entre 50.000 y 170.000");
                }
                
            }
        }
        public TipoServicio Servicio
        {
            get { return _servicio; }
            set { _servicio = value; }
        }
        public TipoSexo Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        public int Edad
        {
            get { return _edad; }
            set {
                if (value>=3 && value<=90)
                {
                    _edad = value;
                }
                else
                {
                    throw new ArgumentException("Edad entre  3 y 90 ");
                }
                
            }
        }
        public string NombreModelo
        {
            get { return _nombreModelo; }
            set {
                if (value.Length>=3 && value.Length<=40)
                {
                    _nombreModelo = value;
                }
                else
                {
                    throw new ArgumentException("Nombre entre 3 y 40 caracteres");
                }
                
            }
        }
        public string NombreEvento
        {
            get { return _nombreEvento; }
            set {
                if (value.Length>=1 && value.Length<=30)
                {
                    _nombreEvento = value;
                }
                else
                {
                    throw new ArgumentException("Nombre entre 1 y 30 caracteres");
                }
                 }
        }
        public DateTime FechaEvento
        {
            get { return _fechaEveneto; }
            set {
                if (value>DateTime.Today )
                {
                    _fechaEveneto = value;
                }
                else
                {
                    throw new ArgumentException("la fecha no es valida debe ser mayor a hoy");
                }
                
            }
        }
        public int CodigoCita
        {
            get { return _codigoCita; }
            set { _codigoCita = value; }
        }
        public Modelo()
        {
            Init();
        }

        private void Init()
        {
            CodigoCita = 123456789;
            FechaEvento = DateTime.Today.AddDays(1);
            NombreEvento = "lasllass";
            NombreModelo = "pedro casas";
            Edad = 18;
            Sexo = TipoSexo.Masculino;
            Servicio = TipoServicio.Show;
            Valor = 50000;
           
        }
    }
}
