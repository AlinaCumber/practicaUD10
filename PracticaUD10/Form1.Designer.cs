
namespace PracticaUD10
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.tSocios = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LSocios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(129, 67);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(146, 20);
            this.tNombre.TabIndex = 0;
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(511, 67);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(179, 20);
            this.tApellidos.TabIndex = 1;
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(511, 143);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(179, 20);
            this.tTelefono.TabIndex = 2;
            // 
            // tSocios
            // 
            this.tSocios.Location = new System.Drawing.Point(36, 246);
            this.tSocios.Multiline = true;
            this.tSocios.Name = "tSocios";
            this.tSocios.ReadOnly = true;
            this.tSocios.Size = new System.Drawing.Size(693, 148);
            this.tSocios.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LNombre.Location = new System.Drawing.Point(32, 67);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(79, 24);
            this.LNombre.TabIndex = 5;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LApellido.Location = new System.Drawing.Point(416, 67);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(79, 24);
            this.LApellido.TabIndex = 6;
            this.LApellido.Text = "Apellido";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LTelefono.Location = new System.Drawing.Point(416, 143);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(58, 24);
            this.LTelefono.TabIndex = 7;
            this.LTelefono.Text = "Mo\'vil\r\n";
            this.LTelefono.Click += new System.EventHandler(this.LTelefono_Click);
            // 
            // LSocios
            // 
            this.LSocios.AutoSize = true;
            this.LSocios.Location = new System.Drawing.Point(33, 214);
            this.LSocios.Name = "LSocios";
            this.LSocios.Size = new System.Drawing.Size(64, 13);
            this.LSocios.TabIndex = 8;
            this.LSocios.Text = "Lista Socios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LSocios);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tSocios);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.tNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.TextBox tSocios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LSocios;
    }
}

