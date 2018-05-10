using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3ByMe
{
    public class Cafeteria
    {
        public Cafeteria()
        {
            this.cafeArabigo.NombreCafe = "Arabigo";
            this.cafeArabigo.Precio = 50;

            this.cafeRobusto.NombreCafe = "Robusto";
            this.cafeRobusto.Precio = 58;

            this.vasoChico.Nombre = "Chico";
            this.vasoChico.Medida = 0.50f;

            this.vasoMediano.Nombre = "Mediano";
            this.vasoMediano.Medida = 0.100f;

            this.vasoGrande.Nombre = "Grande";
            this.vasoGrande.Medida = 0.250f;

        }

        public List<MaquinaCafe> maquinaCafe = new List<MaquinaCafe>();
        private float recaudacionTotal;
        private Cafe cafeArabigo = new Cafe();
        private Cafe cafeRobusto = new Cafe();

        private VasoCafe vasoChico = new VasoCafe();
        private VasoCafe vasoMediano = new VasoCafe();
        private VasoCafe vasoGrande = new VasoCafe();

        public VasoCafe VasoChico{
            get { return vasoChico; }
        }
        public VasoCafe VasoMediano{
            get { return vasoMediano; }

        }
        public VasoCafe VasoGrande {
            get { return vasoGrande; }
        }



        public Cafe CafeArabigo
        {
            get { return cafeArabigo;  }
        }
        public Cafe CafeRobusto
        {
            get { return cafeRobusto;  }
        }

        public float RecaudacionTotal
        {
            get { return recaudacionTotal; }
            set { recaudacionTotal = value; }
        }

        public void CrearMaquinaCafe(string nombre, float capacidad, Cafe cafe)
        {
            this.maquinaCafe.Add(new MaquinaCafe()
            {
                Nombre = nombre,
                Capacidad = capacidad,
                Cafe = cafe
            });
        }

        public Cafe CafeMasVendido()
        {
            Cafe tmp = CafeArabigo;
            if (tmp.TotalRecaudado < CafeRobusto.TotalRecaudado)
            {
                tmp = CafeRobusto;
            }
            return tmp;
        }

        public MaquinaCafe maquinaMasRecargada()
        {
            MaquinaCafe tmp = this.maquinaCafe.First();
            foreach (var maquina in this.maquinaCafe)
            {
                if(tmp.CantidadRecargas < maquina.CantidadRecargas)
                {
                    tmp = maquina;
                }

            }
            return tmp;
        }
        public float porcentajeMaquina(MaquinaCafe maquina)
        {
            return this.RecaudacionTotal / 100 * maquina.DineroRecaudado;
        }
        public float porcentajeCafe(Cafe cafe)
        {
            float recaudado = CafeArabigo.TotalRecaudado + CafeRobusto.TotalRecaudado;
            return recaudado * 100 / cafe.TotalRecaudado;
        }
        public Cafe CafeMenosVendido()
        {
            Cafe tmp = CafeArabigo;
            if (tmp.TotalRecaudado > CafeRobusto.TotalRecaudado)
            {
                tmp = CafeRobusto;
            }
            return tmp;
        }
        public Cafe CafeMasServido()
        {
            Cafe tmp = CafeArabigo;
            if (tmp.LitrosVendidos < CafeRobusto.LitrosVendidos)
            {
                tmp = CafeRobusto;
            }
            return tmp;
        }
        public Cafe CafeMenosServido()
        {
            Cafe tmp = CafeArabigo;
            if(tmp.LitrosVendidos > CafeRobusto.LitrosVendidos)
            {
                tmp = CafeRobusto;
            }
            return tmp;
        }

        public MaquinaCafe MaquinaMasVendio()
        {
            MaquinaCafe tmp = this.maquinaCafe.First();
            foreach (var maquina in this.maquinaCafe)
            {
                if (tmp.DineroRecaudado < maquina.DineroRecaudado)
                {
                    tmp = maquina;
                }

            }
            return tmp;

        }
        public MaquinaCafe MaquinaMenosVendio()
        {
            MaquinaCafe tmp = this.maquinaCafe.First();
            foreach (var maquina in this.maquinaCafe)
            {
                if (tmp.DineroRecaudado > maquina.DineroRecaudado)
                {
                    tmp = maquina;
                }

            }
            return tmp;

        }
        public MaquinaCafe MaquinaMasSirvio()
        {
            MaquinaCafe tmp = this.maquinaCafe.First();
            foreach (var maquina in this.maquinaCafe)
            {
                if (tmp.LitrosServidos < maquina.LitrosServidos)
                {
                    tmp = maquina;
                }

            }
            return tmp;

        }
        public MaquinaCafe MaquinaMenosSirvio()
        {
            MaquinaCafe tmp = this.maquinaCafe.First();
            foreach (var maquina in this.maquinaCafe)
            {
                if(tmp.LitrosServidos > maquina.LitrosServidos)
                {
                    tmp = maquina;
                }

            }
            return tmp;
        }

        public bool GenerarVenta(MaquinaCafe maquina, VasoCafe vasoCafe)
        {
            if (maquina.ContenidoActual >= vasoCafe.Medida)
            {
                this.recaudacionTotal += (maquina.Cafe.Precio * vasoCafe.Medida);

                maquina.Cafe.RegistrarVenta(maquina, vasoCafe);

                maquina.RegistrarVenta(maquina, vasoCafe);
               

                return true;
            } else
            {
                return false;
            }
            
            
           
        }




    }
}