using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaFiguraHerencia
{
    class Rectángulo:Figura
    {
        #region Campos del rectángulo
        protected float baseR;
        protected float alturaR;
        #endregion

        #region Propiedad para la Base

        public float BaseR
        {
            set
            {              
                baseR = value;
            }                                       
            get
            {
                return baseR;
            }
        }
        #endregion

        #region Propiedad para la Altura
        public float AlturaR
        {
            set
            {
                alturaR = value;
            } 
            get
            {
                return alturaR;
            }
        }
        #endregion

        #region Constructor

        public Rectángulo(float baseR, float alturaR)
        {
            BaseR = baseR;
            AlturaR = alturaR;

        }
        #endregion

        #region Metodos encargados de evitar obtener bases/alturas negativas

        public void setBase(float baseR)
        {
            if (baseR > 0)
            {
                this.baseR = baseR;
            }
            else
            {
                throw new Exception("Error, la base/altura no puede ser negativa o 0");
            }
        }

        public void setAltura(float alturaR)
        {
            if (alturaR > 0)
            {
                this.alturaR = alturaR;
            }
            else
            {
                throw new Exception("Error, la altura/base no puede ser negativa o 0");
            }
        }

        #endregion

        #region Métodos con override para calcular el área y el perímetro.
        public override void calcularÁrea()
        {
            área = baseR * alturaR;
        }

        public override void calcularPerímetro()
        {
            perímetro = (baseR * 2) + (alturaR * 2);
        }
        #endregion
    }
}
