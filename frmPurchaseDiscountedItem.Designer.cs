partial class frmPurchaseDiscountedItem
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.lblDiscount = new System.Windows.Forms.Label();
        this.txtDiscount = new System.Windows.Forms.TextBox();
        this.lblPrice = new System.Windows.Forms.Label();
        this.txtPrice = new System.Windows.Forms.TextBox();
        this.lblQuantity = new System.Windows.Forms.Label();
        this.txtQuantity = new System.Windows.Forms.TextBox();
        this.lblTotalAmount = new System.Windows.Forms.Label();
        this.txtTotalAmount = new System.Windows.Forms.TextBox();
        this.lblPaymentReceived = new System.Windows.Forms.Label();
        this.txtPaymentReceived = new System.Windows.Forms.TextBox();
        this.lblChange = new System.Windows.Forms.Label();
        this.txtChange = new System.Windows.Forms.TextBox();
        this.btnCompute = new System.Windows.Forms.Button();
        this.btnSubmit = new System.Windows.Forms.Button();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();

        this.lblDiscount.AutoSize = true;
        this.lblDiscount.Location = new System.Drawing.Point(12, 27);
        this.lblDiscount.Name = "lblDiscount";
        this.lblDiscount.Size = new System.Drawing.Size(71, 13);
        this.lblDiscount.TabIndex = 0;
        this.lblDiscount.Text = "Discount (%):";

        this.txtDiscount.Location = new System.Drawing.Point(100, 24);
        this.txtDiscount.Name = "txtDiscount";
        this.txtDiscount.Size = new System.Drawing.Size(100, 20);
        this.txtDiscount.TabIndex = 1;

        this.lblPrice.AutoSize = true;
        this.lblPrice.Location = new System.Drawing.Point(12, 53);
        this.lblPrice.Name = "lblPrice";
        this.lblPrice.Size = new System.Drawing.Size(36, 13);
        this.lblPrice.TabIndex = 2;
        this.lblPrice.Text = "Price:";

        this.txtPrice.Location = new System.Drawing.Point(100, 50);
        this.txtPrice.Name = "txtPrice";
        this.txtPrice.Size = new System.Drawing.Size(100, 20);
        this.txtPrice.TabIndex = 3;

        this.lblQuantity.AutoSize = true;
        this.lblQuantity.Location = new System.Drawing.Point(12, 79);
        this.lblQuantity.Name = "lblQuantity";
        this.lblQuantity.Size = new System.Drawing.Size(49, 13);
        this.lblQuantity.TabIndex = 4;
        this.lblQuantity.Text = "Quantity:";

        this.txtQuantity.Location = new System.Drawing.Point(100, 76);
        this.txtQuantity.Name = "txtQuantity";
        this.txtQuantity.Size = new System.Drawing.Size(100, 20);
        this.txtQuantity.TabIndex = 5;

        this.lblTotalAmount.AutoSize = true;
        this.lblTotalAmount.Location = new System.Drawing.Point(12, 105);
        this.lblTotalAmount.Name = "lblTotalAmount";
        this.lblTotalAmount.Size = new System.Drawing.Size(75, 13);
        this.lblTotalAmount.TabIndex = 6;
        this.lblTotalAmount.Text = "Total amount:";

        this.txtTotalAmount.Location = new System.Drawing.Point(100, 102);
        this.txtTotalAmount.Name = "txtTotalAmount";
        this.txtTotalAmount.ReadOnly = true;
        this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
        this.txtTotalAmount.TabIndex = 7;

        this.lblPaymentReceived.AutoSize = true;
        this.lblPaymentReceived.Location = new System.Drawing.Point(12, 131);
        this.lblPaymentReceived.Name = "lblPaymentReceived";
        this.lblPaymentReceived.Size = new System.Drawing.Size(98, 13);
        this.lblPaymentReceived.TabIndex = 8;
        this.lblPaymentReceived.Text = "Payment received:";

        this.txtPaymentReceived.Location = new System.Drawing.Point(116, 128);
        this.txtPaymentReceived.Name = "txtPaymentReceived";
        this.txtPaymentReceived.Size = new System.Drawing.Size(100, 20);
        this.txtPaymentReceived.TabIndex = 9;

        this.lblChange.AutoSize = true;
        this.lblChange.Location = new System.Drawing.Point(12, 157);
        this.lblChange.Name = "lblChange";
        this.lblChange.Size = new System.Drawing.Size(46, 13);
        this.lblChange.TabIndex = 10;
        this.lblChange.Text = "Change:";

        this.txtChange.Location = new System.Drawing.Point(100, 154);
        this.txtChange.Name = "txtChange";
        this.txtChange.ReadOnly = true;
        this.txtChange.Size = new System.Drawing.Size(100, 20);
        this.txtChange.TabIndex = 11;

        this.btnCompute.Location = new System.Drawing.Point(12, 180);
        this.btnCompute.Name = "btnCompute";
        this.btnCompute.Size = new System.Drawing.Size(75, 23);
        this.btnCompute.TabIndex = 12;
        this.btnCompute.Text = "Compute";
        this.btnCompute.UseVisualStyleBackColor = true;
        this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);

        this.btnSubmit.Location = new System.Drawing.Point(100, 180);
        this.btnSubmit.Name = "btnSubmit";
        this.btnSubmit.Size = new System.Drawing.Size(75, 23);
        this.btnSubmit.TabIndex = 13;
        this.btnSubmit.Text = "Submit";
        this.btnSubmit.UseVisualStyleBackColor = true;
        this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(284, 24);
        this.menuStrip1.TabIndex = 14;
        this.menuStrip1.Text = "menuStrip1";

        this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
        this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        this.fileToolStripMenuItem.Text = "File";

        this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
        this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        this.logoutToolStripMenuItem.Text = "Logout";
        this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);

        this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
        this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        this.exitApplicationToolStripMenuItem.Text = "Exit Application";
        this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);

        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(284, 211);
        this.Controls.Add(this.btnSubmit);
        this.Controls.Add(this.btnCompute);
        this.Controls.Add(this.txtChange);
        this.Controls.Add(this.lblChange);
        this.Controls.Add(this.txtPaymentReceived);
        this.Controls.Add(this.lblPaymentReceived);
        this.Controls.Add(this.txtTotalAmount);
        this.Controls.Add(this.lblTotalAmount);
        this.Controls.Add(this.txtQuantity);
        this.Controls.Add(this.lblQuantity);
        this.Controls.Add(this.txtPrice);
        this.Controls.Add(this.lblPrice);
        this.Controls.Add(this.txtDiscount);
        this.Controls.Add(this.lblDiscount);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "frmPurchaseDiscountedItem";
        this.Text = "Purchase Discounted Item";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblDiscount;
    private System.Windows.Forms.TextBox txtDiscount;
    private System.Windows.Forms.Label lblPrice;
    private System.Windows.Forms.TextBox txtPrice;
    private System.Windows.Forms.Label lblQuantity;
    private System.Windows.Forms.TextBox txtQuantity;
    private System.Windows.Forms.Label lblTotalAmount;
    private System.Windows.Forms.TextBox txtTotalAmount;
    private System.Windows.Forms.Label lblPaymentReceived;
    private System.Windows.Forms.TextBox txtPaymentReceived;
    private System.Windows.Forms.Label lblChange;
    private System.Windows.Forms.TextBox txtChange;
    private System.Windows.Forms.Button btnCompute;
    private System.Windows.Forms.Button btnSubmit;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
}
