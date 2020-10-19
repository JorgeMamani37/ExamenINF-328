from facade import *


class principal:

    def __init__(self):
        pass


"""La clase Facade proporciona una interfaz simple a la lógica compleja de uno o
    varios subsistemas. El facade delega las solicitudes del cliente al
    objetos apropiados dentro del subsistema. El facade también es responsable de
    gestionar su ciclo de vida. Todo esto protege al cliente de lo indeseado.
    """
"""Para este ejercicio tenemos una clase impresora, el cual en la clase facade se implementa lo que es la clase impresora
   para que el cliente interactue con la clase facade y no asi con la clase impresora 
   , lo cual es la idea del patron de diseño Facade"""
if __name__ == "__main__":
    Facade = facade("Este es un texto en Facade")
    print("Imprimiendo.....")
    Facade.imprimir()
