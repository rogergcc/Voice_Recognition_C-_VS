namespace Pr_SpeechRecognition
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
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnspeak = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(12, 12);
            this.txtArea.Multiline = true;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(403, 277);
            this.txtArea.TabIndex = 0;
            // 
            // btnspeak
            // 
            this.btnspeak.Location = new System.Drawing.Point(25, 310);
            this.btnspeak.Name = "btnspeak";
            this.btnspeak.Size = new System.Drawing.Size(75, 39);
            this.btnspeak.TabIndex = 1;
            this.btnspeak.Text = "speak";
            this.btnspeak.UseVisualStyleBackColor = true;
            this.btnspeak.Click += new System.EventHandler(this.btnspeak_Click);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(135, 310);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 39);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(331, 310);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 39);
            this.btnstop.TabIndex = 3;
            this.btnstop.Text = "stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 419);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btnspeak);
            this.Controls.Add(this.txtArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnspeak;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
    }
}

