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
            IStockService stockService,ISaleService saleService,IReturnService returnService)
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
            var suppliers = _supplierService.getAll();
            cmbTedarikciler.DataSource = suppliers.Data;
            cmbTedarikcilerListe.DataSource = suppliers.Data;

            if (dataGridView1 != null && dataGridView1.RowCount > 0)
            {
                btnUpdate.Enabled = false;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            int supplierid = -1;
            if (cmbTedarikcilerListe.SelectedValue != null && cmbTedarikcilerListe.SelectedValue.ToString() != "-1")
            {
                supplierid = int.Parse(cmbTedarikcilerListe.SelectedValue.ToString()); 
            }

            var sonuc = _productService.getProductDetails(txtUrunAdiListe.Text,txtUrunKoduListe.Text,supplierid);
            dataGridView1.DataSource = sonuc.Data;            
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

                if (cmbTedarikciler.SelectedItem == null || cmbTedarikciler.SelectedValue.ToString().Equals("-1"))
                {
                    lblInfo.Text = "Lütfen Tedarikçi seçiniz.";
                    return;
                }

                float fiyat = 0;
                float alisFiyati = 0;
                try
                {
                    fiyat = float.Parse(txtPrice.Text.ToString().Replace(".",","));
                    alisFiyati = float.Parse(txtAlisFiyati.Text.ToString().Replace(".", ","));
                }
                catch (Exception)
                {
                    lblInfo.Text = "Lütfen ürün fiyatlarını doğru giriniz.";
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

                var result = _productService.add(product);

                if (result.Success)
                {
                    var hasProduct = _productService.getProductByCode(product.ProductCode);

                    if (hasProduct.Success)
                    {
                        Stock stock = new Stock 
                        {
                            ProductID = hasProduct.Data.ProductID,
                            StockAmount = int.Parse(txtStokSayisi.Text)
                        };

                        var hasStock = _stockService.add(stock);

                        if (hasStock.Success)
                        {
                            lblInfo.Text = "Ürün başarılı bir şekilde stoğa eklendi.";
                        }
                        else
                        {
                            lblInfo.Text = "Ürün stoğa eklenirken bir sorun oluştu.";
                        }
                    }
                    else
                    {
                        lblInfo.Text = "Ürün stoğa eklenirken bir sorun oluştu.";
                    }
                }
                else
                {
                    lblInfo.Text = "Ürün stoğa eklenirken bir sorun oluştu.";
                }
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Ürün eklenirken bir sorun oluştu.";
                throw ex;
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

                        if (!string.IsNullOrEmpty(productId))
                        {
                            var result = _stockService.delete(int.Parse(productId));
                            if (result.Success)
                            {
                                var result2 = _productService.delete(productCode);

                                if (result2.Success)
                                {
                                    lblInfo.Text = "Ürünler başarıyla silindi.";
                                }
                                else
                                {
                                    lblInfo.Text = "Ürün silinirken bir hata oluştu.";
                                    return;
                                }
                            }
                            else
                            {
                                lblInfo.Text = "Ürün silinirken bir hata oluştu.";
                                return;
                            }
                        }
                        else
                        {
                            lblInfo.Text = "Ürün silinirken bir hata oluştu.";
                            return;
                        }
                    }
                }
                else
                {
                    lblInfo.Text = "Ürün silinirken bir hata oluştu.";
                    return;
                }

                btnList_Click(sender,e);
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Ürün silinirken bir hata oluştu.";
                throw ex;
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

                var suppliers = _supplierService.getAll();

                Supplier supplier = new Supplier();
                if (suppliers.Success)
                {
                    supplier = suppliers.Data.Where(x => x.SupplierID.ToString()
                                                            .Equals(cmbTedarikcilerListe.SelectedValue.ToString()))
                                                            .FirstOrDefault();
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
                    SupplierID = supplier.SupplierID,
                    PurchasePrice = alisFiyati
                };

                var result = _stockService.update(stock);
                if (result.Success)
                {
                    var result1 = _productService.update(product);
                    
                    if (result1.Success)
                    {
                        lblInfo.Text = "Ürün güncellendi.";
                        btnList_Click(sender, e);
                        return;
                    }
                }

                lblInfo.Text = "Ürün güncellenirken bir hata oluştu.";
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Ürün güncellenirken bir hata oluştu.";
                throw ex;
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
                lblInfo.Text = "Ürün getirilirken bir hata oluştu.";
            }
            catch (Exception ex)
            {
                throw ex;
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
                    lblInfo.Text = products.Message;
                }
                else
                {
                    lblInfo.Text = products.Message;
                }
            }
            catch (Exception ex)
            {
                throw ex;
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

                if (startDate >= endDate)
                {
                    lblInfo2.Text = "Başlangıç yılı bitiş yılına eşit veya büyük olamaz.";
                    return;
                }

                var result = _saleService.getSaleDetails(startDate,endDate);

                if (result.Success)
                {
                    if (result.Data != null && result.Data.Count > 0)
                    {
                        int limit = 0;
                        int.TryParse(txtSatilanUrunLimiti.Text, out limit);
                        List<SaleDetailDto> details = new List<SaleDetailDto>();
                        if (chkEnAzMi.Checked)
                        {
                            var descOrd = result.Data.OrderByDescending(x => x.SaleAmount).ToList();

                            limit = descOrd.Count <= limit ? descOrd.Count : limit;
                            for (int i = 0; i < limit; i++)
                            {
                                details.Add(descOrd.ElementAt(i));
                            }
                        }
                        else if(chkEnCokMu.Checked)
                        {
                            var ascOrd = result.Data.OrderBy(x => x.SaleAmount).ToList();

                            limit = ascOrd.Count <= limit ? ascOrd.Count : limit;
                            for (int i = 0; i < limit; i++)
                            {
                                details.Add(ascOrd.ElementAt(i));
                            }
                        }
                        else
                        {
                            details = result.Data;
                        }

                        dataGridView2.DataSource = details;
                        
                        getStatistics(details);

                        lblInfo2.Text = "Bilgiler başarılı bir şekilde getirilmiştir.";
                        return;
                    }

                    lblInfo2.Text = "Bilgiler getirilirken bir hata oluştu.";
                }
                else
                {
                    lblInfo2.Text = "Bilgiler getirilirken bir hata oluştu.";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void getStatistics(List<SaleDetailDto> detailList)
        {
            float toplamSatisFiyati = 0;
            float toplamAlisFiyati = 0;
            int satisSayisi = 0;
            int iadeSayisi = 0;

            List<string> supplierNames = new List<string>();
            foreach (var item in detailList)
            {
                toplamSatisFiyati += item.Price * (item.SaleAmount - item.ReturnAmount);
                toplamAlisFiyati += item.PurchasePrice * (item.SaleAmount-item.ReturnAmount);
                satisSayisi += item.SaleAmount;
                iadeSayisi += item.ReturnAmount;
                if (!supplierNames.Contains(item.SupplierName))
                {
                    supplierNames.Add(item.SupplierName);
                }
            }

            txtKarZarar.Text = (toplamSatisFiyati-toplamAlisFiyati).ToString();
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

                    lblInfo3.Text = "Müşteri getirildi.";
                    return;
                }
                lblInfo3.Text = "Müşteri bulunamadı.";
            }
            catch (Exception ex)
            {
                throw ex;
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

                    lblInfo3.Text = "Satışı yapılacak ürün getirildi.";
                    return;
                }
                lblInfo3.Text = "Satışı yapılacak ürün bulunamadı.";
            }
            catch (Exception ex)
            {
                throw ex;
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
                
                if (result.Success)
                {
                    lblInfo3.Text = "Müşteri başarıyla eklenmiştir. Satışa devam edebilirsiniz.";
                    return;
                }

                lblInfo3.Text = "Müşteri eklenirken bir sorun oluştu.";
            }
            catch (Exception ex)
            {
                throw ex;
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

                var urunKodu = txtUrunKoduSatis.Text;
                var urun = _productService.getProductByCode(urunKodu);

                if (urun.Success)
                {
                    var phoneNo = txtTelNoSatis.Text;
                    var musteri = _customerService.GetCustomerByPhoneNumber(phoneNo);

                    if (musteri.Success)
                    {
                        var stock = _stockService.getStockByProductID(urun.Data.ProductID);

                        if (stock.Success)
                        {
                            Stock updatedStock = new Stock
                            {
                                ProductID = stock.Data.ProductID,
                                StockAmount = stock.Data.StockAmount - 1,
                                SaleAmount = stock.Data.SaleAmount + 1,
                                ReturnAmount = stock.Data.ReturnAmount
                            };
                            var result = _stockService.update(updatedStock);

                            if (result.Success)
                            {
                                Sale sale = new Sale
                                {
                                    ProductID = urun.Data.ProductID,
                                    SaleDate = DateTime.Now,
                                    CustomerID = musteri.Data.CustomerID
                                };
                                var satis = _saleService.add(sale);

                                if (satis.Success)
                                {
                                    lblInfo3.Text = "Satış başarıyla tamamlandı.";
                                    return;
                                }
                            }
                        }
                    }
                }

                lblInfo3.Text = "Satış işlemi sırasında bir hata oluştu.";
            }
            catch (Exception ex)
            {
                lblInfo3.Text = "Satış işlemi sırasında bir hata oluştu.";
                throw ex;
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

                if (satisId != -1)
                {
                    var satis = _saleService.getSaleById(satisId);

                    if (satis.Success)
                    {
                        var urun = _productService.getProductById(satis.Data.ProductID);
                        var musteri = _customerService.getCustomerById(satis.Data.CustomerID);

                        if (urun.Success && musteri.Success)
                        {
                            txtTelNoIade.Text = musteri.Data.PhoneNumber;
                            txtUrunKoduIade.Text = urun.Data.ProductCode;
                            txtSatisTarihiIade.Text = satis.Data.SaleDate.ToString();

                            lblInfo3.Text = "İadesi bilgisi başarıyla getirildi.";
                            return;
                        }
                    }
                }
                lblInfo3.Text = "İade bilgisi bulunamadı.";
            }
            catch (Exception ex)
            {
                lblInfo3.Text = "İade bilgisi getirilirken bir hata oluştu.";
                throw ex;
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

                if (satisId != -1)
                {
                    var satis = _saleService.getSaleById(satisId);

                    if (satis.Success)
                    {
                        var stock = _stockService.getStockByProductID(satis.Data.ProductID);

                        if (stock.Success)
                        {
                            Stock updatedStock = new Stock
                            {
                                ProductID = stock.Data.ProductID,
                                StockAmount = stock.Data.StockAmount + 1,
                                ReturnAmount = stock.Data.ReturnAmount + 1,
                                SaleAmount = stock.Data.SaleAmount
                            };

                            var result = _stockService.update(updatedStock);

                            if (result.Success)
                            {
                                Return iade = new Return
                                {
                                    SaleID = satisId,
                                    ReturnDate = DateTime.Now
                                };
                                var iadeEdildi = _returnService.add(iade);

                                if (iadeEdildi.Success)
                                {
                                    lblInfo3.Text = "Ürünün iadesi başarıyla alındı.";
                                    return;
                                }
                            }
                        }
                    }
                }
                lblInfo3.Text = "İade alınamadı.";
            }
            catch (Exception ex)
            {
                lblInfo3.Text = "İade alınırken bir hata oluştu.";
                throw ex;
            }
        }
    }
}
