using Aquapark.Services;
using System;
using System.Windows.Forms;

namespace Aquapark
{
    public partial class Tables2 : Form
    {
        public Tables2()
        {
            InitializeComponent();
        }

        private void Aquapark_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {

            LoadVisits();
            LoadDiscounts();
            LoadEntrancemethods();
            LoadServices();

        }

        private void LoadVisits()
        {
            try
            {
                visitsGridView.DataSource = DbService.GetData(Query.GetVisits).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void LoadDiscounts()
        {
            try
            {
                discountsGridView.DataSource = DbService.GetData(Query.GetDiscounts).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void LoadEntrancemethods()
        {
            try
            {
                entranceMethodsGridView.DataSource = DbService.GetData(Query.GetEntranceMethods).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void LoadServices()
        {
            try
            {
                servicesGridView.DataSource = DbService.GetData(Query.GetServices).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void page1Button_Click(object sender, EventArgs e)
        {
            Tables1 tables1Form = new Tables1();
            tables1Form.Show();
            this.Hide();
        }
    }
}
