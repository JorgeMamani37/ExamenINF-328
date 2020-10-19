
package patronfacade;

public class Impresora {
    private String tipoDoc;
    private String hoja;
    private boolean color;
    private String texto;

    public String getTipoDoc() {
        return tipoDoc;
    }

    public void setTipoDoc(String tipoDoc) {
        this.tipoDoc = tipoDoc;
    }

    public String getHoja() {
        return hoja;
    }

    public void setHoja(String hoja) {
        this.hoja = hoja;
    }

    public boolean isColor() {
        return color;
    }

    public void setColor(boolean color) {
        this.color = color;
    }

    public String getTexto() {
        return texto;
    }

    public void setTexto(String texto) {
        this.texto = texto;
    }
    
    public void imprimirDoc(){
    
        System.out.println("Imprimiendo: "+texto+", COLOR: "+color+", TIPO: "+tipoDoc+", HOJA: "+hoja);
        
    }
    
    
}
