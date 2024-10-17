using System;
using System.Windows.Forms;
using UserAccountNamespace;

public partial class frmLoginAccount : Form
{
    public frmLoginAccount()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        Cashier cashier = new Cashier("Minmay De Leon", "Finance", "cashier101", "password123");

        if (cashier.validateLogin(username, password))
        {
            MessageBox.Show($"Welcome {cashier.getFullName()} of {cashier.getDepartment()}");
            this.Hide();
            frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem();
            purchaseForm.Show();
        }
        else
        {
            MessageBox.Show("Invalid username or password.");
        }
    }
}
