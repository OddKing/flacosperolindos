using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaCalses;
using bibliotecaControlador;

namespace Web
{
    public partial class Agregar : System.Web.UI.Page
    {
        DaoModelo dao;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //se cargo por primera vez
                ddlSexo.DataSource = Enum.GetValues(typeof(TipoSexo));
                ddlSexo.DataBind();
                ddlServico.DataSource = Enum.GetValues(typeof(TipoServicio));
                ddlServico.DataBind();
            }
            if (Session["dao"]==null)
            {
                dao = new DaoModelo();
                Session["dao"] = dao;
            }
            else
            {
                dao = (DaoModelo)Session["dao"];
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoCita = int.Parse(txtCodigoCita.Text);
                DateTime fecha = DateTime.Parse(txtFechaEvento.Value);
                string nombreEvento = txtNombreEvento.Text;
                string nombreModelo = txtNombreModelo.Text;
                TipoSexo sexo = (TipoSexo)ddlSexo.SelectedIndex;
                TipoServicio servicio = (TipoServicio)ddlServico.SelectedIndex;
                int valor = int.Parse(txtValor.Text);
                Modelo m = new Modelo()
                {
                    CodigoCita = codigoCita,
                    FechaEvento = fecha,
                    NombreEvento = nombreEvento,
                    NombreModelo = nombreModelo,
                    Sexo = sexo,
                    Servicio = servicio,
                    Valor=valor
                };
    
            bool resp = dao.Grabar(m);
            lblMensaje.Text = resp ? "grabo" : "no grabo";
            }
            catch (ArgumentException ex)
            {
                lblMensaje.Text=ex.Message;
            }   
        }
    }
}