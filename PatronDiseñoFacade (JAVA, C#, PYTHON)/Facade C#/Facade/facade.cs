using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Facade
    {
        private Impresora impresora;

        public Facade(string texto)
        {
            impresora = new Impresora();
            impresora.setColor(true);
            impresora.setHoja("A4");
            impresora.setTipoDoc("PDF");
            impresora.setTexto(texto);

        }
        public void imprimir()
        {
            impresora.imprimirDoc();
        }
    }
}
