using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Data.SqlClient;
using System.Data; 
namespace WebServicesBiometrias
{
    /// <summary>
    /// Descripción breve de WebServicesBiometrias
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicesBiometrias : System.Web.Services.WebService
    {

        BioModel bio = new BioModel(); 
        [WebMethod]
        public DataSet ValidarBiometria(Int32 identificacion)
        {

            return bio.EjecutaSP("SP_026_INFO_BIO_AFILIADO_X_WS",identificacion);
        }
    }
}
