using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using PedidoXperto.ChildClases;

namespace PedidoXperto.Logic
{
    public class GetFireBirdValue
    {
        public string GetValue(string query) 
        {
            FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                con.Open();
                FbCommand command = new FbCommand(query, con);
                FbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                else
                {
                    return null;
                }

            }
            catch
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public string[] BuscarDatosArticulos(string Clave_articulo)
        {
            string articulo_id = "", nombre = "", clave_principal = "", preciolista = "", impuestoid = "", impuesto ="0";

            FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                con.Open();
                string query = "SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '" + Clave_articulo + "'";
                FbCommand command = new FbCommand(query, con);
                FbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    articulo_id = reader.GetString(0);
                }
                else
                {
                    return null;
                }
                preciolista = GetValue("SELECT PRECIO FROM PRECIOS_ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "' AND PRECIO_EMPRESA_ID = '42';");
                string queryc = "SELECT CLAVE_ARTICULO FROM CLAVES_ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "' AND ROL_CLAVE_ART_ID = '17'";
                FbCommand commandc = new FbCommand(queryc, con);
                FbDataReader readerc = commandc.ExecuteReader();
                if (readerc.Read())
                {
                    clave_principal = readerc.GetString(0);
                }
                else
                {
                    return null;
                }
                impuestoid = GetValue("SELECT IMPUESTO_ID FROM IMPUESTOS_ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "';");
                impuesto = GetValue("SELECT PCTJE_IMPUESTO FROM IMPUESTOS WHERE IMPUESTO_ID = '" + impuestoid + "';");
                string queryb = "SELECT NOMBRE FROM ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "'";
                FbCommand commandb = new FbCommand(queryb, con);
                FbDataReader readerb = commandb.ExecuteReader();
                if (readerb.Read())
                {
                    nombre = readerb.GetString(0);
                    return new string[] { clave_principal, nombre, preciolista, impuesto };
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public string[] GetImpuestoArticulo(string Clave_articulo)
        {
           
                string articulo_id = GetValue("SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '" + Clave_articulo + "';");
                string impuestoid = GetValue("SELECT IMPUESTO_ID FROM IMPUESTOS_ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "';");
                string impuesto = GetValue("SELECT PCTJE_IMPUESTO FROM IMPUESTOS WHERE IMPUESTO_ID = '" + impuestoid + "';");
                return new string[] {impuesto };
        }
    }
}
