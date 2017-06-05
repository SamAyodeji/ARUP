namespace CPM
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
            this.btn_save_cpm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.txtb_projectname = new System.Windows.Forms.TextBox();
            this.btn_cancel_cpm = new System.Windows.Forms.Button();
            this.txtb_project_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_quality_test = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_expentiture = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_income = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_material_cost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btn_save_cpm
            // 
            this.btn_save_cpm.Location = new System.Drawing.Point(371, 225);
            this.btn_save_cpm.Name = "btn_save_cpm";
            this.btn_save_cpm.Size = new System.Drawing.Size(75, 23);
            this.btn_save_cpm.TabIndex = 0;
            this.btn_save_cpm.Text = "Save";
            this.btn_save_cpm.UseVisualStyleBackColor = true;
            this.btn_save_cpm.Click += new System.EventHandler(this.btn_save_cpm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Egineer\'s name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project Name";
            // 
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(122, 72);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(176, 20);
            this.txtb_name.TabIndex = 3;
            this.txtb_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtb_projectname
            // 
            this.txtb_projectname.Location = new System.Drawing.Point(122, 104);
            this.txtb_projectname.Name = "txtb_projectname";
            this.txtb_projectname.Size = new System.Drawing.Size(176, 20);
            this.txtb_projectname.TabIndex = 4;
            // 
            // btn_cancel_cpm
            // 
            this.btn_cancel_cpm.Location = new System.Drawing.Point(223, 225);
            this.btn_cancel_cpm.Name = "btn_cancel_cpm";
            this.btn_cancel_cpm.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_cpm.TabIndex = 5;
            this.btn_cancel_cpm.Text = "Cancel";
            this.btn_cancel_cpm.UseVisualStyleBackColor = true;
            // 
            // txtb_project_id
            // 
            this.txtb_project_id.Location = new System.Drawing.Point(122, 134);
            this.txtb_project_id.Name = "txtb_project_id";
            this.txtb_project_id.Size = new System.Drawing.Size(176, 20);
            this.txtb_project_id.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Job Identification :";
            // 
            // txtb_quality_test
            // 
            this.txtb_quality_test.Location = new System.Drawing.Point(122, 169);
            this.txtb_quality_test.Name = "txtb_quality_test";
            this.txtb_quality_test.Size = new System.Drawing.Size(176, 20);
            this.txtb_quality_test.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quality Test Count";
            // 
            // txtb_expentiture
            // 
            this.txtb_expentiture.Location = new System.Drawing.Point(461, 72);
            this.txtb_expentiture.Name = "txtb_expentiture";
            this.txtb_expentiture.Size = new System.Drawing.Size(173, 20);
            this.txtb_expentiture.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Expenditure";
            // 
            // txtb_income
            // 
            this.txtb_income.Location = new System.Drawing.Point(461, 117);
            this.txtb_income.Name = "txtb_income";
            this.txtb_income.Size = new System.Drawing.Size(173, 20);
            this.txtb_income.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Income";
            // 
            // txtb_material_cost
            // 
            this.txtb_material_cost.Location = new System.Drawing.Point(461, 162);
            this.txtb_material_cost.Name = "txtb_material_cost";
            this.txtb_material_cost.Size = new System.Drawing.Size(173, 20);
            this.txtb_material_cost.TabIndex = 15;
            this.txtb_material_cost.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Material Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(118, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(412, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Please fill the form below to have access to the JOB FILE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 321);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtb_material_cost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtb_income);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_expentiture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_quality_test);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb_project_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancel_cpm);
            this.Controls.Add(this.txtb_projectname);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save_cpm);
            this.Name = "Form1";
            this.Text = "CPM FORM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save_cpm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.TextBox txtb_projectname;
        private System.Windows.Forms.Button btn_cancel_cpm;
        private System.Windows.Forms.TextBox txtb_project_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_quality_test;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_expentiture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_income;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb_material_cost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

