using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculoDeRafagasCPU;
using System.Windows.Forms;


namespace Metodos
{
    public static class Funciones
    {
       


        public static void NumerosSolo(KeyPressEventArgs T)
        {
            if (Char.IsDigit(T.KeyChar))
            {
                T.Handled = false;
            }

            else if (Char.IsControl(T.KeyChar))
            {
                T.Handled = false;
            }
            else
            {
                T.Handled = true;
                MessageBox.Show("Solo introducir numeros", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        public static void TME()
        {
            for (int i = 0; i < Variables.listaSJF.Count; i++)
            {
                if (i == 0)
                {
                    Variables.tiempoRetorno.Add(Variables.tiempoEsperaP1 + Variables.listaSJF[i]);
                    
                }
                else 
                {
                    Variables.tiempoRetorno.Add(Variables.tiempoRetorno[(i-1)] + Variables.listaSJF[i]);

                }

                Variables.tiempoEspera.Add(Variables.tiempoRetorno[i] - Variables.listaSJF[i]);  
                             
            }
        }       

      

     

        public static void TMEPrioridad()
        {
            
        
            for (int i = 0; i < Variables.listaSJF.Count; i++)
            {
                if (i == 0)
                {
                    Variables.tiempoRetorno.Add(Variables.tiempoEsperaP1 + Variables.listaPrioridadOrdenada[i]);
                }
                else
                {
                    Variables.tiempoRetorno.Add(Variables.tiempoRetorno[(i - 1)] + Variables.listaPrioridadOrdenada[i]);
                }

                Variables.tiempoEspera.Add(Variables.tiempoRetorno[i] - Variables.listaPrioridadOrdenada[i]);
            }
        
        }

        

        


        //public List<decimal> TMRSJF1(List<decimal> listaEspera, List<decimal> listaRetorno, List<decimal> listaOrdenada)
        //{
        //    for (int i = 0; i < listaOrdenada.Count; i++)
        //    {
        //        listaEspera.Add(listaRetorno[i] - listaOrdenada[i]);
        //    }
        //    return listaEspera;
        //}


        
    }
}
