using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ICustomerService _customerService;
        IProductService _productService;
        ISupplierService _supplierService;
        IStockService _stockService;
        ISaleService _saleService;
        IReturnService _returnService;
        public Form1(ICustomerService customerService, IProductService productService, ISupplierService supplierService,
            IStockService stockService, ISaleService saleService, IReturnService returnService)
        {
            _customerService = customerService;
            _productService = productService;
            _supplierService = supplierService;
            _stockService = stockService;
            _saleService = saleService;
            _returnService = returnService;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fillCmbTedarikciler();

            if (dataGridView1 != null && dataGridView1.RowCount > 0)
            {
                btnUpdate.Enabled = false;
            }
        }

        private void fillCmbTedarikciler()
        {
            var suppliers = _supplierService.getAll();
            cmbTedarikciler.DataSource = suppliers.Data;
            cmbTedarikcilerListe.DataSource = suppliers.Data;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                int supplierid = -1;
                supplierid = int.Parse(cmbTedarikcilerListe.SelectedValue.ToString());

                if (supplierid < 0)
                {
                    lblInfo.Text = "Tedarikçi getirilirken bir hata oluştu.";
                    return;
                }

                var result = fillDataGridView1(txtUrunAdiListe.Text, txtUrunKoduListe.Text, supplierid);
                
                lblInfo.Text = result;
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Hata mesajı: " + ex.Message;
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUrunAdi.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtStokSayisi.Text)
                    || string.IsNullOrEmpty(txtMarka.Text) || string.IsNullOrEmpty(txtMensei.Text) || string.IsNullOrEmpty(txtUrunCode.Text)
                    || string.IsNullOrEmpty(txtAlisFiyati.Text))
                {
                    lblInfo.Text = "Lütfen ürün bilgilerini tam olarak giriniz.";
                    return;
                }

                float fiyat = 0;
                float alisFiyati = 0;
                int stockAmount = -1;
                float.TryParse(txtPrice.Text.ToString().Replace(".", ","), out fiyat);
                float.TryParse(txtAlisFiyati.Text.ToString().Replace(".", ","), out alisFiyati);
                int.TryParse(txtStokSayisi.Text, out stockAmount);

                if (fiyat <= 0 || alisFiyati <= 0 || stockAmount < 0)
                {
                    lblInfo.Text = "Lütfen ürün fiyatlarını ve stok miktarını doğru giriniz.";
                    return;
                }

                Product product = new Product
                {
                    ProductName = txtUrunAdi.Text,
                    ProductCode = txtUrunCode.Text,
                    Brand = txtMarka.Text,
                    Description = txtAciklama.Text,
                    Origin = txtMensei.Text,
                    Price = fiyat,
                    SupplierID = int.Parse(cmbTedarikciler.SelectedValue.ToString()),
                    PurchasePrice = alisFiyati
                };

                var result = _productService.addProductToStock(product, stockAmount);

                fillDataGridView1(product.ProductName, product.ProductCode, product.SupplierID);

                lblInfo.Text = result.Message;
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Ürün stoğa eklenirken bir sorun oluştu. Hata mesajı: " + ex.Message;
            }
        }

        private string fillDataGridView1(string productName, string productCode, int supplierId)
        {
            try
            {
                var sonuc = _productService.getProductDetails(productName, productCode, supplierId);
                if (sonuc.Success)
                {
                    dataGridView1.DataSource = sonuc.Data;
                }
                return "Ürün bulunamadı.";
            }
            catch (Exception ex)
            {
                return "Hata Mesajı: " + ex.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        string productId = row.Cells[0].Value.ToString();
                        string productCode = row.Cells[1].Value.ToString();

                        if (!string.IsNullOrEmpty(productId) && !string.IsNullOrEmpty(productCode))
                        {
                            var result = _productService.deleteProductToStock(int.Parse(productId), productCode);
                            if (result.Success)
                            {
                                grpUrunList.Text = "";
                                lblInfo.Text = result.Message;
                            }
                        }
                        else
                        {
                            lblInfo.Text = "Ürün Kodu getirilirken bir hata oluştu.";
                            return;
                        }
                    }
                }
                else
                {
                    lblInfo.Text = "Seçili ürün getirilirken bir hata oluştu.";
                    return;
                }

                btnList_Click(sender, e);
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Hata mesajı: " + ex.Message;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var productId = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                float fiyat = 0;
                float alisFiyati = 0;
                try
                {
                    fiyat = float.Parse(txtPriceListe.Text.ToString().Replace(".", ","));
                    alisFiyati = float.Parse(txtAlisFiyatiList.Text.ToString().Replace(".", ","));
                }
                catch (Exception)
                {
                    lblInfo.Text = "Lütfen ürün fiyatlarını doğru giriniz.";
                    return;
                }

                Stock stock = new Stock
                {
                    ProductID = int.Parse(productId),
                    StockAmount = int.Parse(txtStokSayisiListe.Text)
                };

                Product product = new Product
                {
                    ProductID = int.Parse(productId),
                    ProductCode = txtUrunKoduListe.Text,
                    ProductName = txtUrunAdiListe.Text,
                    Brand = txtBrandListe.Text,
                    Description = txtAciklamaListe.Text,
                    Origin = txtMenseiListe.Text,
                    Price = fiyat,
                    SupplierID = int.Parse(cmbTedarikciler.SelectedValue.ToString()),
                    PurchasePrice = alisFiyati
                };

                var result = _productService.updateProductInStock(product, stock);

                fillDataGridView1(product.ProductName, product.ProductCode, product.SupplierID);

                lblInfo.Text = result.Message;
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Hata mesajı: " + ex.Message;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtUrunKoduListe.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtUrunAdiListe.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPriceListe.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtAlisFiyatiList.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtBrandListe.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtAciklamaListe.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                string tedarikciAdi = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtMenseiListe.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtStokSayisiListe.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();

                var suppliers = _supplierService.getAll();

                if (suppliers.Success)
                {
                    var supplier = suppliers.Data.Where(x => x.SupplierName.Equals(tedarikciAdi)).FirstOrDefault();
                    cmbTedarikcilerListe.SelectedItem = supplier;

                    if (cmbTedarikcilerListe.SelectedValue != null)
                    {
                        btnUpdate.Enabled = true;

                        lblInfo.Text = "Ürün başarıyla getirildi.";
                        return;
                    }
                }
                lblInfo.Text = suppliers.Message;
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Hata mesajı: " + ex.Message;
            }
        }

        private void btnAzalanStok_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtStokLimiti.Text))
                {
                    lblInfo.Text = "Lütfen Stok Limiti Giriniz.";
                    return;
                }

                var limit = int.Parse(txtStokLimiti.Text);

                var products = _productService.getOutOfStock(limit);

                if (products.Success)
                {
                    dataGridView1.DataSource = products.Data;
                }
                lblInfo.Text = products.Message;
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Hata mesajı: " + ex.Message;
            }
        }

        private void btnBilgileriGetir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtStartYear.Text) || string.IsNullOrEmpty(txtEndYear.Text))
                {
                    lblInfo2.Text = "Lütfen görmek istediğiniz başlangıç ve bitiş yıllarını giriniz.";
                    return;
                }

                if ((chkEnAzMi.Checked || chkEnCokMu.Checked) && string.IsNullOrEmpty(txtSatilanUrunLimiti.Text))
                {
                    lblInfo2.Text = "Girdiğiniz yıllar arasında en az veya en çok satılan ürünleri görmek istiyorsanız, satış limitini giriniz.";
                    return;
                }

                DateTime startDate;
                DateTime endDate;
                DateTime.TryParseExact(txtStartYear.Text, "yyyy", CultureInfo.InvariantCulture,
                                                                DateTimeStyles.None, out startDate);
                DateTime.TryParseExact(txtEndYear.Text, "yyyy", CultureInfo.InvariantCulture,
                                                                DateTimeStyles.None, out endDate);

                if (startDate > endDate)
                {
                    lblInfo2.Text = "Başlangıç yılı bitiş yılından büyük olamaz.";
                    return;
                }

                var result = _saleService.getSaleDetails(startDate, endDate);

                if (result.Success)
                {
                    getStatistics(result.Data);
                }

                lblInfo2.Text = result.Message;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void getStatistics(List<SaleDetailDto> saleDetail)
        {
            List<SaleDetailDto> detailList = new List<SaleDetailDto>();

            if (saleDetail != null && saleDetail.Count > 0)
            {
                int limit = 0;
                int.TryParse(txtSatilanUrunLimiti.Text, out limit);

                if (chkEnCokMu.Checked)
                {
                    var descOrd = saleDetail.OrderByDescending(x => x.SaleAmount).ToList();

                    limit = descOrd.Count <= limit ? descOrd.Count : limit;
                    for (int i = 0; i < limit; i++)
                    {
                        detailList.Add(descOrd.ElementAt(i));
                    }
                }
                else if (chkEnAzMi.Checked)
                {
                    var ascOrd = saleDetail.OrderBy(x => x.SaleAmount).OrderByDescending(y => y.ReturnAmount).ToList();

                    limit = ascOrd.Count <= limit ? ascOrd.Count : limit;
                    for (int i = 0; i < limit; i++)
                    {
                        detailList.Add(ascOrd.ElementAt(i));
                    }
                }
                else
                {
                    detailList = saleDetail;
                }

                dataGridView2.DataSource = detailList;
            }

            float toplamSatisFiyati = 0;
            float toplamAlisFiyati = 0;
            int satisSayisi = 0;
            int iadeSayisi = 0;

            List<string> supplierNames = new List<string>();
            foreach (var item in detailList)
            {
                toplamSatisFiyati += item.Price * (item.SaleAmount - item.ReturnAmount);
                toplamAlisFiyati += item.PurchasePrice * (item.SaleAmount - item.ReturnAmount);
                satisSayisi += item.SaleAmount;
                iadeSayisi += item.ReturnAmount;
                if (!supplierNames.Contains(item.SupplierName))
                {
                    supplierNames.Add(item.SupplierName);
                }
            }

            txtKarZarar.Text = (toplamSatisFiyati - toplamAlisFiyati).ToString();
            txtTedarikciSayisi.Text = supplierNames.Count.ToString();
            txtUrunCesidi.Text = detailList.Count.ToString();
            txtSaleAmount.Text = satisSayisi.ToString();
            txtReturnAmount.Text = iadeSayisi.ToString();
        }

        private void btnMusteriGetir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTelNoSatis.Text))
                {
                    lblInfo3.Text = "Lütfen müşterinin telefon numarasını giriniz.";
                    return;
                }

                var telNo = txtTelNoSatis.Text;
                var customer = _customerService.GetCustomerByPhoneNumber(telNo);

                if (customer.Success)
                {
                    txtTelNoSatis.Text = customer.Data.PhoneNumber;
                    txtMusteriAdSatis.Text = customer.Data.FirstName;
                    txtMusteriSoyadSatis.Text = customer.Data.LastName;
                }
                lblInfo3.Text = "Müşteri bulunamadı.";
            }
            catch (Exception ex)
            {
                lblInfo3.Text = "Hata mesajı: " + ex.Message;
            }
        }

        private void btnUrunGetir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUrunKoduSatis.Text))
                {
                    lblInfo3.Text = "Lütfen Satışını yapmak istediğiniz ürün kodunu giriniz.";
                    return;
                }

                var urunKodu = txtUrunKoduSatis.Text;
                var product = _productService.getProductByCode(urunKodu);

                if (product.Success)
                {
                    txtFiyatSatis.Text = product.Data.Price.ToString();
                    rxtAciklamaSatis.Text = product.Data.Description.ToString();
                    txtUrunKoduSatis.Text = product.Data.ProductCode.ToString();
                }
                lblInfo3.Text = product.Message;
            }
            catch (Exception ex)
            {
                lblInfo3.Text = "Hata Mesajı: " + ex.Message;
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTelNoSatis.Text) || string.IsNullOrEmpty(txtMusteriAdSatis.Text)
                    || string.IsNullOrEmpty(txtMusteriSoyadSatis.Text))
                {
                    lblInfo3.Text = "Lütfen kaydetmek istediğiniz müşterinin bilgilerini eksiksiz giriniz.";
                    return;
                }

                Customer customer = new Customer
                {
                    FirstName = txtMusteriAdSatis.Text,
                    LastName = txtMusteriSoyadSatis.Text,
                    PhoneNumber = txtTelNoSatis.Text
                };

                var result = _customerService.add(customer);

                lblInfo3.Text = result.Message;
            }
            catch (Exception ex)
            {
                lblInfo3.Text = "Hata Mesajı: " + ex.Message;
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMusteriAdSatis.Text) || string.IsNullOrEmpty(txtMusteriSoyadSatis.Text)
                || string.IsNullOrEmpty(txtFiyatSatis.Text) || string.IsNullOrEmpty(rxtAciklamaSatis.Text))
                {
                    lblInfo3.Text = "Lütfen satış için gerekli olam ürün ve müşteri bilgilerinin geldiğinden emin olun.";
                    return;
                }

                var productCode = txtUrunKoduSatis.Text;
                var phoneNo = txtTelNoSatis.Text;

                var sale = _saleService.MakeSale(productCode, phoneNo);

                if (sale.Success)
                {
                    CreateBill(false, sale.Data);
                }

                lblInfo3.Text = sale.Message;
            }
            catch (Exception ex)
            {
                lblInfo3.Text = "Hata mesajı: " + ex.Message;
            }
        }

        private void btnSatisGetir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSatisIDIade.Text))
                {
                    lblInfo3.Text = "Lütfen satış kodunu giriniz. Satış kodu olmadan iade alınamaz.";
                    return;
                }

                int satisId = -1;
                int.TryParse(txtSatisIDIade.Text, out satisId);

                if (satisId < 0)
                {
                    lblInfo3.Text = "Satış Kodunu yanlış girdiniz.";
                    return;
                }

                var soldProduct = _saleService.GetSoldProduct(satisId);

                if (soldProduct.Success)
                {
                    txtTelNoIade.Text = soldProduct.Data.PhoneNumber;
                    txtUrunKoduIade.Text = soldProduct.Data.ProductCode;
                    txtSatisTarihiIade.Text = soldProduct.Data.SaleDate.ToString();
                }

                lblInfo3.Text = soldProduct.Message;
            }
            catch (Exception ex)
            {
                lblInfo3.Text = "Hata mesajı: " + ex.Message;
            }
        }

        private void btnIadeAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSatisIDIade.Text))
                {
                    lblInfo3.Text = "Lütfen satış kodunu giriniz. Satış kodu olmadan iade alınamaz.";
                    return;
                }

                int satisId = -1;
                int.TryParse(txtSatisIDIade.Text, out satisId);

                if (satisId < 0)
                {
                    lblInfo3.Text = "Satış Kodunu yanlış girdiniz.";
                    return;
                }

                var returnProduct = _returnService.returnProduct(satisId);

                if (returnProduct.Success)
                {
                    CreateBill(true, satisId);
                }

                lblInfo3.Text = returnProduct.Message;
            }
            catch (Exception ex)
            {
                lblInfo3.Text = "Hata mesajı: " + ex.Message;
            }
        }

        private void CreateBill(bool isReturn,int SaleCode)
        {
            try
            {
                var saleDetail = _returnService.getSaleReturnDetails(SaleCode);

                if (saleDetail.Success)
                {
                    txtAdFatura.Text = saleDetail.Data.FirstName;
                    txtSoyadFatura.Text = saleDetail.Data.LastName;
                    txtTelNoFatura.Text = saleDetail.Data.PhoneNumber;

                    txtUrunKoduFatura.Text = saleDetail.Data.ProductCode;
                    rxtAciklamaFatura.Text = saleDetail.Data.Description;
                    
                    txtSatisFiyatiFatura.Text = saleDetail.Data.Price.ToString();
                    txtSatisTarihiFatura.Text = saleDetail.Data.SaleDate.ToString();

                    if (isReturn)
                    {
                        txtIadeTutariFatura.Visible = true;
                        txtIadeTarihiFatura.Visible = true;
                        txtIadeKoduFatura.Visible = true;
                        lblIadeTarihiFatura.Visible = true;
                        lblIadeTutariFatura.Visible = true;
                        lblIadeKoduFatura.Visible = true;
                        
                        txtIadeTutariFatura.Text = saleDetail.Data.Price.ToString();
                        txtIadeTarihiFatura.Text = saleDetail.Data.ReturnDate.ToString();
                    }
                    else
                    {
                        txtIadeKoduFatura.Visible = false;
                        txtIadeTutariFatura.Visible = false;
                        txtIadeTarihiFatura.Visible = false;
                        lblIadeKoduFatura.Visible = false;
                        lblIadeTarihiFatura.Visible = false;
                        lblIadeTutariFatura.Visible = false;
                    }
                }

                lblInfo3.Text = saleDetail.Message;
            }
            catch (Exception ex)
            {
                lblInfo3.Text = "Hata mesajı: " + ex.Message;
            }
        }
    }
}
