namespace WLTOrderSystem
{
    partial class frmPayment
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
            this.cboPayType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPayType = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.txtbOrderNum = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtbQty = new System.Windows.Forms.TextBox();
            this.lblBreakdown = new System.Windows.Forms.Label();
            this.lblExitPrice = new System.Windows.Forms.Label();
            this.txtbExitPrice = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtbTax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboPayType
            // 
            this.cboPayType.FormattingEnabled = true;
            this.cboPayType.Location = new System.Drawing.Point(151, 42);
            this.cboPayType.Name = "cboPayType";
            this.cboPayType.Size = new System.Drawing.Size(120, 21);
            this.cboPayType.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 49);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtbTotal
            // 
            this.txtbTotal.Enabled = false;
            this.txtbTotal.Location = new System.Drawing.Point(12, 42);
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.Size = new System.Drawing.Size(120, 20);
            this.txtbTotal.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 21);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 18);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Order Total";
            // 
            // lblPayType
            // 
            this.lblPayType.AutoSize = true;
            this.lblPayType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayType.Location = new System.Drawing.Point(148, 21);
            this.lblPayType.Name = "lblPayType";
            this.lblPayType.Size = new System.Drawing.Size(134, 18);
            this.lblPayType.TabIndex = 4;
            this.lblPayType.Text = "Payment Method";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(12, 103);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(115, 18);
            this.lblOrderNum.TabIndex = 6;
            this.lblOrderNum.Text = "Order Number";
            // 
            // txtbOrderNum
            // 
            this.txtbOrderNum.Enabled = false;
            this.txtbOrderNum.Location = new System.Drawing.Point(12, 124);
            this.txtbOrderNum.Name = "txtbOrderNum";
            this.txtbOrderNum.Size = new System.Drawing.Size(120, 20);
            this.txtbOrderNum.TabIndex = 5;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(148, 103);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(114, 18);
            this.lblQty.TabIndex = 8;
            this.lblQty.Text = "Num. of Items";
            // 
            // txtbQty
            // 
            this.txtbQty.Enabled = false;
            this.txtbQty.Location = new System.Drawing.Point(148, 124);
            this.txtbQty.Name = "txtbQty";
            this.txtbQty.Size = new System.Drawing.Size(120, 20);
            this.txtbQty.TabIndex = 7;
            // 
            // lblBreakdown
            // 
            this.lblBreakdown.AutoSize = true;
            this.lblBreakdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakdown.Location = new System.Drawing.Point(93, 75);
            this.lblBreakdown.Name = "lblBreakdown";
            this.lblBreakdown.Size = new System.Drawing.Size(92, 18);
            this.lblBreakdown.TabIndex = 9;
            this.lblBreakdown.Text = "Breakdown";
            this.lblBreakdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExitPrice
            // 
            this.lblExitPrice.AutoSize = true;
            this.lblExitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitPrice.Location = new System.Drawing.Point(12, 159);
            this.lblExitPrice.Name = "lblExitPrice";
            this.lblExitPrice.Size = new System.Drawing.Size(80, 18);
            this.lblExitPrice.TabIndex = 11;
            this.lblExitPrice.Text = "Exit Price";
            // 
            // txtbExitPrice
            // 
            this.txtbExitPrice.Enabled = false;
            this.txtbExitPrice.Location = new System.Drawing.Point(12, 180);
            this.txtbExitPrice.Name = "txtbExitPrice";
            this.txtbExitPrice.Size = new System.Drawing.Size(120, 20);
            this.txtbExitPrice.TabIndex = 10;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(148, 159);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(35, 18);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "Tax";
            // 
            // txtbTax
            // 
            this.txtbTax.Enabled = false;
            this.txtbTax.Location = new System.Drawing.Point(148, 180);
            this.txtbTax.Name = "txtbTax";
            this.txtbTax.Size = new System.Drawing.Size(120, 20);
            this.txtbTax.TabIndex = 12;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtbTax);
            this.Controls.Add(this.lblExitPrice);
            this.Controls.Add(this.txtbExitPrice);
            this.Controls.Add(this.lblBreakdown);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtbQty);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.txtbOrderNum);
            this.Controls.Add(this.lblPayType);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtbTotal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboPayType);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPayment_FormClosing);
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPayType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPayType;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.TextBox txtbOrderNum;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtbQty;
        private System.Windows.Forms.Label lblBreakdown;
        private System.Windows.Forms.Label lblExitPrice;
        private System.Windows.Forms.TextBox txtbExitPrice;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtbTax;
    }
}