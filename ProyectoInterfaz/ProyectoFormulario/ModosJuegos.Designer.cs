
namespace ProyectoFormulario
{
    partial class ModosJuegos
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
            this.empezarTrivial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empezarTrivial
            // 
            this.empezarTrivial.Location = new System.Drawing.Point(53, 48);
            this.empezarTrivial.Name = "empezarTrivial";
            this.empezarTrivial.Size = new System.Drawing.Size(119, 23);
            this.empezarTrivial.TabIndex = 0;
            this.empezarTrivial.Text = "Trivial de preguntas";
            this.empezarTrivial.UseVisualStyleBackColor = true;
            this.empezarTrivial.Click += new System.EventHandler(this.empezarTrivial_Click);
            // 
            // ModosJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 450);
            this.Controls.Add(this.empezarTrivial);
            this.Name = "ModosJuegos";
            this.Text = "Modos de Juego";
            this.Load += new System.EventHandler(this.ModosJuegos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button empezarTrivial;
    }
}