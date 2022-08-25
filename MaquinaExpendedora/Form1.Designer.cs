
namespace MaquinaExpendedora
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnApagarMaquina = new System.Windows.Forms.Button();
            this.btnRellenarMaquina = new System.Windows.Forms.Button();
            this.btnVerChucherias = new System.Windows.Forms.Button();
            this.btnComprarChucherias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // btnApagarMaquina
            // 
            this.btnApagarMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnApagarMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarMaquina.ForeColor = System.Drawing.Color.White;
            this.btnApagarMaquina.Image = global::MaquinaExpendedora.Properties.Resources.systemshutdown_103390;
            this.btnApagarMaquina.Location = new System.Drawing.Point(318, 156);
            this.btnApagarMaquina.Name = "btnApagarMaquina";
            this.btnApagarMaquina.Size = new System.Drawing.Size(241, 96);
            this.btnApagarMaquina.TabIndex = 28;
            this.btnApagarMaquina.Text = " Apagar la máquina.";
            this.btnApagarMaquina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagarMaquina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApagarMaquina.UseVisualStyleBackColor = false;
            this.btnApagarMaquina.Click += new System.EventHandler(this.btnApagarMaquina_Click);
            // 
            // btnRellenarMaquina
            // 
            this.btnRellenarMaquina.BackColor = System.Drawing.Color.Teal;
            this.btnRellenarMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRellenarMaquina.ForeColor = System.Drawing.Color.White;
            this.btnRellenarMaquina.Image = global::MaquinaExpendedora.Properties.Resources.vending_machine_snacks_beverages_drinks_technology_icon_128568;
            this.btnRellenarMaquina.Location = new System.Drawing.Point(28, 156);
            this.btnRellenarMaquina.Name = "btnRellenarMaquina";
            this.btnRellenarMaquina.Size = new System.Drawing.Size(241, 96);
            this.btnRellenarMaquina.TabIndex = 27;
            this.btnRellenarMaquina.Text = "Rellenar la máquina.";
            this.btnRellenarMaquina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRellenarMaquina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRellenarMaquina.UseVisualStyleBackColor = false;
            this.btnRellenarMaquina.Click += new System.EventHandler(this.btnRellenarMaquina_Click);
            // 
            // btnVerChucherias
            // 
            this.btnVerChucherias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVerChucherias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerChucherias.ForeColor = System.Drawing.Color.White;
            this.btnVerChucherias.Image = global::MaquinaExpendedora.Properties.Resources.view_search_find_9565;
            this.btnVerChucherias.Location = new System.Drawing.Point(318, 26);
            this.btnVerChucherias.Name = "btnVerChucherias";
            this.btnVerChucherias.Size = new System.Drawing.Size(241, 96);
            this.btnVerChucherias.TabIndex = 26;
            this.btnVerChucherias.Text = "Ver las chucherías disponibles en la máquina.";
            this.btnVerChucherias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerChucherias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerChucherias.UseVisualStyleBackColor = false;
            this.btnVerChucherias.Click += new System.EventHandler(this.btnVerChucherias_Click);
            // 
            // btnComprarChucherias
            // 
            this.btnComprarChucherias.BackColor = System.Drawing.Color.Green;
            this.btnComprarChucherias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarChucherias.ForeColor = System.Drawing.Color.White;
            this.btnComprarChucherias.Image = global::MaquinaExpendedora.Properties.Resources.buyhand_106610;
            this.btnComprarChucherias.Location = new System.Drawing.Point(28, 26);
            this.btnComprarChucherias.Name = "btnComprarChucherias";
            this.btnComprarChucherias.Size = new System.Drawing.Size(241, 96);
            this.btnComprarChucherias.TabIndex = 25;
            this.btnComprarChucherias.Text = "Comprar chucherías de la máquina.";
            this.btnComprarChucherias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprarChucherias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprarChucherias.UseVisualStyleBackColor = false;
            this.btnComprarChucherias.Click += new System.EventHandler(this.btnComprarChucherias_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 277);
            this.Controls.Add(this.btnApagarMaquina);
            this.Controls.Add(this.btnRellenarMaquina);
            this.Controls.Add(this.btnVerChucherias);
            this.Controls.Add(this.btnComprarChucherias);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Máquina expendedora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApagarMaquina;
        private System.Windows.Forms.Button btnRellenarMaquina;
        private System.Windows.Forms.Button btnVerChucherias;
        private System.Windows.Forms.Button btnComprarChucherias;
    }
}

