from Impresora import *


class facade:

    def __init__(self, t):

        self.impresora_nueva = Impresora()
        self.impresora_nueva.color = True
        self.impresora_nueva.hoja = "A4"
        self.impresora_nueva.tipoDoc = "PDF"
        self.impresora_nueva.texto = t

    def imprimir(self):
        self.impresora_nueva.imprimirDoc()
