using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3ByMe
{
    public class MaquinaCafe : Cafeteria
    {
        private Cafe cafe;
        private string nombre;
        private float litrosServidos;
        private float dineroRecaudado;
        private float capacidad;
        private float contenidoActual;
        private int cantidadVentas;
        private int cantidadRecargas;

        public int CantidadRecargas
        {
            get { return cantidadRecargas; }
            set { cantidadRecargas = value; }
        }


        public int CantidadVentas
        {
            get { return cantidadVentas; }
            set { cantidadVentas = value; }
        }


        public float ContenidoActual
        {
            get { return contenidoActual; }
            set { contenidoActual = value; }
        }


        public float Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }


        public float DineroRecaudado
        {
            get { return dineroRecaudado; }
            set { dineroRecaudado = value; }
        }

        public float LitrosServidos
        {
            get { return litrosServidos; }
            set { litrosServidos = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public Cafe Cafe
        {
            get { return cafe; }
            set { cafe = value; }
        }

        public void Recargar()
        {
            this.contenidoActual = this.capacidad;
            this.CantidadRecargas++;
        }

        public void RegistrarVenta(MaquinaCafe maquina, VasoCafe vasoCafe)
        {
            float precio = this.Cafe.Precio * vasoCafe.Medida;


            this.LitrosServidos += vasoCafe.Medida;
            this.ContenidoActual -= vasoCafe.Medida;
            this.DineroRecaudado += precio;
            this.CantidadVentas++;
        }

    }
}