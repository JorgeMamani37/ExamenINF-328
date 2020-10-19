using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Impresora
    {
        private string tipoDoc;
        private string hoja;
        private Boolean color;
        private string texto;


        public String getTipoDoc()
        {
            return tipoDoc;
        }

        public void setTipoDoc(String tipoDoc)
        {
            this.tipoDoc = tipoDoc;
        }

        public String getHoja()
        {
            return hoja;
        }

        public void setHoja(String hoja)
        {
            this.hoja = hoja;
        }

        public Boolean isColor()
        {
            return color;
        }

        public void setColor(Boolean color)
        {
            this.color = color;
        }

        public String getTexto()
        {
            return texto;
        }

        public void setTexto(String texto)
        {
            this.texto = texto;
        }
        public void imprimirDoc()
        {

            Console.WriteLine(texto + ", COLOR: " + color + ", TIPO: " + tipoDoc + ", HOJA: " + hoja);

        }
    }
}
