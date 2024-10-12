using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Dashboard
    {
        ArrayList Categoria = new ArrayList();
        ArrayList CantProd = new ArrayList();
        ArrayList Producto = new ArrayList();
        ArrayList Cant = new ArrayList();
        string totalVentas;
        string CantCategorias;
        string CantMarcas;
        string CantProductos;

        //string CantEmpleados;
        string CantProveedores;
        public ArrayList Categoria1
        {
            get
            {
                return Categoria;
            }
            set
            {
                Categoria = value;
            }
        }
        public ArrayList CantProd1
        {
            get
            {
                return CantProd;
            }
            set
            {
                CantProd = value;
            }
        }
        public ArrayList Producto1
        {
            get
            {
                return Producto;
            }
            set
            {
                Producto = value;
            }
        }
        public ArrayList Cant1
        {
            get
            {
                return Cant;
            }
            set
            {
                Cant = value;
            }
        }
        public string TotalVentas
        {
            get
            {
                return totalVentas;
            }
            set
            {
                totalVentas = value;
            }
        }
        public string CantCategorias1
        {
            get
            {
                return CantCategorias;
            }
            set
            {
                CantCategorias = value;
            }
        }
        public string CantMarcas1
        {
            get
            {
                return CantMarcas;
            }
            set
            {
                CantMarcas = value;
            }
        }
        public string CantProductos1
        {
            get
            {
                return CantProductos;
            }
            set
            {
                CantProductos = value;
            }
        }
      
        public string CantProveedores1
        {
            get
            {
                return CantProveedores;
            }
            set
            {
                CantProveedores = value;
            }
        }


    }
}
