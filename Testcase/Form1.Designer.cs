namespace Testcase
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtOrgName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            btnDirector = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Organization Name (*)";
            // 
            // label2
            // 
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.Location = new Point(30, 110);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.Location = new Point(30, 150);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // txtOrgName
            // 
            txtOrgName.Location = new Point(200, 30);
            txtOrgName.Name = "txtOrgName";
            txtOrgName.Size = new Size(250, 27);
            txtOrgName.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(200, 70);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(200, 110);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(80, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 32);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(200, 210);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 32);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // btnDirector
            // 
            btnDirector.Location = new Point(320, 210);
            btnDirector.Name = "btnDirector";
            btnDirector.Size = new Size(75, 32);
            btnDirector.TabIndex = 10;
            btnDirector.Text = "Director";
            btnDirector.Click += btnDirector_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(500, 280);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtOrgName);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            Controls.Add(btnDirector);
            Name = "Form1";
            Text = "Organization Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDirector;
    }
}
