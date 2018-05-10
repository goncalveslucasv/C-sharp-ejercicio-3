using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3ByMe
{
    public class Cafe
    {

       

        private string nombre;
        private float precio;
        private string tipoCafe;
        private float litrosVendidos;
        private int cantidadVendida;
        private float totalRecaudado;

        public float TotalRecaudado
        {
            get { return totalRecaudado; }
            set { totalRecaudado = value; }
        }


        public string NombreCafe
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int CantidadVendida
        {
            get { return cantidadVendida; }
            set { cantidadVendida = value; }
        }


        public float LitrosVendidos
        {
            get { return litrosVendidos; }
            set { litrosVendidos = value; }
        }

        public string TipoCafe
        {
            get { return tipoCafe; }
            set { tipoCafe = value; }
        }


        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public void RegistrarVenta(MaquinaCafe maquina, VasoCafe vasoCafe)
        {
            float precio = this.Precio * vasoCafe.Medida;

            this.TotalRecaudado += precio;
            this.CantidadVendida++;
            this.LitrosVendidos += vasoCafe.Medida;
        }

     
    }
}