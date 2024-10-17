using System;
using System.Windows.Forms;

public partial class frmPurchaseDiscountedItem : Form
{
    public frmPurchaseDiscountedItem()
    {
        InitializeComponent();
    }

    private void btnCompute_Click(object sender, EventArgs e)
    {
        try
        {
            decimal price = decimal.Parse(txtPrice.Text);
            decimal discount = decimal.Parse(txtDiscount.Text) / 100;
            int quantity = int.Parse(txtQuantity.Text);

            decimal totalAmount = price * quantity * (1 - discount);
            txtTotalAmount.Text = totalAmount.ToString("F2");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Please enter valid values.");
        }
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            decimal totalAmount = decimal.Parse(txtTotalAmount.Text);
            decimal paymentReceived = decimal.Parse(txtPaymentReceived.Text);

            decimal change = paymentReceived - totalAmount;
            txtChange.Text = change.ToString("F2");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Please enter valid values.");
        }
    }

    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Hide();
        frmLoginAccount loginForm = new frmLoginAccount();
        loginForm.Show();
    }

    private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
