namespace T_L_EKZ
{
    partial class FormWorkers
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
            this.workersControl1 = new T_L_EKZ.WorkersControl();
            this.workersControl2 = new T_L_EKZ.WorkersControl();
            this.workersControl3 = new T_L_EKZ.WorkersControl();
            this.workersControl4 = new T_L_EKZ.WorkersControl();
            this.leftbutton = new System.Windows.Forms.Button();
            this.rigthbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workersControl1
            // 
            this.workersControl1.Location = new System.Drawing.Point(86, 12);
            this.workersControl1.Name = "workersControl1";
            this.workersControl1.Size = new System.Drawing.Size(378, 344);
            this.workersControl1.TabIndex = 0;
            // 
            // workersControl2
            // 
            this.workersControl2.Location = new System.Drawing.Point(640, 12);
            this.workersControl2.Name = "workersControl2";
            this.workersControl2.Size = new System.Drawing.Size(378, 344);
            this.workersControl2.TabIndex = 1;
            // 
            // workersControl3
            // 
            this.workersControl3.Location = new System.Drawing.Point(86, 325);
            this.workersControl3.Name = "workersControl3";
            this.workersControl3.Size = new System.Drawing.Size(378, 344);
            this.workersControl3.TabIndex = 2;
            // 
            // workersControl4
            // 
            this.workersControl4.Location = new System.Drawing.Point(640, 325);
            this.workersControl4.Name = "workersControl4";
            this.workersControl4.Size = new System.Drawing.Size(378, 344);
            this.workersControl4.TabIndex = 3;
            // 
            // leftbutton
            // 
            this.leftbutton.Location = new System.Drawing.Point(12, 273);
            this.leftbutton.Name = "leftbutton";
            this.leftbutton.Size = new System.Drawing.Size(29, 178);
            this.leftbutton.TabIndex = 4;
            this.leftbutton.Text = "<";
            this.leftbutton.UseVisualStyleBackColor = true;
            this.leftbutton.Click += new System.EventHandler(this.leftbutton_Click);
            // 
            // rigthbutton
            // 
            this.rigthbutton.Location = new System.Drawing.Point(1050, 273);
            this.rigthbutton.Name = "rigthbutton";
            this.rigthbutton.Size = new System.Drawing.Size(29, 178);
            this.rigthbutton.TabIndex = 5;
            this.rigthbutton.Text = ">";
            this.rigthbutton.UseVisualStyleBackColor = true;
            this.rigthbutton.Click += new System.EventHandler(this.rigthbutton_Click);
            // 
            // FormWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 663);
            this.Controls.Add(this.rigthbutton);
            this.Controls.Add(this.leftbutton);
            this.Controls.Add(this.workersControl4);
            this.Controls.Add(this.workersControl3);
            this.Controls.Add(this.workersControl2);
            this.Controls.Add(this.workersControl1);
            this.Name = "FormWorkers";
            this.Text = "FormWorkers";
            this.Load += new System.EventHandler(this.Workers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WorkersControl workersControl1;
        private WorkersControl workersControl2;
        private WorkersControl workersControl3;
        private WorkersControl workersControl4;
        private System.Windows.Forms.Button leftbutton;
        private System.Windows.Forms.Button rigthbutton;
    }
}