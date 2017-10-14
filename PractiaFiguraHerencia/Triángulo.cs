using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaFiguraHerencia
{
    class Triángulo:Figura
    {

        protected float baseT;
        protected float alturaT;

        #region Propiedad perteneciente a la base

        public float BaseT
        {
            set
            {
                if (baseT > 0)
                {
                    baseT = value;
                }
                //Si el radio es negativo o 0, lanzamos una excepción.
                else
                {
                    throw new Exception("Error, el radio no puede ser 0 o negativo");
                }

            }
            get
            {
                return baseT;
            }
        }
        #endregion

        #region Propiedad para la altura
        public float AlturaT
        {
            set
            {               
                alturaT = value;             
            }
            get
            {
                return alturaT;
            }
        }
            #endregion

        public Triángulo(float baseT, float alturaT)
        {
            setBase(baseT);
            setAltura(alturaT);
        }


        #region Metodos encargados de evitar obtener bases/alturas negativas

        public void setBase(float baseT)
        {
            if (baseT > 0)
            { 
                this.baseT = baseT;
            }
            else
            {
                throw new Exception("Error, la base/altura no puede ser negativa o 0");
            }
        }

        public void setAltura(float alturaT)
        {
            if (alturaT > 0)
            {
                this.alturaT = alturaT;
            }
            else
            {
                throw new Exception();
            }
        }

        #endregion

        #region Métodos con override para calcular el área y el perímetro.
        public override void calcularÁrea()
        {
            área = alturaT * baseT;
        }
        #endregion

        #region Metodo para calcular el perimetro
        public override void calcularPerímetro()
        {
            perímetro = baseT + (alturaT * 2);
        }
        #endregion

        
    }
}
