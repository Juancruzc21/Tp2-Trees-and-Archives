using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casais_Tp2_Pt1__ARBOLES_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Nodo raiz;
        Nodo seleccionado;

        Nodo crearNodo()
        {
            string nombre = Interaction.InputBox("Ingrese nombre del nodo");
            return new Nodo(nombre);
        }

        void CambiarSeleccion(Nodo n)
        {
            seleccionado = n;
            this.lblNombreNodo.Text = n.Nombre;
        }

        void EvaluarArbol()
        {
            this.lblAltura.Text = $"Altura:{Alto(raiz)}";
            int inicio = 0;
            this.lblAncho.Text = $"Ancho:{Ancho(raiz, ref inicio)}";
        }

        int Ancho(Nodo n, ref int ancho)
        {
            if (n.Derecha == null && n.Izquierda == null)
                ancho += 1;

            if (n.Derecha != null) Ancho(n.Derecha, ref ancho);
            if (n.Izquierda != null) Ancho(n.Izquierda, ref ancho);

            return ancho;
        }
        int Alto(Nodo n)
        {
            if (n == null) return 0;

            int izq = Alto(n.Izquierda) + 1;
            int der = Alto(n.Derecha) + 1;
            return Math.Max(izq, der);
        }

        public void LlenarTreeView()
        {
            treeView1.Nodes.Clear();
            MostrarNodo(raiz, null, string.Empty);
            treeView1.ExpandAll();
            EvaluarArbol();
        }

        public void MostrarNodo(Nodo n, TreeNode tnpadre, string lado)
        {
            if (n == null) return;

            TreeNode nuevo = new TreeNode();
            if (tnpadre == null && lado == String.Empty)
            {
                tnpadre = new TreeNode();
                nuevo.Text = n.Nombre;
                nuevo.Tag = n;
                treeView1.Nodes.Add(nuevo);
            }
            else
            {

                nuevo.Text = $"{lado} - {n.Nombre}";
                nuevo.Tag = n;

                tnpadre.Nodes.Add(nuevo);
            }

            if (n.Derecha != null) MostrarNodo(n.Derecha, nuevo, "D");
            if (n.Izquierda != null) MostrarNodo(n.Izquierda, nuevo, "I");
        }

        void Visitar(Nodo n)
        {
            this.txtRecorrido.Text += "-" + n.Nombre;
        }

        //CODEO DE LOS BOTONES

        private void btnAgregarRaiz_Click(object sender, EventArgs e)
        {
            if (raiz != null)
            {
                DialogResult r = MessageBox.Show("Se eliminará el árbol, desea continuar?", "Consulta", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    raiz = crearNodo();

                }
            }
            else
            {
                raiz = crearNodo();
            }

            CambiarSeleccion(raiz);
            LlenarTreeView();
        }

        

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CambiarSeleccion((Nodo)e.Node.Tag);
        }

        private void btnAgregarIzquierda_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                seleccionado.Izquierda = crearNodo();
                LlenarTreeView();
            }
            else
                MessageBox.Show("Debe tener algun nodo seleccionado");
        }

        private void btnAgregarDerecha_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                seleccionado.Derecha = crearNodo();
                LlenarTreeView();
            }
            else
                MessageBox.Show("Debe tener algun nodo seleccionado");
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            this.txtRecorrido.Text = string.Empty;
            RecorridoPreOrden(raiz);
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            this.txtRecorrido.Text = string.Empty;
            RecorridoInOrden(raiz);
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            this.txtRecorrido.Text = string.Empty;
            RecorridoPostOrden(raiz);
        }

        private void btnAmplitud_Click(object sender, EventArgs e)
        {
            this.txtRecorrido.Text = string.Empty;
            RecorridoAmplitud(raiz);
        }

        //Codigo de los recorridos 

        void RecorridoPreOrden(Nodo n)
        {
            Visitar(n);
            if (n.Izquierda != null) RecorridoPreOrden(n.Izquierda);
            if (n.Derecha != null) RecorridoPreOrden(n.Derecha);
        }

        void RecorridoInOrden(Nodo n)
        {
            if (n.Izquierda != null) RecorridoInOrden(n.Izquierda);
            Visitar(n);
            if (n.Derecha != null) RecorridoInOrden(n.Derecha);
        }

        void RecorridoPostOrden(Nodo n)
        {
            if (n.Izquierda != null) RecorridoPostOrden(n.Izquierda);
            if (n.Derecha != null) RecorridoPostOrden(n.Derecha);
            Visitar(n);
        }

        void RecorridoAmplitud(Nodo n)
        {
            if (n == null) return;

            Queue<Nodo> cola = new Queue<Nodo>();
            
            cola.Enqueue(n);

            while (cola.Count > 0)
            {
                Nodo nodoActual = cola.Dequeue();
                Visitar(nodoActual);

                if (nodoActual.Izquierda != null)
                    cola.Enqueue(nodoActual.Izquierda);

                if (nodoActual.Derecha != null)
                    cola.Enqueue(nodoActual.Derecha);
            }
        }


        //placeholder
    }
}
