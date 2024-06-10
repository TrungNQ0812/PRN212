using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusinessObjects;
using DataAccessLayer;

using Services;
using static System.Net.Mime.MediaTypeNames;

namespace ProductManagementWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IProductService iProductService;
        private readonly ICategoryService iCategoryService;
        public MainWindow()
        {
            InitializeComponent();
            iProductService = new ProductService();
            iCategoryService = new CategoryService();
        }

        public void loadCategoryList()
        {
            try
            {
                var catList = iCategoryService.GetCategories();
                cboCategory.ItemsSource = catList;
                cboCategory.DisplayMemberPath = "CategoryName";
                cboCategory.SelectedValuePath = "CategoryID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of categories");
            }
        }

        public void LoadProductList()
        {
            try
            {
                var productList = iProductService.GetProducts();
                dgData.ItemsSource = productList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of products");
            }
            finally
            {
                resetInput();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadCategoryList();
            LoadProductList();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Kiểm tra các giá trị đầu vào
                if (string.IsNullOrWhiteSpace(txtProductName.Text))
                {
                    MessageBox.Show("Product name is required.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPrice.Text) || !decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Valid price is required.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtUnitsInStock.Text) || !short.TryParse(txtUnitsInStock.Text, out short unitsInStock))
                {
                    MessageBox.Show("Valid units in stock is required.");
                    return;
                }
                if (cboCategory.SelectedValue == null)
                {
                    MessageBox.Show("Category must be selected.");
                    return;
                }

                // Tạo đối tượng Product mới
                Product product = new Product
                {
                    ProductName = txtProductName.Text,
                    UnitPrice = price,
                    UnitInStock = unitsInStock,
                    CategoryID = (int)cboCategory.SelectedValue
                };

                // Lưu sản phẩm mới
                iProductService.SaveProduct(product);

                // Tải lại danh sách sản phẩm và reset các trường nhập liệu
                LoadProductList();
                resetInput();
                MessageBox.Show("Product created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void dgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgData.SelectedItem is Product selectedProduct)
            {
                txtProductID.Text = selectedProduct.ProductId.ToString();
                txtProductName.Text = selectedProduct.ProductName;
                txtPrice.Text = selectedProduct.UnitPrice.ToString();
                txtUnitsInStock.Text = selectedProduct.UnitInStock.ToString();
                cboCategory.SelectedValue = selectedProduct.CategoryID;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void resetInput()
        {
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
            cboCategory.SelectedValue = 0;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Kiểm tra các giá trị đầu vào
                if (string.IsNullOrWhiteSpace(txtProductID.Text) || !int.TryParse(txtProductID.Text, out int productId))
                {
                    MessageBox.Show("Valid Product ID is required.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtProductName.Text))
                {
                    MessageBox.Show("Product name is required.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPrice.Text) || !decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Valid price is required.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtUnitsInStock.Text) || !short.TryParse(txtUnitsInStock.Text, out short unitsInStock))
                {
                    MessageBox.Show("Valid units in stock is required.");
                    return;
                }
                if (cboCategory.SelectedValue == null)
                {
                    MessageBox.Show("Category must be selected.");
                    return;
                }

                // Tạo đối tượng Product mới
                Product product = new Product
                {
                    ProductId = productId,
                    ProductName = txtProductName.Text,
                    UnitPrice = price,
                    UnitInStock = unitsInStock,
                    CategoryID = (int)cboCategory.SelectedValue
                };

                // Cập nhật sản phẩm
                iProductService.UpdateProduct(product);

                // Tải lại danh sách sản phẩm và reset các trường nhập liệu
                LoadProductList();
                resetInput();
                MessageBox.Show("Product updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Kiểm tra ID sản phẩm
                if (string.IsNullOrWhiteSpace(txtProductID.Text) || !int.TryParse(txtProductID.Text, out int productId))
                {
                    MessageBox.Show("Valid Product ID is required.");
                    return;
                }

                // Lấy sản phẩm theo ID
                Product product = iProductService.GetProductByID(productId);
                if (product == null)
                {
                    MessageBox.Show("Product not found.");
                    return;
                }

                // Xóa sản phẩm
                iProductService.DeleteProduct(product);

                // Tải lại danh sách sản phẩm và reset các trường nhập liệu
                LoadProductList();
                resetInput();
                MessageBox.Show("Product deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
