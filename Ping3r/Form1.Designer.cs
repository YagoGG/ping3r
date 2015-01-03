namespace WindowsFormsApplication2
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_netstatusTitle = new System.Windows.Forms.Label();
            this.lb_netstatus = new System.Windows.Forms.Label();
            this.bt_run = new System.Windows.Forms.Button();
            this.pb_progress = new System.Windows.Forms.ProgressBar();
            this.tb_test = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_netstatusTitle
            // 
            this.lb_netstatusTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_netstatusTitle.AutoSize = true;
            this.lb_netstatusTitle.Location = new System.Drawing.Point(436, 9);
            this.lb_netstatusTitle.Name = "lb_netstatusTitle";
            this.lb_netstatusTitle.Size = new System.Drawing.Size(81, 13);
            this.lb_netstatusTitle.TabIndex = 2;
            this.lb_netstatusTitle.Text = "Network status:";
            // 
            // lb_netstatus
            // 
            this.lb_netstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_netstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_netstatus.ForeColor = System.Drawing.Color.Gray;
            this.lb_netstatus.Location = new System.Drawing.Point(382, 22);
            this.lb_netstatus.Name = "lb_netstatus";
            this.lb_netstatus.Size = new System.Drawing.Size(135, 13);
            this.lb_netstatus.TabIndex = 3;
            this.lb_netstatus.Text = "undefined";
            this.lb_netstatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt_run
            // 
            this.bt_run.Enabled = false;
            this.bt_run.Location = new System.Drawing.Point(21, 22);
            this.bt_run.Name = "bt_run";
            this.bt_run.Size = new System.Drawing.Size(75, 23);
            this.bt_run.TabIndex = 4;
            this.bt_run.Text = "Run";
            this.bt_run.UseVisualStyleBackColor = true;
            this.bt_run.Click += new System.EventHandler(this.bt_run_Click);
            // 
            // pb_progress
            // 
            this.pb_progress.Location = new System.Drawing.Point(116, 22);
            this.pb_progress.Name = "pb_progress";
            this.pb_progress.Size = new System.Drawing.Size(266, 23);
            this.pb_progress.TabIndex = 5;
            // 
            // tb_test
            // 
            this.tb_test.Location = new System.Drawing.Point(165, 103);
            this.tb_test.Name = "tb_test";
            this.tb_test.Size = new System.Drawing.Size(100, 20);
            this.tb_test.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(529, 210);
            this.Controls.Add(this.tb_test);
            this.Controls.Add(this.pb_progress);
            this.Controls.Add(this.bt_run);
            this.Controls.Add(this.lb_netstatus);
            this.Controls.Add(this.lb_netstatusTitle);
            this.Name = "MainForm";
            this.Text = "Ping3r";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_netstatusTitle;
        private System.Windows.Forms.Label lb_netstatus;
        private System.Windows.Forms.Button bt_run;
        private System.Windows.Forms.ProgressBar pb_progress;
        private System.Windows.Forms.TextBox tb_test;
    }
}

