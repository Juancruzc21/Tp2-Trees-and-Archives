namespace Casais_Tp2_Pt1__ARBOLES_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAgregarRaiz = new System.Windows.Forms.Button();
            this.btnAgregarIzquierda = new System.Windows.Forms.Button();
            this.btnAgregarDerecha = new System.Windows.Forms.Button();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.btnAmplitud = new System.Windows.Forms.Button();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.btnInOrden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreNodo = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(16, 36);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 223);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnAgregarRaiz
            // 
            this.btnAgregarRaiz.Location = new System.Drawing.Point(207, 36);
            this.btnAgregarRaiz.Name = "btnAgregarRaiz";
            this.btnAgregarRaiz.Size = new System.Drawing.Size(95, 23);
            this.btnAgregarRaiz.TabIndex = 1;
            this.btnAgregarRaiz.Text = "Agregar Raiz";
            this.btnAgregarRaiz.UseVisualStyleBackColor = true;
            this.btnAgregarRaiz.Click += new System.EventHandler(this.btnAgregarRaiz_Click);
            // 
            // btnAgregarIzquierda
            // 
            this.btnAgregarIzquierda.Location = new System.Drawing.Point(178, 99);
            this.btnAgregarIzquierda.Name = "btnAgregarIzquierda";
            this.btnAgregarIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarIzquierda.TabIndex = 2;
            this.btnAgregarIzquierda.Text = "Izquierda";
            this.btnAgregarIzquierda.UseVisualStyleBackColor = true;
            this.btnAgregarIzquierda.Click += new System.EventHandler(this.btnAgregarIzquierda_Click);
            // 
            // btnAgregarDerecha
            // 
            this.btnAgregarDerecha.Location = new System.Drawing.Point(259, 99);
            this.btnAgregarDerecha.Name = "btnAgregarDerecha";
            this.btnAgregarDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDerecha.TabIndex = 3;
            this.btnAgregarDerecha.Text = "Derecha";
            this.btnAgregarDerecha.UseVisualStyleBackColor = true;
            this.btnAgregarDerecha.Click += new System.EventHandler(this.btnAgregarDerecha_Click);
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(16, 313);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(75, 23);
            this.btnPreOrden.TabIndex = 4;
            this.btnPreOrden.Text = "PreOrden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // btnAmplitud
            // 
            this.btnAmplitud.Location = new System.Drawing.Point(259, 313);
            this.btnAmplitud.Name = "btnAmplitud";
            this.btnAmplitud.Size = new System.Drawing.Size(75, 23);
            this.btnAmplitud.TabIndex = 5;
            this.btnAmplitud.Text = "Amplitud";
            this.btnAmplitud.UseVisualStyleBackColor = true;
            this.btnAmplitud.Click += new System.EventHandler(this.btnAmplitud_Click);
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.Location = new System.Drawing.Point(178, 313);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(75, 23);
            this.btnPostOrden.TabIndex = 6;
            this.btnPostOrden.Text = "PostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // btnInOrden
            // 
            this.btnInOrden.Location = new System.Drawing.Point(97, 313);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(75, 23);
            this.btnInOrden.TabIndex = 7;
            this.btnInOrden.Text = "InOrden";
            this.btnInOrden.UseVisualStyleBackColor = true;
            this.btnInOrden.Click += new System.EventHandler(this.btnInOrden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(182, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "AGREGAR NODO A LA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(13, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "RECORRER EN";
            // 
            // lblNombreNodo
            // 
            this.lblNombreNodo.AutoSize = true;
            this.lblNombreNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNodo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombreNodo.Location = new System.Drawing.Point(221, 166);
            this.lblNombreNodo.Name = "lblNombreNodo";
            this.lblNombreNodo.Size = new System.Drawing.Size(0, 18);
            this.lblNombreNodo.TabIndex = 10;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAltura.Location = new System.Drawing.Point(215, 241);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(0, 18);
            this.lblAltura.TabIndex = 11;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblAncho.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAncho.Location = new System.Drawing.Point(215, 202);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(0, 18);
            this.lblAncho.TabIndex = 12;
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.Location = new System.Drawing.Point(97, 359);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(156, 20);
            this.txtRecorrido.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(157, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nodo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(157, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ancho:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(157, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Altura:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(344, 413);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRecorrido);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblNombreNodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInOrden);
            this.Controls.Add(this.btnPostOrden);
            this.Controls.Add(this.btnAmplitud);
            this.Controls.Add(this.btnPreOrden);
            this.Controls.Add(this.btnAgregarDerecha);
            this.Controls.Add(this.btnAgregarIzquierda);
            this.Controls.Add(this.btnAgregarRaiz);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Casais Tp2 ARBOLES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAgregarRaiz;
        private System.Windows.Forms.Button btnAgregarIzquierda;
        private System.Windows.Forms.Button btnAgregarDerecha;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Button btnAmplitud;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.Button btnInOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreNodo;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

