using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int numero;
        String total="";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dato;
            dato=(((Button)sender).Text).ToString();
            total = total + "" + dato;
            textBox1.Text = total;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numero = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button15_Click(object sender, EventArgs e)
        {
            String texto = total;
            String[] signos=new String[100];
            int cont = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto.Substring(i,1)=="+"||texto.Substring(i,1)=="-"|| texto.Substring(i, 1) == "*"|| texto.Substring(i, 1) == "/")
                {
                    signos[cont] = texto.Substring(i, 1);
                    cont++;
                }                
            }
            String[] delimitadores = { "<=", ">=", ">", "<", "+", "-", "/", "*" };
            String[] vectoraux;
            vectoraux = texto.Split(delimitadores, StringSplitOptions.None);
            int s = conteo(signos, cont);
            int pun = cont;
            double resul = 0;
            int tamaño = vectoraux.Length;
            while (pun!=0)
            {
                if (s != 0)
                {
                    for (int i = 0; i < pun; i++)
                    {
                        if (signos[i] == "*")
                        {
                            resul = Convert.ToDouble(vectoraux[i]) * Convert.ToDouble(vectoraux[i + 1]);
                            vectoraux[i] = resul.ToString();
                            vectoraux = eliminar(vectoraux, i + 1, tamaño);
                            signos = eliminar(signos, i, pun);
                            tamaño--;
                            pun--;
                            s--;
                            break;
                        }
                        if(signos[i] == "/")
                        {
                            resul = Convert.ToDouble(vectoraux[i]) / Convert.ToDouble(vectoraux[i + 1]);
                            vectoraux[i] = resul.ToString();
                            vectoraux = eliminar(vectoraux, i + 1, tamaño);
                            signos = eliminar(signos, i, pun);
                            tamaño--;
                            pun--;
                            s--;
                            break;
                        }
                        
                    }
                }
                else 
                {
                    for (int i = 0; i < pun; i++)

                    {
                        if (signos[i] == "+")
                        {
                            resul = Convert.ToDouble(vectoraux[i]) + Convert.ToDouble(vectoraux[i + 1]);
                        }
                        if (signos[i] == "-")
                        {
                            resul = Convert.ToDouble(vectoraux[i]) - Convert.ToDouble(vectoraux[i + 1]);
                        }
                        vectoraux[i] = resul.ToString();
                        vectoraux= eliminar(vectoraux, i + 1,tamaño);
                        signos= eliminar(signos, i,pun);
                        tamaño--;
                        pun--;
                        break;
                    }
                }
            }
            textBox2.Text=vectoraux[0];
        }
        private String[] eliminar(String[] v,int p,int punt)
        {
            for (int i = 0; i < punt; i++)
            {
                if (i == p)
                {
                    for (int j = p; j < punt - 1; j++)
                    {
                        v[j] = v[j + 1];
                    }
                } 
            }
            return v;
        }
        private int conteo(String[] v,int cont)
        {
            int conti = 0;
            for (int i = 0; i < cont; i++)
            {
                if (v[i]=="*"||v[i]=="/")
                {
                    conti++;
                }
            }
            return conti;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int tamaño = total.Length;
            if (tamaño!=0)
            {
                total = total.Substring(0, tamaño - 1);
                textBox1.Text = total;
            }
            
        }
    }
}
