from tkinter import *
import parser
"""Libreria parser para evaluar expresiones matematicas """
root = Tk()
root.title("Calculadora")
root.geometry("350x180")
# Input Fields
display = Entry(root, width=50)
display.grid(row=0, columnspan=70)
display1 = Entry(root, width=39)
display1.grid(row=1, column=1, columnspan=60)

lbl = Label(root, text="Resultado")
lbl.grid(row=1, column=0)

# Get Numbers to Display
i = 0


def get_numbers(n):
    global i
    display.insert(i, n)
    i += 1


def get_operation(operator):
    global i
    opertor_length = len(operator)
    display.insert(i, operator)
    i += opertor_length


def calculate():
    display_state = display.get()
    try:
        math_expression = parser.expr(display_state).compile()
        result = eval(math_expression)
        clear_display1()
        display1.insert(0, result)
    except Exception:
        clear_display()
        display.insert(0, 'Error')


def clear_display():
    display.delete(0, END)


def clear_display1():
    display1.delete(0, END)


def undo():
    display_state = display.get()
    if len(display_state):
        display_new_state = display_state[:-1]
        clear_display()
        display.insert(0, display_new_state)
    else:
        clear_display()


# Numeric Buttons
Button(root, width=10, text="1",
       command=lambda: get_numbers(1)).grid(row=2, column=0)
Button(root, width=10, text="2",
       command=lambda: get_numbers(2)).grid(row=2, column=1)
Button(root, width=10, text="3",
       command=lambda: get_numbers(3)).grid(row=2, column=2)

Button(root, width=10, text="4",
       command=lambda: get_numbers(4)).grid(row=3, column=0)
Button(root, width=10, text="5",
       command=lambda: get_numbers(5)).grid(row=3, column=1)
Button(root, width=10, text="6",
       command=lambda: get_numbers(6)).grid(row=3, column=2)

Button(root, width=10, text="7",
       command=lambda: get_numbers(7)).grid(row=4, column=0)
Button(root, width=10, text="8",
       command=lambda: get_numbers(8)).grid(row=4, column=1)
Button(root, width=10, text="9",
       command=lambda: get_numbers(9)).grid(row=4, column=2)

# Bottom Buttons

Button(root, width=10, text="0",
       command=lambda: get_numbers(0)).grid(row=5, column=1)

Button(root, width=10, text="+",
       command=lambda: get_operation("+")).grid(row=2, column=3)
Button(root, width=10, text="-", command=lambda: get_operation("-")
       ).grid(row=3, column=3)
Button(root, width=10, text="*", command=lambda: get_operation("*")
       ).grid(row=4, column=3)
Button(root, width=10, text="/", command=lambda: get_operation("/")
       ).grid(row=5, column=3)

# More Math Operators
Button(root, width=10, text="⟵", command=lambda: undo()).grid(
    row=5, column=0)


Button(root, width=10, text="=", command=lambda: calculate()).grid(
    row=5, column=2)

root.mainloop()
