using RegPos.Business.Concrete;
using RegPos.DataAccess.Concrete.SQLDatabase;
using RegPos.Entities.Concrete;
using System.Configuration;
using System.Data.SqlClient;

namespace RegPos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (SqlConnection conn = new SqlConnection())
            {


                conn.ConnectionString =
                  "Data Source=regpos.database.windows.net;" +
                  "Initial Catalog=regpos;" +
                  "User id=regpos;" +
                  "Password=ziX5/*>>1q";
                conn.Open();
                MessageBox.Show("Connected");


                List<string> products = new List<string>();
                products.Add("Sony");
                products.Add("Panasonic");
                products.Add("OnePlus");
                products.Add("Iphone 13");
                products.Add("Samsung");
               /* products.Add("Spaghetti");
                products.Add("Baklava");
                products.Add("Croissant");
                products.Add("Lohi");
                products.Add("Another ");
                products.Add("Nokia");
                products.Add("Dell");
                products.Add("Beko");
                products.Add("Zanussi");
                products.Add("Arcelik");
                products.Add("Matsui");
                products.Add("Airpods");
                products.Add("Fairy");
                products.Add("Candy");
                products.Add("Ikea ");
               */



                Button button;
                int position = 0;
                List<Button> buttons = new List<Button>();


                foreach (var item in products)
                {
                    button = new Button();
                    button.Text = item.ToString();
                    button.Width = 100;
                    button.Height = 60;
                    button.Location = new Point(position, 0);
                    position += button.Width;
                    this.Controls.Add(button);
                }
                
                conn.Close();
                MessageBox.Show("Connection Closed!");
            }
            
            }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryId = Int32.Parse(textBoxCategoryId.Text);
            category.CategoryName = textBoxCategoryName.Text;
            category.SubCategoryOf = Int32.Parse(textBoxSubCategoryOf.Text);
            category.Details = textBoxDetails.Text;


            CategoryDal categoryDal = new CategoryDal();
            categoryDal.Add(category);

            
        }
    }
    }
