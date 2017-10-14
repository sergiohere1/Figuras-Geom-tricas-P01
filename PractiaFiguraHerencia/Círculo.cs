using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaFiguraHerencia
{
    class Círculo : Figura
    {
        #region Campos pertenecientes a la clase Círculo
        private float radio;
        #endregion

        #region Propiedad perteneciente al radio
        public float Radio
        {
            set
            {               
                radio = value;          
            }
            get
            {
                return radio;
            }
        }
        #endregion

        #region Constructor
        public Círculo(float radio)
        {
            setRadio(radio);
        }
        #endregion

        #region Setter para evitar valores negativos
        public void setRadio(float radio)
        {
            if (radio > 0)
            {
                this.radio = radio;
            }
            else
            {
                throw new Exception("Error, el radio no puede ser 0 o negativo");
            }
        }

        #endregion

        #region Métodos con override para calcular el área y el perímetro.
        public override void calcularÁrea()
        {
            Área = radio* (float) Math.PI;
        }

        public override void calcularPerímetro()
        {
            Perímetro = 2 * ((float) Math.PI * radio);
        }
        #endregion

    }
}
