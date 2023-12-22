namespace EventMechanism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            productService.ProductCreated += ProductService_ProductCreated;

            productService.CreateProduct(new Product { Name = "Çekirdek" });
        }

        private void ProductService_ProductCreated(object sender, ProductCreatedEventArgs e)
        {
            MessageBox.Show($"{e.User} kullanıcısı, {e.CreatedDate.Date} tarihinde {e.Product.Name} isimli ğrğnü ekledi");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}