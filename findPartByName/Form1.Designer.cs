namespace findPartByName
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
            this.txt_search_value = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_get_model = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_model_status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_name = new System.Windows.Forms.RadioButton();
            this.rb_position = new System.Windows.Forms.RadioButton();
            this.lbl_results = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_search_value
            // 
            this.txt_search_value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search_value.Enabled = false;
            this.txt_search_value.Location = new System.Drawing.Point(5, 99);
            this.txt_search_value.Name = "txt_search_value";
            this.txt_search_value.Size = new System.Drawing.Size(225, 20);
            this.txt_search_value.TabIndex = 0;
            this.txt_search_value.TextChanged += new System.EventHandler(this.txt_search_value_TextChanged);
            // 
            // btn_select
            // 
            this.btn_select.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_select.Enabled = false;
            this.btn_select.Location = new System.Drawing.Point(5, 125);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(225, 23);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "Select in model";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_get_model
            // 
            this.btn_get_model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_get_model.Location = new System.Drawing.Point(5, 25);
            this.btn_get_model.Name = "btn_get_model";
            this.btn_get_model.Size = new System.Drawing.Size(225, 25);
            this.btn_get_model.TabIndex = 2;
            this.btn_get_model.Text = "Model";
            this.btn_get_model.UseVisualStyleBackColor = true;
            this.btn_get_model.Click += new System.EventHandler(this.btn_get_model_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Get model info:";
            // 
            // lbl_model_status
            // 
            this.lbl_model_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_model_status.AutoSize = true;
            this.lbl_model_status.Location = new System.Drawing.Point(2, 53);
            this.lbl_model_status.Name = "lbl_model_status";
            this.lbl_model_status.Size = new System.Drawing.Size(103, 13);
            this.lbl_model_status.TabIndex = 4;
            this.lbl_model_status.Text = "<label model status>";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seach:";
            // 
            // rb_name
            // 
            this.rb_name.AutoSize = true;
            this.rb_name.Checked = true;
            this.rb_name.Location = new System.Drawing.Point(87, 76);
            this.rb_name.Name = "rb_name";
            this.rb_name.Size = new System.Drawing.Size(53, 17);
            this.rb_name.TabIndex = 9;
            this.rb_name.TabStop = true;
            this.rb_name.Text = "Name";
            this.rb_name.UseVisualStyleBackColor = true;
            this.rb_name.CheckedChanged += new System.EventHandler(this.rb_name_CheckedChanged);
            // 
            // rb_position
            // 
            this.rb_position.AutoSize = true;
            this.rb_position.Location = new System.Drawing.Point(168, 76);
            this.rb_position.Name = "rb_position";
            this.rb_position.Size = new System.Drawing.Size(62, 17);
            this.rb_position.TabIndex = 9;
            this.rb_position.Text = "Position";
            this.rb_position.UseVisualStyleBackColor = true;
            // 
            // lbl_results
            // 
            this.lbl_results.AutoSize = true;
            this.lbl_results.Location = new System.Drawing.Point(2, 151);
            this.lbl_results.Name = "lbl_results";
            this.lbl_results.Size = new System.Drawing.Size(84, 13);
            this.lbl_results.TabIndex = 10;
            this.lbl_results.Text = "<search results>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 201);
            this.Controls.Add(this.lbl_results);
            this.Controls.Add(this.rb_position);
            this.Controls.Add(this.rb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_model_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_get_model);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.txt_search_value);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search_value;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_get_model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_model_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_name;
        private System.Windows.Forms.RadioButton rb_position;
        private System.Windows.Forms.Label lbl_results;
    }
}

