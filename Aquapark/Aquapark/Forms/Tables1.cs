using System;
using System.Windows.Forms;
using Aquapark.Services;

namespace Aquapark
{
    public partial class Tables1 : Form
    {
        public Tables1()
        {
            InitializeComponent();
        }

        private void Aquapark_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoadCustomers();
            LoadWatches();
            LoadCharges();
            LoadTransactions();
            LoadEntrances();
            LoadExits();
        }

        private void LoadCustomers()
        {
            try
            {
                customersGridView.DataSource = DbService.GetData(Query.GetGustomers).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadWatches()
        {
            try
            {
                watchesGridView.DataSource = DbService.GetData(Query.GetWatches).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadCharges()
        {
            try
            {
                chargesGridView.DataSource = DbService.GetData(Query.GetCharges).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadTransactions()
        {
            try
            {
                transactionsGridView.DataSource = DbService.GetData(Query.GetTransactions).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadEntrances()
        {
            try
            {
                entrancesGridView.DataSource = DbService.GetData(Query.GetEntrances).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadExits()
        {
            try
            {
                exitsGridView.DataSource = DbService.GetData(Query.GetExits).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void page2Button_Click(object sender, EventArgs e)
        {
            Tables2 tables2Form = new Tables2();
            tables2Form.Show();
            this.Hide();
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            Aquapark aquaparkForm = new Aquapark();
            aquaparkForm.Show();
            this.Hide();
        }
    }
}