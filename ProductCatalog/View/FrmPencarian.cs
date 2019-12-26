using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProductCatalog.Model.Entity;
using ProductCatalog.Controller;

namespace ProductCatalog.View
{
    public partial class FrmPencarian : Form
    {
        private List<Product> listOfProduct = new List<Product>();

    
        private ProductController controller;

        public FrmPencarian()
        {
            InitializeComponent();
            controller = new ProductController();
            InisialisasiListView();
            cmbFilter.SelectedIndex = 0;
        }

        private void InisialisasiListView()
        {
            lvwProduct.View = System.Windows.Forms.View.Details;
            lvwProduct.FullRowSelect = true;
            lvwProduct.GridLines = true;

            lvwProduct.Columns.Add("No.", 40, HorizontalAlignment.Center);
            lvwProduct.Columns.Add("Product Id", 120, HorizontalAlignment.Left);
            lvwProduct.Columns.Add("Product Name", 650, HorizontalAlignment.Left);
            lvwProduct.Columns.Add("Stock", 40, HorizontalAlignment.Center);
            lvwProduct.Columns.Add("Price", 70, HorizontalAlignment.Right);
            lvwProduct.Columns.Add("Category", 200, HorizontalAlignment.Left);
            lvwProduct.Columns.Add("Supplier", 200, HorizontalAlignment.Left);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "ProductName")
            {
                lvwProduct.Items.Clear();


                listOfProduct = controller.ReadByProductName(txtKeyword.Text);

                
                    foreach (var prod in listOfProduct)
                    {
                        var noUrut = lvwProduct.Items.Count + 1;

                        var item = new ListViewItem(noUrut.ToString());
                        item.SubItems.Add(prod.product_id);
                        item.SubItems.Add(prod.product_name);
                        item.SubItems.Add(prod.stock.ToString());
                        item.SubItems.Add(prod.price.ToString());
                        item.SubItems.Add(prod.category);
                        item.SubItems.Add(prod.supplier);


                        lvwProduct.Items.Add(item);
                    }
                }
            
            else if (cmbFilter.Text == "Category")
            {
                lvwProduct.Items.Clear();


                listOfProduct = controller.ReadByCategory(txtKeyword.Text);


                foreach (var prod in listOfProduct)
                {
                    var noUrut = lvwProduct.Items.Count + 1;

                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(prod.product_id);
                    item.SubItems.Add(prod.product_name);
                    item.SubItems.Add(prod.stock.ToString());
                    item.SubItems.Add(prod.price.ToString());
                    item.SubItems.Add(prod.category);
                    item.SubItems.Add(prod.supplier);


                    lvwProduct.Items.Add(item);
                }
            }
            else if (cmbFilter.Text == "Supplier")
            {
                lvwProduct.Items.Clear();


                listOfProduct = controller.ReadBySupplier(txtKeyword.Text);


                foreach (var prod in listOfProduct)
                {
                    var noUrut = lvwProduct.Items.Count + 1;

                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(prod.product_id);
                    item.SubItems.Add(prod.product_name);
                    item.SubItems.Add(prod.stock.ToString());
                    item.SubItems.Add(prod.price.ToString());
                    item.SubItems.Add(prod.category);
                    item.SubItems.Add(prod.supplier);


                    lvwProduct.Items.Add(item);

                }
            }
            }
            }
        }

   
