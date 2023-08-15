using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculoDeRafagasCPU
{
    public static class Variables

    {
        public static List<int> listaSJF = new List<int>();       
        public static List<decimal> tiempoEspera = new List<decimal>();
        public static List<decimal> tiempoRetorno = new List<decimal>();
        public static List<string> trabajoProcesos = new List<string>();
        public static List<int> listaPrioridadOrdenada = new List<int>();

        public static List<int> listaPrioridad = new List<int>();

        public static Random Prioridad = new Random();
        


        

        public static decimal Filas = 0;
        public static int filaTablaProcesos = 0;
        
        public static decimal contadorFilaProceso = 0;
        public static decimal tiempoDeEspera = 0;
        public static int tipoDeAlgoritmo = 1;

        public static int valorQuantum;

        

        public static decimal resultadoTME = 0, resultadoTMR = 0;

        public static int sumaTablaRecorrido = 0;
        

        public static decimal totalProcesos = 0;

        public static decimal tiempoEsperaP1 = 0, tiempoEsperaP2 = 0 ,tiempoEsperaP3 = 0, tiempoEsperaP4 = 0, tiempoEsperaP5 = 0;

        public static decimal tiempoRetornoP1 = 0, tiempoRetornoP2 = 0, tiempoRetornoP3 = 0, tiempoRetornoP4 = 0, tiempoRetornoP5 = 0;

       

        

        

        

    }
}
