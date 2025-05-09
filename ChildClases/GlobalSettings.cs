﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoXperto.ChildClases
{
    public class GlobalSettings
    {
        private static GlobalSettings instance;
        public string StringConnection { get; set; }
        public string Ip { get; set; }
        public string Puerto { get; set; }
        public string Direccion { get; set; }
        public string User { get; set; }
        public string Pw { get; set; }
        public List<string> Config { get; set; }
        public string Name { get; set; }
        public string ClaveCliente { get; set; }

        public decimal Contenido { get; set; }
        public string filepath { get; set; }
        public bool editandoclave { get; set; }
        public string Vendedor { get; set; }
        public string FolioId { get; set; }
        public string status { get; set; }
        public string Articuloid { get; set; }
        public int Current { get; set; }
        public int Renglones { get; set; }
        public decimal Descuento_articulo_neto { get; set; }
        public decimal Importe_articulo_neto { get; set; }
        public bool Nota { get; set; }
        public decimal Existencia { get; set; }
        public decimal Update { get; set; }
        public bool ExistenciaQuery { get; set; }
        public int Contador_Codigos { get; set; }
        public decimal Importe_Total { get; set; }
        public string Clave_impuesto { get; set; }
        public string Impuesto { get; set; }
        public decimal Impuesto_total { get; set; }
        public decimal DiferenciaImporte { get; set; }
        public decimal UnidadesSolicitadas { get; set; }
        public decimal Importe_Total_Anterior { get; set; }
        public decimal Impuesto_Total_Anterior { get; set; }
        public decimal Importearticuloeliminado { get; set; }
        public decimal Impuesto_real { get; set; }
        public decimal Importe_real { get; set; }
        public int Incompletos { get; set; }
        public bool lastchance { get; set; }
        public string Vendedora { get; set; }
        public decimal ExistenciaAl { get; set; }
        public bool aceptado { get; set; }
        public string VendedorId { get; set; }
        public string Usuario { get; set; }
        public List<string> Excluidos { get; set; }
        public string Clave_articulo_id { get; set; }
        public int Posicion { get; set; }
        public int Eliminar { get; set; }
        public int Id { get; set; }
        public List<string> OficialCodigo { get; set; }
        public bool Editar { get; set; }
        public int PrimerImporte { get; set; }
        public decimal Desc_extra { get; set; }
        public decimal Desc_extra_importe { get; set; }
        public decimal Desc_extra_ind { get; set; }
        public string Docto_Ve_Id { get; set; }
        public string Crear_clave { get; set; }
        public string Crear_Nombre { get; set; }
        public int Bd { get; set; }
        public string PathConfig { get; } = "C:\\ConfigDB\\";
        public string EndPointRecomendacion { get; set; } = "/recomendar";
        public string NgrokGateWay { get; set; }
        public int Trn { get; set; }
        private GlobalSettings()
        {
            OficialCodigo = new List<string>();
            Config = new List<string>();
            Excluidos = new List<string>();

        }
        public static GlobalSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GlobalSettings();
                }
                return instance;
            }
        }
    }
    public class Articulo
    {
        public string Codigo { get; set; }
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Solicitado { get; set; }
        public decimal Recibido { get; set; }
        public string Nota { get; set; }
        public string Clave { get; set; }
        public string ArticuloId { get; set; }
        public string Ubicacion { get; set; }
        public decimal Pendiente { get; set; }
        public decimal Importe { get; set; }
        public decimal Descuento_porcentaje { get; set; }
        public decimal Importe_neto_articulo { get; set; }
        public decimal Importe_total_articuloeliminado { get; set; }
        public decimal Descuento_extra_individual { get; set; }

    }
    public class Factura
    {
        /// <summary>
        /// clave_cliente
        /// </summary>
        public Cliente ClaveCliente { get; }
        public List<Articulo> Articulos { get; }
        public string ClaveFactura { get; }

        public Factura(string ClaveFactura, Cliente ClaveCliente)
        {
            this.ClaveFactura = ClaveFactura;
            this.ClaveCliente = ClaveCliente;
            Articulos = new List<Articulo>();
        }
    }
    public class Cliente
    {
        /// <summary>
        /// clave_cliente
        /// </summary>
        string Clave;

        public Cliente(string Clave)
        {
            this.Clave = Clave;
        }
    }
    public class AdminUsuario
    {
        public int Id { get; set; }  // LiteDB genera el ID automáticamente si no se establece
        public string UsuarioName { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
    }
    public class AdminRoles
    {
        public int Id { get; set; }  // LiteDB genera el ID automáticamente si no se establece
        public string RolNombre { get; set; }
        public List<string> Derechos { get; set; }
    }
}