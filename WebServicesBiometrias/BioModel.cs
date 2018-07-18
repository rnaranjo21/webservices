using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data; 
namespace WebServicesBiometrias
{
    public class BioModel
    {
      
        private String stPr_Comando = "";
        private SqlConnection ObjPr_conDatabase = null;
        SqlCommand ObjPr_cmdDatabase = null;
        SqlDataReader ObjPr_rdr = null;

        public DataSet EjecutaSP(String stR_NomSP, Int32 stR_Parametro)
        {
            try
            {
                DataSet dataTable = new DataSet(); 
                String stL_Sentencia = stR_NomSP + " " + stR_Parametro + " ";
                this.stPr_Comando = stL_Sentencia;
                ObjPr_conDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionfenix"].ConnectionString);
                ObjPr_conDatabase.Open();
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(
                    stPr_Comando, ObjPr_conDatabase))
                {
                    
                    sqlAdapter.Fill(dataTable);
                } 
              
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar de validación de biometrias ", ex);
                //return null;
            }
        }
    }
}