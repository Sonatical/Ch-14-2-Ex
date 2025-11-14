namespace CustomerMaintenance
{
    partial class frmAddCustomer
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
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            rbWholesale = new RadioButton();
            rbRetail = new RadioButton();
            lblCompanyOrPhone = new Label();
            txtCompanyOrPhone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(106, 35);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.MaxLength = 30;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(176, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(106, 65);
            txtLastName.Margin = new Padding(2);
            txtLastName.MaxLength = 30;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(176, 23);
            txtLastName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 69);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Last Name:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(106, 95);
            txtEmail.Margin = new Padding(2);
            txtEmail.MaxLength = 30;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 101);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(106, 158);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(207, 158);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // rbWholesale
            // 
            rbWholesale.AutoSize = true;
            rbWholesale.Checked = true;
            rbWholesale.Location = new Point(106, 8);
            rbWholesale.Name = "rbWholesale";
            rbWholesale.Size = new Size(79, 19);
            rbWholesale.TabIndex = 0;
            rbWholesale.TabStop = true;
            rbWholesale.Text = "Wholesale";
            rbWholesale.UseVisualStyleBackColor = true;
            rbWholesale.CheckedChanged += rbWholesale_CheckedChanged;
            // 
            // rbRetail
            // 
            rbRetail.AutoSize = true;
            rbRetail.Location = new Point(225, 8);
            rbRetail.Name = "rbRetail";
            rbRetail.Size = new Size(54, 19);
            rbRetail.TabIndex = 1;
            rbRetail.Text = "Retail";
            rbRetail.UseVisualStyleBackColor = true;
            // 
            // lblCompanyOrPhone
            // 
            lblCompanyOrPhone.AutoSize = true;
            lblCompanyOrPhone.Location = new Point(24, 128);
            lblCompanyOrPhone.Name = "lblCompanyOrPhone";
            lblCompanyOrPhone.Size = new Size(62, 15);
            lblCompanyOrPhone.TabIndex = 8;
            lblCompanyOrPhone.Text = "Company:";
            // 
            // txtCompanyOrPhone
            // 
            txtCompanyOrPhone.Location = new Point(106, 125);
            txtCompanyOrPhone.Name = "txtCompanyOrPhone";
            txtCompanyOrPhone.Size = new Size(176, 23);
            txtCompanyOrPhone.TabIndex = 9;
            // 
            // frmAddCustomer
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(309, 195);
            ControlBox = false;
            Controls.Add(txtCompanyOrPhone);
            Controls.Add(lblCompanyOrPhone);
            Controls.Add(rbRetail);
            Controls.Add(rbWholesale);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "frmAddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
        private RadioButton rbWholesale;
        private RadioButton rbRetail;
        private Label lblCompanyOrPhone;
        private TextBox txtCompanyOrPhone;
    }
}