class Impresora:

    def __init__(self):
        self.tipoDoc = " "
        self.hoja = " "
        self.color = False
        self.texto = " "

    def imprimirDoc(self):
        print("Tipo de Doc. = ", self.tipoDoc)
        print("Tipo de Hoja =", self.hoja)
        print("Color = ", self.color)
        print("Texto = ", self.texto)
