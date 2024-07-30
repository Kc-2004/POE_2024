using BankAccountLibrary;

namespace BankAccountUI
{
    public partial class MainForm : Form
    {
        private BankAccount _bankAccount;
        public MainForm()
        {
            _bankAccount = new BankAccount("123456", "Juan Perez", 100);

            InitializeComponent();
        }

        private void getBalanceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El saldo de la cuenta es {_bankAccount.GetBalance()}");
        }

        private void saveDepositButton_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(depositTextBox.Text);
            _bankAccount.MakeDeposit(amount);
            MessageBox.Show($"El saldo de la cuenta es {_bankAccount.GetBalance()}");
        }

        private void withDrawButton_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(withDrawTextBox.Text);
            _bankAccount.MakeWithDraw(amount);
            MessageBox.Show($"El saldo de la cuenta es {_bankAccount.GetBalance()}");
        }
    }
}
