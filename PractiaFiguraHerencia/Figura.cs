using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaFiguraHerencia
{
    class Figura
    {
        #region Campos de la clase figura
        protected float área;
        protected float perímetro;
        #endregion

        #region Propiedades
        public float Área
        {
            set
            {
                área = value;
            }
            get
            {
                return área;
            }
        }

        public float Perímetro
        {
            set
            {
                perímetro = value;
            }
            get
            {
                return perímetro;
            }
        }

        #endregion

        #region Métodos virtuales que sobreescribirán los hijos.
        /// <summary>
        /// Método virtual para calcular el perímetro y que será sobreescrito en las clases
        /// hijas en función a la fórmula que utilicen
        /// </summary>
        public virtual void calcularPerímetro()
        {

        }

        /// <summary>
        ///  Método virtual para calcular el área y que será sobreescrito en las clases
        ///  hijas en función a la fórmula que utilicen
        /// </summary>
        public virtual void calcularÁrea()
        {

        }

        #endregion

        #region Metodos para obtener el area y el perimetro (Getter)
        /// <summary>
        /// Getter del área
        /// </summary>
        /// <returns>Devuelve el valor del área</returns>
        public float getÁrea()
        {
            return área;
        }
        /// <summary>
        /// Getter del perímetro
        /// </summary>
        /// <returns>Devuelve el valor del perímetro</returns>
        public float getPerímetro()
        {
            return perímetro;
        }
        #endregion

    }
}
