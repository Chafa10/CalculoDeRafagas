using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CalculoDeRafagasCPU;
using Metodos;

namespace CalculoDeRafagasCPU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        int validar;
        private void btn_IngresoProcesos_Click(object sender, EventArgs e)
        {
            ValidaCampos();

            if (validar == 0)
            {
                MessageBox.Show("Error al ingresar alguno de los datos a la tabla", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (validar == 1)
            {
                if (rdb_AlgoritmoRR.Checked == true)
                {

                    try
                    {
                        Convert.ToInt32(txt_Quantum.Text);
                        validar = 1;
                        if (Convert.ToInt32(txt_Quantum.Text) == 0 || txt_Quantum.Text == "")
                        {
                            validar = 0;
                            MessageBox.Show("El valor del QUANTUM debe ser mayor a 0","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Falta ingresar el valor del quantum", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        validar = 0;

                    }
                    
                    
                }
                if (validar == 1)
                {
                    PasarNumeros();
                    switch (Variables.tipoDeAlgoritmo)
                    {
                        case 1:

                            dgv_Tabla.Rows.Add(Convert.ToInt32(Variables.listaSJF.Count));
                            dgv_Tabla.ClearSelection();

                            ////Calculo
                            Funciones.TME();



                            for (int i = 0; i < Variables.listaSJF.Count; i++)
                            {

                                Variables.contadorFilaProceso++;

                                // Cargando Primer Tabla
                                dgv_DatosProcesos.Rows[i].Cells[0].Value = "P" + Variables.contadorFilaProceso;
                                dgv_DatosProcesos.Rows[i].Cells[1].Value = Variables.listaSJF[i];
                                dgv_DatosProcesos.Rows[i].Cells[2].Value = Variables.listaPrioridad[i];

                                //Cargando segunda tabla
                                dgv_Tabla.Rows[i].Cells[0].Value = "P" + Variables.contadorFilaProceso;
                                dgv_Tabla.Rows[i].Cells[1].Value = Variables.tiempoEspera[i];
                                dgv_Tabla.Rows[i].Cells[2].Value = Variables.tiempoRetorno[i];



                                SacarTiempos();
                            }
                            break;

                        case 2:

                            //SJF

                            //Primera Tabla
                            for (int i = 0; i < Variables.listaSJF.Count; i++)
                            {
                                Variables.contadorFilaProceso++;
                                
                                dgv_DatosProcesos.Rows[i].Cells[0].Value = "P" + Variables.contadorFilaProceso;
                                dgv_DatosProcesos.Rows[i].Cells[1].Value = Variables.listaSJF[i];
                                dgv_DatosProcesos.Rows[i].Cells[2].Value = Variables.listaPrioridad[i];

                            }

                            List<int> tCPU_SJF = new List<int>();
                            for (int i = 0; i < dgv_DatosProcesos.Rows.Count; i++) tCPU_SJF.Add(Pasar(1, i));
                            tCPU_SJF.Sort();

                            dgv_Tabla.Rows.Add(tCPU_SJF.Count);


                            //cuando las rafagas son iguales cambio el indice de acuerdo con el proceso que entre primero
                            for (int a = 0; a < dgv_DatosProcesos.Rows.Count; a++)
                            {
                                int index = tCPU_SJF.IndexOf(Pasar(1, a)); // le paso el indice de mi lista de rafaga ordenada
                                tCPU_SJF[index] = -1;
                              
                                
                                dgv_Tabla[0, index].Value = dgv_DatosProcesos[0, a].Value.ToString();// pongo en la columna 0 el proceso ordenado de menor a mayor por rafaga
                                
                            }

                            int Suma = 0;
                            for (int a = 0; a < dgv_DatosProcesos.Rows.Count; a++)
                            {
                                dgv_Tabla[1, a].Value = Suma; //paso el timepo que espero cada proceso

                                for (int l = 0; l < dgv_DatosProcesos.Rows.Count; l++)
                                {
                                    if (dgv_DatosProcesos[0, l].Value.ToString() == dgv_Tabla[0, a].Value.ToString())
                                    {
                                        Suma += Pasar(1, l);
                                        break;
                                    }
                                }
                                dgv_Tabla[2, a].Value = Suma;




                            }

                            // Funciones.TME();


                            //for (int i = 0; i < dgv_DatosProcesos.RowCount; i++)
                            //{
                            //    Variables.trabajoProcesos.Add(Convert.ToString(dgv_DatosProcesos.Rows[i].Cells[0].Value));
                            //}
                            ////Segunda tabla
                            //for (int i = 0; i < Variables.listaSJF.Count; i++)
                            //{
                                
                            //    dgv_Tabla.Rows[i].Cells[1].Value = Variables.tiempoEspera[i];
                            //    dgv_Tabla.Rows[i].Cells[2].Value = Variables.tiempoRetorno[i];
                            //}

                            
                           

                           

                            SacarTiempos();
                            break;

                        case 3:

                            //Prioridad
                            //Primera Tabla
                            List<int> prioridad = new List<int>();
                            for (int i = 0; i < Variables.listaSJF.Count; i++)
                            {

                                Variables.contadorFilaProceso++;
                                // Cargando Primer Tabla
                                dgv_DatosProcesos.Rows[i].Cells[0].Value = "P" + Variables.contadorFilaProceso;
                                dgv_DatosProcesos.Rows[i].Cells[1].Value = Variables.listaSJF[i];
                                dgv_DatosProcesos.Rows[i].Cells[2].Value = Variables.listaPrioridad[i];
                            }

                            List<int> tCPU_Prioridad = new List<int>();
                            for (int i = 0; i < dgv_DatosProcesos.Rows.Count; i++) tCPU_Prioridad.Add(Pasar(2, i));
                            tCPU_Prioridad.Sort();

                            dgv_Tabla.Rows.Add(tCPU_Prioridad.Count);

                            for (int a = 0; a < dgv_DatosProcesos.Rows.Count; a++)
                            {
                                int index = tCPU_Prioridad.IndexOf(Pasar(2, a));
                                tCPU_Prioridad[index] = -1;
                                dgv_Tabla[0, index].Value = dgv_DatosProcesos[0, a].Value.ToString();
                            }
                            for (int a = 0; a < dgv_DatosProcesos.Rows.Count; a++)
                            {
                                dgv_Tabla[1, a].Value = Variables.sumaTablaRecorrido;
                                for (int l = 0; l < dgv_DatosProcesos.Rows.Count; l++)
                                {
                                    if (dgv_DatosProcesos[0, l].Value.ToString() == dgv_Tabla[0, a].Value.ToString())
                                    {
                                        Variables.sumaTablaRecorrido += Pasar(1, l);
                                        break;
                                    }
                                }


                                dgv_Tabla[2, a].Value = Variables.sumaTablaRecorrido;

                            }

                            // for (int i = 0; i < dgv_DatosProcesos.RowCount; i++)
                            //{
                            //    //Variables.trabajoProcesos.Add(Convert.ToString(dgv_DatosProcesos.Rows[i].Cells[0].Value));
                            //    Variables.listaPrioridadOrdenada.Add(Convert.ToInt32(dgv_DatosProcesos.Rows[i].Cells[1].Value));
                            //}
                            //Funciones.TMEPrioridad();
                            ////Segunda Tabla

                            //for (int i = 0; i < Variables.listaSJF.Count; i++)
                            //{

                            //    //dgv_Tabla.Rows[i].Cells[0].Value = Variables.trabajoProcesos[i];
                            //    dgv_Tabla.Rows[i].Cells[1].Value = Variables.tiempoEspera[i];
                            //    dgv_Tabla.Rows[i].Cells[2].Value = Variables.tiempoRetorno[i];
                            //}


                           
                            SacarTiempos();
                            break;

                        case 4:

                            //Round Robin

                            

                            int Quantum = Convert.ToInt32(txt_Quantum.Text);
                            //primer tabla
                            for (int i = 0; i < Variables.listaSJF.Count; i++)
                            {

                                Variables.contadorFilaProceso++;
                                // Cargando Primer Tabla
                                dgv_DatosProcesos.Rows[i].Cells[0].Value = "P" + Variables.contadorFilaProceso;
                                dgv_DatosProcesos.Rows[i].Cells[1].Value = Variables.listaSJF[i];
                                dgv_DatosProcesos.Rows[i].Cells[2].Value = Variables.listaPrioridad[i];
                            }

                            for (int i = 0; i < dgv_DatosProcesos.Rows.Count; i++)
                            {
                                dgv_Tabla.Rows.Add("P" + (i + 1));
                            }
                            //for (int i = 0; i < dgv_DatosProcesos.Rows.Count; i++)
                            //{
                            //    dgv_Tabla.Rows[i].Cells[0].Value = ("P" + (i + 1));
                            //}

                            int fila = 0, Cont = 0, Cont2 = 0;
                            int[] TablaAxiliar = new int[dgv_DatosProcesos.Rows.Count]; // creo la tabla auxiliar
                            for (int i = 0; i < dgv_DatosProcesos.Rows.Count; i++)
                            {
                                TablaAxiliar[i] = Convert.ToInt32(dgv_DatosProcesos[1, i].Value); // le paso los valores de las rafagas a la tabla
                            }

                            bool vuelta = false;
                            for (; ; )
                            {
                                if (TablaAxiliar[fila] >= Quantum)
                                {
                                    Cont++;
                                    Cont2++;
                                    dgv_TablaRecorrido.Columns.Add("P" + Cont2, "P" + (fila + 1));
                                    if (dgv_TablaRecorrido.Rows.Count < 1) dgv_TablaRecorrido.Rows.Add();
                                    TablaAxiliar[fila] -= Quantum;
                                    if (Cont == 5) Cont = 0;
                                    Variables.sumaTablaRecorrido += Quantum;
                                    dgv_TablaRecorrido[Cont2 - 1, 0].Value = Variables.sumaTablaRecorrido;
                                    vuelta = true;
                                }
                                else if (TablaAxiliar[fila] < Quantum & TablaAxiliar[fila] > 0)
                                {
                                    Cont++;
                                    Cont2++;
                                    dgv_TablaRecorrido.Columns.Add("P" + Cont2, "P" + (fila + 1));
                                    if (dgv_TablaRecorrido.Rows.Count < 1) dgv_TablaRecorrido.Rows.Add();
                                    Variables.sumaTablaRecorrido += TablaAxiliar[fila];
                                    dgv_TablaRecorrido[Cont2 - 1, 0].Value = Variables.sumaTablaRecorrido;
                                    TablaAxiliar[fila] -= TablaAxiliar[fila];
                                    if (Cont == 5) Cont = 0;
                                    vuelta = true;
                                }

                                fila++;
                                if (fila == dgv_DatosProcesos.Rows.Count & vuelta == false) break;
                                if (fila == dgv_DatosProcesos.Rows.Count)
                                {
                                    fila = 0;
                                    vuelta = false;
                                }
                            }

                            for (int i = 0; i < dgv_DatosProcesos.Rows.Count; i++)
                            {
                                for (int a = 0; a < dgv_TablaRecorrido.Columns.Count; a++)
                                {
                                    int index = (dgv_TablaRecorrido.Columns.Count - 1) - a;
                                    if (dgv_TablaRecorrido.Columns[index].HeaderText == dgv_DatosProcesos[0, i].Value.ToString())
                                    {
                                        dgv_Tabla[2, i].Value = dgv_TablaRecorrido[index, 0].Value.ToString();
                                        break;
                                    }

                                }
                            }

                            for (int i = 0; i < dgv_DatosProcesos.Rows.Count; i++)
                            {
                                int cuantos = 0, calculo = 0, index2 = 0, total = 0;
                                bool tomado = false;
                                for (int a = 0; a < dgv_TablaRecorrido.Columns.Count; a++)
                                {

                                    int index = (dgv_TablaRecorrido.Columns.Count - 1) - a;
                                    if (dgv_DatosProcesos[0, i].Value.ToString() == dgv_TablaRecorrido.Columns[index].HeaderText)
                                    {
                                        cuantos++;
                                        index2 = index;
                                        if (tomado == true)
                                        {
                                            tomado = false;
                                            calculo -= Convert.ToInt32(dgv_TablaRecorrido[index, 0].Value);
                                            total += calculo;

                                        }
                                        if ((index - 1) > -1 & tomado == false)
                                        {
                                            calculo = Convert.ToInt32(dgv_TablaRecorrido[index - 1, 0].Value);
                                            tomado = true;

                                        }

                                    }
                                }
                                if (cuantos > 1)
                                {
                                    if ((i - 1) > -1)
                                    {
                                        dgv_Tabla[1, i].Value = Convert.ToInt32(dgv_Tabla[2, i - 1].Value) + total;
                                    }
                                    else dgv_Tabla[1, i].Value = "0";
                                }
                                if (cuantos == 1)
                                {
                                    if ((index2 - 1) > -1)
                                        dgv_Tabla[1, i].Value = dgv_TablaRecorrido[index2 - 1, 0].Value.ToString();
                                    else dgv_Tabla[1, i].Value = "0";
                                }
                            }

                            SacarTiempos();
                            break;
                    }
                }
            }
        }

        private int Pasar(int C, int F)
        {
            return Convert.ToInt32(dgv_DatosProcesos[C, F].Value);
        }
        
        private void rdb_AlgoritmoFCFS_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_AlgoritmoFCFS.Checked == true)
            {
                Variables.tipoDeAlgoritmo = 1;
                btn_IngresoProcesos.Enabled = true;
            }           
        }

        private void rdb_AlgoritmoSJF_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_AlgoritmoSJF.Checked == true)
            {
                Variables.tipoDeAlgoritmo = 2;
            }
            
        }

        private void rdb_AlgoritmoPrioridad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_AlgoritmoPrioridad.Checked == true)
            {
                Variables.tipoDeAlgoritmo = 3;
            }
            
        }

        private void rdb_AlgoritmoRR_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_AlgoritmoRR.Checked == true)
            {
                Variables.tipoDeAlgoritmo = 4;
            }            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SacarTiempos()
        {
            double sumaTME = 0, sumaTMR = 0;
            for (int i = 0; i < Variables.listaSJF.Count ; i++)
            {
                sumaTME += Convert.ToDouble(dgv_Tabla[1, i].Value);
                sumaTMR += Convert.ToDouble(dgv_Tabla[2, i].Value);
            }

            lbl_TME.Text = (sumaTME / dgv_Tabla.Rows.Count).ToString();
            lbl_TMR.Text = (sumaTMR / dgv_Tabla.Rows.Count).ToString();
        }

        private void ValidarDatos(object sender, KeyPressEventArgs e)
        {
            Funciones.NumerosSolo(e);
        }

        public void ValidaCampos()
        {           
            try
            {
                Convert.ToInt32(txt_CPU1.Text);
                Convert.ToInt32(txt_CPU2.Text);
                Convert.ToInt32(txt_CPU3.Text);
                Convert.ToInt32(txt_CPU4.Text);
                Convert.ToInt32(txt_CPU5.Text);
                Convert.ToInt32(txt_Prioridad1.Text);
                Convert.ToInt32(txt_Prioridad2.Text);
                Convert.ToInt32(txt_Prioridad3.Text);
                Convert.ToInt32(txt_Prioridad4.Text);
                Convert.ToInt32(txt_Prioridad5.Text);
                
                validar = 1;
            }
            catch (Exception)
            {
                
                validar = 0;
            }          
        }
        public void PasarNumeros()
        {
            Variables.listaSJF.Add(Convert.ToInt32(txt_CPU1.Text));
            Variables.listaSJF.Add(Convert.ToInt32(txt_CPU2.Text));
            Variables.listaSJF.Add(Convert.ToInt32(txt_CPU3.Text));
            Variables.listaSJF.Add(Convert.ToInt32(txt_CPU4.Text));
            Variables.listaSJF.Add(Convert.ToInt32(txt_CPU5.Text));
            Variables.listaPrioridad.Add(Convert.ToInt32(txt_Prioridad1.Text));
            Variables.listaPrioridad.Add(Convert.ToInt32(txt_Prioridad2.Text));
            Variables.listaPrioridad.Add(Convert.ToInt32(txt_Prioridad3.Text));
            Variables.listaPrioridad.Add(Convert.ToInt32(txt_Prioridad4.Text));
            Variables.listaPrioridad.Add(Convert.ToInt32(txt_Prioridad5.Text));
            dgv_DatosProcesos.Rows.Add(Convert.ToInt32(Variables.listaSJF.Count));
            dgv_DatosProcesos.ClearSelection();
            gpb_Procesos.Enabled = false;
            gpb_algoritmos.Enabled = false;
            gpb_Prioridad.Enabled = false;
            btn_IngresoProcesos.Enabled = false;
        }

        private void validarDatoPrioridad(object sender, KeyPressEventArgs e)
        {
            Funciones.NumerosSolo(e);
        }

     
    }
}
