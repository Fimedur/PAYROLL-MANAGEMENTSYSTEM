namespace PAYROLL_MANAGEMENTSYSTEM
{
    partial class EmployeeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spouseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tODOListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifiactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termsAndConditionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payslipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPaySlipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.passwordToolStripMenuItem,
            this.paymentDetailsToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDetailsToolStripMenuItem,
            this.noticeToolStripMenuItem,
            this.noteToolStripMenuItem,
            this.tODOListToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.notifiactionToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // personalDetailsToolStripMenuItem
            // 
            this.personalDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spouseDetailsToolStripMenuItem,
            this.employmentDetailsToolStripMenuItem});
            this.personalDetailsToolStripMenuItem.Name = "personalDetailsToolStripMenuItem";
            this.personalDetailsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.personalDetailsToolStripMenuItem.Text = "Personal Details";
            this.personalDetailsToolStripMenuItem.Click += new System.EventHandler(this.personalDetailsToolStripMenuItem_Click);
            // 
            // spouseDetailsToolStripMenuItem
            // 
            this.spouseDetailsToolStripMenuItem.Name = "spouseDetailsToolStripMenuItem";
            this.spouseDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spouseDetailsToolStripMenuItem.Text = "Spouse Details";
            // 
            // employmentDetailsToolStripMenuItem
            // 
            this.employmentDetailsToolStripMenuItem.Name = "employmentDetailsToolStripMenuItem";
            this.employmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.employmentDetailsToolStripMenuItem.Text = "Employment Details";
            // 
            // noticeToolStripMenuItem
            // 
            this.noticeToolStripMenuItem.Name = "noticeToolStripMenuItem";
            this.noticeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.noticeToolStripMenuItem.Text = "Notice";
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.noteToolStripMenuItem.Text = "Note";
            // 
            // tODOListToolStripMenuItem
            // 
            this.tODOListToolStripMenuItem.Name = "tODOListToolStripMenuItem";
            this.tODOListToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.tODOListToolStripMenuItem.Text = "TO DO List";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.emailToolStripMenuItem.Text = "Check Email";
            // 
            // notifiactionToolStripMenuItem
            // 
            this.notifiactionToolStripMenuItem.Name = "notifiactionToolStripMenuItem";
            this.notifiactionToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.notifiactionToolStripMenuItem.Text = "Notifiaction";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineHelpToolStripMenuItem,
            this.offlineHelpToolStripMenuItem,
            this.mailToAdministratorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.onlineHelpToolStripMenuItem.Text = "Online Help";
            this.onlineHelpToolStripMenuItem.Click += new System.EventHandler(this.onlineHelpToolStripMenuItem_Click);
            // 
            // offlineHelpToolStripMenuItem
            // 
            this.offlineHelpToolStripMenuItem.Name = "offlineHelpToolStripMenuItem";
            this.offlineHelpToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.offlineHelpToolStripMenuItem.Text = "Offline Help";
            // 
            // mailToAdministratorToolStripMenuItem
            // 
            this.mailToAdministratorToolStripMenuItem.Name = "mailToAdministratorToolStripMenuItem";
            this.mailToAdministratorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.mailToAdministratorToolStripMenuItem.Text = "Mail To Administrator";
            this.mailToAdministratorToolStripMenuItem.Click += new System.EventHandler(this.mailToAdministratorToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressToolStripMenuItem,
            this.mobileNoToolStripMenuItem,
            this.emailToolStripMenuItem1});
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addressToolStripMenuItem.Text = "Address";
            // 
            // mobileNoToolStripMenuItem
            // 
            this.mobileNoToolStripMenuItem.Name = "mobileNoToolStripMenuItem";
            this.mobileNoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.mobileNoToolStripMenuItem.Text = "Mobile No";
            // 
            // emailToolStripMenuItem1
            // 
            this.emailToolStripMenuItem1.Name = "emailToolStripMenuItem1";
            this.emailToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.emailToolStripMenuItem1.Text = "Email";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termsAndConditionsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // termsAndConditionsToolStripMenuItem
            // 
            this.termsAndConditionsToolStripMenuItem.Name = "termsAndConditionsToolStripMenuItem";
            this.termsAndConditionsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.termsAndConditionsToolStripMenuItem.Text = "Terms And Conditions";
            this.termsAndConditionsToolStripMenuItem.Click += new System.EventHandler(this.termsAndConditionsToolStripMenuItem_Click);
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presentPasswordToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.passwordToolStripMenuItem.Text = "Settings";
            this.passwordToolStripMenuItem.Click += new System.EventHandler(this.passwordToolStripMenuItem_Click);
            // 
            // presentPasswordToolStripMenuItem
            // 
            this.presentPasswordToolStripMenuItem.Name = "presentPasswordToolStripMenuItem";
            this.presentPasswordToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.presentPasswordToolStripMenuItem.Text = "Present Password";
            this.presentPasswordToolStripMenuItem.Click += new System.EventHandler(this.presentPasswordToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.changePasswordToolStripMenuItem.Text = "Password Settings";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // paymentDetailsToolStripMenuItem
            // 
            this.paymentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absenceToolStripMenuItem,
            this.payslipToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.paymentDetailsToolStripMenuItem.Name = "paymentDetailsToolStripMenuItem";
            this.paymentDetailsToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.paymentDetailsToolStripMenuItem.Text = "Payment Details";
            this.paymentDetailsToolStripMenuItem.Click += new System.EventHandler(this.paymentDetailsToolStripMenuItem_Click);
            // 
            // absenceToolStripMenuItem
            // 
            this.absenceToolStripMenuItem.Name = "absenceToolStripMenuItem";
            this.absenceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.absenceToolStripMenuItem.Text = "Leave";
            this.absenceToolStripMenuItem.Click += new System.EventHandler(this.absenceToolStripMenuItem_Click);
            // 
            // payslipToolStripMenuItem
            // 
            this.payslipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPaySlipToolStripMenuItem});
            this.payslipToolStripMenuItem.Name = "payslipToolStripMenuItem";
            this.payslipToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.payslipToolStripMenuItem.Text = "salary";
            this.payslipToolStripMenuItem.Click += new System.EventHandler(this.payslipToolStripMenuItem_Click);
            // 
            // printPaySlipToolStripMenuItem
            // 
            this.printPaySlipToolStripMenuItem.Name = "printPaySlipToolStripMenuItem";
            this.printPaySlipToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printPaySlipToolStripMenuItem.Text = "Print PaySlip";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAYROLL_MANAGEMENTSYSTEM.Properties.Resources.background_36;
            this.ClientSize = new System.Drawing.Size(773, 476);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tODOListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifiactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spouseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employmentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobileNoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mailToAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termsAndConditionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payslipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPaySlipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}