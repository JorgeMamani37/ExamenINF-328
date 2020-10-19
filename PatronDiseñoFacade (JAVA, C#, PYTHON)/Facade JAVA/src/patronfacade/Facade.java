/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package patronfacade;

/**
 *
 * @author MAIK
 */
public class Facade {
    private Impresora impresora;
    
    public Facade(String texto){
      super();
       impresora=new Impresora();
       impresora.setColor(true);
       impresora.setHoja("A4");
       impresora.setTipoDoc("PDF");
       impresora.setTexto(texto);
       
    }
    
    public void imprimir(){
       impresora.imprimirDoc();
    }
}
