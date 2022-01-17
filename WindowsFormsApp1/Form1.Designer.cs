
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDetailDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnList = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpUrunList = new System.Windows.Forms.GroupBox();
            this.txtAciklamaListe = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAlisFiyatiList = new System.Windows.Forms.TextBox();
            this.txtStokLimiti = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAzalanStok = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbTedarikcilerListe = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtStokSayisiListe = new System.Windows.Forms.TextBox();
            this.txtBrandListe = new System.Windows.Forms.TextBox();
            this.txtPriceListe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunAdiListe = new System.Windows.Forms.TextBox();
            this.txtMenseiListe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUrunKoduListe = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.cmbTedarikciler = new System.Windows.Forms.ComboBox();
            this.txtStokSayisi = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStokSayisi = new System.Windows.Forms.Label();
            this.lblTedarikci = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtMensei = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblMensei = new System.Windows.Forms.Label();
            this.lblUrunCode = new System.Windows.Forms.Label();
            this.txtUrunCode = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSaleAmount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtUrunCesidi = new System.Windows.Forms.TextBox();
            this.txtReturnAmount = new System.Windows.Forms.TextBox();
            this.txtTedarikciSayisi = new System.Windows.Forms.TextBox();
            this.txtKarZarar = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblHangiYillarArasinda = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkEnCokMu = new System.Windows.Forms.CheckBox();
            this.chkEnAzMi = new System.Windows.Forms.CheckBox();
            this.txtSatilanUrunLimiti = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBilgileriGetir = new System.Windows.Forms.Button();
            this.txtEndYear = new System.Windows.Forms.TextBox();
            this.txtStartYear = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDetailDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.rxtAciklamaFatura = new System.Windows.Forms.RichTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtUrunKoduFatura = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.txtTelNoFatura = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtSoyadFatura = new System.Windows.Forms.TextBox();
            this.txtAdFatura = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtIadeTutariFatura = new System.Windows.Forms.TextBox();
            this.txtSatisFiyatiFatura = new System.Windows.Forms.TextBox();
            this.lblIadeTutariFatura = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtIadeTarihiFatura = new System.Windows.Forms.TextBox();
            this.txtSatisTarihiFatura = new System.Windows.Forms.TextBox();
            this.lblIadeTarihiFatura = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtSatisKoduFatura = new System.Windows.Forms.TextBox();
            this.txtIadeKoduFatura = new System.Windows.Forms.TextBox();
            this.lblIadeKoduFatura = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtTelNoIade = new System.Windows.Forms.TextBox();
            this.txtSatisTarihiIade = new System.Windows.Forms.TextBox();
            this.txtUrunKoduIade = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.btnSatisGetir = new System.Windows.Forms.Button();
            this.btnIadeAl = new System.Windows.Forms.Button();
            this.txtSatisIDIade = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtFiyatSatis = new System.Windows.Forms.TextBox();
            this.rxtAciklamaSatis = new System.Windows.Forms.RichTextBox();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.txtMusteriSoyadSatis = new System.Windows.Forms.TextBox();
            this.txtMusteriAdSatis = new System.Windows.Forms.TextBox();
            this.txtTelNoSatis = new System.Windows.Forms.TextBox();
            this.txtUrunKoduSatis = new System.Windows.Forms.TextBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriGetir = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnUrunGetir = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.saleReturnDetailDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleDetailDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDetailDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpUrunList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailDtoBindingSource1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleReturnDetailDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailDtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.PurchasePrice,
            this.brandDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.SupplierName,
            this.originDataGridViewTextBoxColumn,
            this.StockAmount,
            this.SaleAmount,
            this.ReturnAmount});
            this.dataGridView1.DataSource = this.productDetailDtoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Coral;
            this.dataGridView1.Location = new System.Drawing.Point(15, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1478, 325);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.HeaderText = "PurchasePrice";
            this.PurchasePrice.MinimumWidth = 6;
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "SupplierName";
            this.SupplierName.MinimumWidth = 6;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Width = 125;
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.HeaderText = "Origin";
            this.originDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            this.originDataGridViewTextBoxColumn.Width = 125;
            // 
            // StockAmount
            // 
            this.StockAmount.DataPropertyName = "StockAmount";
            this.StockAmount.HeaderText = "StockAmount";
            this.StockAmount.MinimumWidth = 6;
            this.StockAmount.Name = "StockAmount";
            this.StockAmount.Width = 125;
            // 
            // SaleAmount
            // 
            this.SaleAmount.DataPropertyName = "SaleAmount";
            this.SaleAmount.HeaderText = "SaleAmount";
            this.SaleAmount.MinimumWidth = 6;
            this.SaleAmount.Name = "SaleAmount";
            this.SaleAmount.Width = 125;
            // 
            // ReturnAmount
            // 
            this.ReturnAmount.DataPropertyName = "ReturnAmount";
            this.ReturnAmount.HeaderText = "ReturnAmount";
            this.ReturnAmount.MinimumWidth = 6;
            this.ReturnAmount.Name = "ReturnAmount";
            this.ReturnAmount.Width = 125;
            // 
            // productDetailDtoBindingSource
            // 
            this.productDetailDtoBindingSource.DataSource = typeof(Entities.DTOs.ProductDetailDto);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Entities.Concrete.Product);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Entities.Concrete.Customer);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.LightGreen;
            this.btnList.Location = new System.Drawing.Point(761, 115);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(121, 36);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Ürün Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1518, 668);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.grpUrunList);
            this.tabPage1.Controls.Add(this.lblInfo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1510, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stok İşlemleri";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(15, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 32);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Ürün Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpUrunList
            // 
            this.grpUrunList.Controls.Add(this.txtAciklamaListe);
            this.grpUrunList.Controls.Add(this.label10);
            this.grpUrunList.Controls.Add(this.txtAlisFiyatiList);
            this.grpUrunList.Controls.Add(this.txtStokLimiti);
            this.grpUrunList.Controls.Add(this.label15);
            this.grpUrunList.Controls.Add(this.btnAzalanStok);
            this.grpUrunList.Controls.Add(this.label9);
            this.grpUrunList.Controls.Add(this.btnUpdate);
            this.grpUrunList.Controls.Add(this.cmbTedarikcilerListe);
            this.grpUrunList.Controls.Add(this.txtStokSayisiListe);
            this.grpUrunList.Controls.Add(this.txtBrandListe);
            this.grpUrunList.Controls.Add(this.txtPriceListe);
            this.grpUrunList.Controls.Add(this.btnList);
            this.grpUrunList.Controls.Add(this.label1);
            this.grpUrunList.Controls.Add(this.label2);
            this.grpUrunList.Controls.Add(this.label3);
            this.grpUrunList.Controls.Add(this.label4);
            this.grpUrunList.Controls.Add(this.label5);
            this.grpUrunList.Controls.Add(this.txtUrunAdiListe);
            this.grpUrunList.Controls.Add(this.txtMenseiListe);
            this.grpUrunList.Controls.Add(this.label6);
            this.grpUrunList.Controls.Add(this.label7);
            this.grpUrunList.Controls.Add(this.label8);
            this.grpUrunList.Controls.Add(this.txtUrunKoduListe);
            this.grpUrunList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUrunList.Location = new System.Drawing.Point(558, 44);
            this.grpUrunList.Name = "grpUrunList";
            this.grpUrunList.Size = new System.Drawing.Size(935, 218);
            this.grpUrunList.TabIndex = 10;
            this.grpUrunList.TabStop = false;
            this.grpUrunList.Text = "Ürün Listele/Güncelle";
            // 
            // txtAciklamaListe
            // 
            this.txtAciklamaListe.BackColor = System.Drawing.Color.LightCoral;
            this.txtAciklamaListe.Location = new System.Drawing.Point(110, 128);
            this.txtAciklamaListe.Name = "txtAciklamaListe";
            this.txtAciklamaListe.Size = new System.Drawing.Size(138, 75);
            this.txtAciklamaListe.TabIndex = 38;
            this.txtAciklamaListe.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(455, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Stok Limiti:";
            // 
            // txtAlisFiyatiList
            // 
            this.txtAlisFiyatiList.BackColor = System.Drawing.Color.LightCoral;
            this.txtAlisFiyatiList.Location = new System.Drawing.Point(353, 153);
            this.txtAlisFiyatiList.Name = "txtAlisFiyatiList";
            this.txtAlisFiyatiList.Size = new System.Drawing.Size(100, 22);
            this.txtAlisFiyatiList.TabIndex = 37;
            // 
            // txtStokLimiti
            // 
            this.txtStokLimiti.BackColor = System.Drawing.Color.LightCoral;
            this.txtStokLimiti.Location = new System.Drawing.Point(554, 176);
            this.txtStokLimiti.Name = "txtStokLimiti";
            this.txtStokLimiti.Size = new System.Drawing.Size(100, 22);
            this.txtStokLimiti.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(254, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 17);
            this.label15.TabIndex = 36;
            this.label15.Text = "Alış Fiyatı:";
            // 
            // btnAzalanStok
            // 
            this.btnAzalanStok.BackColor = System.Drawing.Color.Orange;
            this.btnAzalanStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAzalanStok.Location = new System.Drawing.Point(681, 171);
            this.btnAzalanStok.Name = "btnAzalanStok";
            this.btnAzalanStok.Size = new System.Drawing.Size(237, 32);
            this.btnAzalanStok.TabIndex = 12;
            this.btnAzalanStok.Text = "Stoğu Azalan Ürünleri Getir";
            this.btnAzalanStok.UseVisualStyleBackColor = false;
            this.btnAzalanStok.Click += new System.EventHandler(this.btnAzalanStok_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(352, 68);
            this.label9.TabIndex = 35;
            this.label9.Text = "***Lütfen listeleme işlemi yaparken filtre olarak \r\nTedarikçi, Ürün Adı veya Ürün" +
    "Kodu alanlarını \r\nkullanınız. Diğer alanlar ürünün detaylarını \r\ngöstermek veya " +
    "güncellemek içindir. ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightGreen;
            this.btnUpdate.Location = new System.Drawing.Point(588, 115);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 36);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Ürün Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbTedarikcilerListe
            // 
            this.cmbTedarikcilerListe.BackColor = System.Drawing.Color.LightCoral;
            this.cmbTedarikcilerListe.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierBindingSource, "SupplierID", true));
            this.cmbTedarikcilerListe.DataSource = this.supplierBindingSource;
            this.cmbTedarikcilerListe.DisplayMember = "SupplierName";
            this.cmbTedarikcilerListe.FormattingEnabled = true;
            this.cmbTedarikcilerListe.Location = new System.Drawing.Point(353, 93);
            this.cmbTedarikcilerListe.Name = "cmbTedarikcilerListe";
            this.cmbTedarikcilerListe.Size = new System.Drawing.Size(121, 24);
            this.cmbTedarikcilerListe.TabIndex = 33;
            this.cmbTedarikcilerListe.ValueMember = "SupplierID";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Entities.Concrete.Supplier);
            // 
            // txtStokSayisiListe
            // 
            this.txtStokSayisiListe.BackColor = System.Drawing.Color.LightCoral;
            this.txtStokSayisiListe.Location = new System.Drawing.Point(353, 125);
            this.txtStokSayisiListe.Name = "txtStokSayisiListe";
            this.txtStokSayisiListe.Size = new System.Drawing.Size(100, 22);
            this.txtStokSayisiListe.TabIndex = 32;
            // 
            // txtBrandListe
            // 
            this.txtBrandListe.BackColor = System.Drawing.Color.LightCoral;
            this.txtBrandListe.Location = new System.Drawing.Point(353, 60);
            this.txtBrandListe.Name = "txtBrandListe";
            this.txtBrandListe.Size = new System.Drawing.Size(100, 22);
            this.txtBrandListe.TabIndex = 31;
            // 
            // txtPriceListe
            // 
            this.txtPriceListe.BackColor = System.Drawing.Color.LightCoral;
            this.txtPriceListe.Location = new System.Drawing.Point(353, 28);
            this.txtPriceListe.Name = "txtPriceListe";
            this.txtPriceListe.Size = new System.Drawing.Size(100, 22);
            this.txtPriceListe.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(254, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Stok Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(254, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tedarikçi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(254, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(254, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Açıklama:";
            // 
            // txtUrunAdiListe
            // 
            this.txtUrunAdiListe.BackColor = System.Drawing.Color.LightCoral;
            this.txtUrunAdiListe.Location = new System.Drawing.Point(110, 27);
            this.txtUrunAdiListe.Name = "txtUrunAdiListe";
            this.txtUrunAdiListe.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdiListe.TabIndex = 19;
            // 
            // txtMenseiListe
            // 
            this.txtMenseiListe.BackColor = System.Drawing.Color.LightCoral;
            this.txtMenseiListe.Location = new System.Drawing.Point(110, 90);
            this.txtMenseiListe.Name = "txtMenseiListe";
            this.txtMenseiListe.Size = new System.Drawing.Size(100, 22);
            this.txtMenseiListe.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ürün Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(19, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Menşei:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(19, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ürün Kodu:";
            // 
            // txtUrunKoduListe
            // 
            this.txtUrunKoduListe.BackColor = System.Drawing.Color.LightCoral;
            this.txtUrunKoduListe.Location = new System.Drawing.Point(110, 59);
            this.txtUrunKoduListe.Name = "txtUrunKoduListe";
            this.txtUrunKoduListe.Size = new System.Drawing.Size(100, 22);
            this.txtUrunKoduListe.TabIndex = 21;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.Location = new System.Drawing.Point(29, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.txtAlisFiyati);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnUrunEkle);
            this.groupBox1.Controls.Add(this.cmbTedarikciler);
            this.groupBox1.Controls.Add(this.txtStokSayisi);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lblStokSayisi);
            this.groupBox1.Controls.Add(this.lblTedarikci);
            this.groupBox1.Controls.Add(this.lblMarka);
            this.groupBox1.Controls.Add(this.lblFiyat);
            this.groupBox1.Controls.Add(this.lblAciklama);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.txtMensei);
            this.groupBox1.Controls.Add(this.lblUrunAdi);
            this.groupBox1.Controls.Add(this.lblMensei);
            this.groupBox1.Controls.Add(this.lblUrunCode);
            this.groupBox1.Controls.Add(this.txtUrunCode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 218);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün Ekle";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.LightCoral;
            this.txtAciklama.Location = new System.Drawing.Point(102, 124);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(131, 77);
            this.txtAciklama.TabIndex = 21;
            this.txtAciklama.Text = "";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.BackColor = System.Drawing.Color.LightCoral;
            this.txtAlisFiyati.Location = new System.Drawing.Point(330, 55);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(100, 22);
            this.txtAlisFiyati.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(231, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "Alış Fiyatı:";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(431, 176);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(100, 36);
            this.btnUrunEkle.TabIndex = 18;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // cmbTedarikciler
            // 
            this.cmbTedarikciler.BackColor = System.Drawing.Color.LightCoral;
            this.cmbTedarikciler.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierBindingSource, "SupplierID", true));
            this.cmbTedarikciler.DataSource = this.supplierBindingSource;
            this.cmbTedarikciler.DisplayMember = "SupplierName";
            this.cmbTedarikciler.FormattingEnabled = true;
            this.cmbTedarikciler.Location = new System.Drawing.Point(330, 121);
            this.cmbTedarikciler.Name = "cmbTedarikciler";
            this.cmbTedarikciler.Size = new System.Drawing.Size(121, 24);
            this.cmbTedarikciler.TabIndex = 17;
            this.cmbTedarikciler.ValueMember = "SupplierID";
            // 
            // txtStokSayisi
            // 
            this.txtStokSayisi.BackColor = System.Drawing.Color.LightCoral;
            this.txtStokSayisi.Location = new System.Drawing.Point(330, 153);
            this.txtStokSayisi.Name = "txtStokSayisi";
            this.txtStokSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtStokSayisi.TabIndex = 16;
            // 
            // txtMarka
            // 
            this.txtMarka.BackColor = System.Drawing.Color.LightCoral;
            this.txtMarka.Location = new System.Drawing.Point(330, 88);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 22);
            this.txtMarka.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.LightCoral;
            this.txtPrice.Location = new System.Drawing.Point(330, 25);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 14;
            // 
            // lblStokSayisi
            // 
            this.lblStokSayisi.AutoSize = true;
            this.lblStokSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokSayisi.Location = new System.Drawing.Point(231, 156);
            this.lblStokSayisi.Name = "lblStokSayisi";
            this.lblStokSayisi.Size = new System.Drawing.Size(93, 17);
            this.lblStokSayisi.TabIndex = 13;
            this.lblStokSayisi.Text = "Stok Sayısı:";
            // 
            // lblTedarikci
            // 
            this.lblTedarikci.AutoSize = true;
            this.lblTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTedarikci.Location = new System.Drawing.Point(231, 124);
            this.lblTedarikci.Name = "lblTedarikci";
            this.lblTedarikci.Size = new System.Drawing.Size(80, 17);
            this.lblTedarikci.TabIndex = 12;
            this.lblTedarikci.Text = "Tedarikçi:";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(231, 91);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(57, 17);
            this.lblMarka.TabIndex = 11;
            this.lblMarka.Text = "Marka:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(231, 28);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(93, 17);
            this.lblFiyat.TabIndex = 10;
            this.lblFiyat.Text = "Satış Fiyatı:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(6, 128);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(77, 17);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.BackColor = System.Drawing.Color.LightCoral;
            this.txtUrunAdi.Location = new System.Drawing.Point(102, 27);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // txtMensei
            // 
            this.txtMensei.BackColor = System.Drawing.Color.LightCoral;
            this.txtMensei.Location = new System.Drawing.Point(102, 91);
            this.txtMensei.Name = "txtMensei";
            this.txtMensei.Size = new System.Drawing.Size(100, 22);
            this.txtMensei.TabIndex = 7;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(6, 30);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(76, 17);
            this.lblUrunAdi.TabIndex = 2;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblMensei
            // 
            this.lblMensei.AutoSize = true;
            this.lblMensei.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMensei.Location = new System.Drawing.Point(6, 96);
            this.lblMensei.Name = "lblMensei";
            this.lblMensei.Size = new System.Drawing.Size(64, 17);
            this.lblMensei.TabIndex = 6;
            this.lblMensei.Text = "Menşei:";
            // 
            // lblUrunCode
            // 
            this.lblUrunCode.AutoSize = true;
            this.lblUrunCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunCode.Location = new System.Drawing.Point(6, 60);
            this.lblUrunCode.Name = "lblUrunCode";
            this.lblUrunCode.Size = new System.Drawing.Size(90, 17);
            this.lblUrunCode.TabIndex = 4;
            this.lblUrunCode.Text = "Ürün Kodu:";
            // 
            // txtUrunCode
            // 
            this.txtUrunCode.BackColor = System.Drawing.Color.LightCoral;
            this.txtUrunCode.Location = new System.Drawing.Point(102, 58);
            this.txtUrunCode.Name = "txtUrunCode";
            this.txtUrunCode.Size = new System.Drawing.Size(100, 22);
            this.txtUrunCode.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage2.Controls.Add(this.lblInfo2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1510, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Finansal İşlemler";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo2.Location = new System.Drawing.Point(30, 16);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(0, 25);
            this.lblInfo2.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtSaleAmount);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtUrunCesidi);
            this.groupBox4.Controls.Add(this.txtReturnAmount);
            this.groupBox4.Controls.Add(this.txtTedarikciSayisi);
            this.groupBox4.Controls.Add(this.txtKarZarar);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.lblHangiYillarArasinda);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(574, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(496, 262);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İstatistikler";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 169);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 17);
            this.label22.TabIndex = 14;
            this.label22.Text = "Tedarikçi Sayısı:";
            // 
            // txtSaleAmount
            // 
            this.txtSaleAmount.BackColor = System.Drawing.Color.LightCoral;
            this.txtSaleAmount.Location = new System.Drawing.Point(375, 118);
            this.txtSaleAmount.Name = "txtSaleAmount";
            this.txtSaleAmount.Size = new System.Drawing.Size(100, 22);
            this.txtSaleAmount.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(262, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 17);
            this.label20.TabIndex = 11;
            this.label20.Text = "Ürün Çeşidi:";
            // 
            // txtUrunCesidi
            // 
            this.txtUrunCesidi.BackColor = System.Drawing.Color.LightCoral;
            this.txtUrunCesidi.Location = new System.Drawing.Point(375, 75);
            this.txtUrunCesidi.Name = "txtUrunCesidi";
            this.txtUrunCesidi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunCesidi.TabIndex = 10;
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.BackColor = System.Drawing.Color.LightCoral;
            this.txtReturnAmount.Location = new System.Drawing.Point(149, 120);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.Size = new System.Drawing.Size(100, 22);
            this.txtReturnAmount.TabIndex = 9;
            // 
            // txtTedarikciSayisi
            // 
            this.txtTedarikciSayisi.BackColor = System.Drawing.Color.LightCoral;
            this.txtTedarikciSayisi.Location = new System.Drawing.Point(149, 166);
            this.txtTedarikciSayisi.Name = "txtTedarikciSayisi";
            this.txtTedarikciSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtTedarikciSayisi.TabIndex = 7;
            // 
            // txtKarZarar
            // 
            this.txtKarZarar.BackColor = System.Drawing.Color.LightCoral;
            this.txtKarZarar.Location = new System.Drawing.Point(149, 73);
            this.txtKarZarar.Name = "txtKarZarar";
            this.txtKarZarar.Size = new System.Drawing.Size(100, 22);
            this.txtKarZarar.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 123);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 17);
            this.label19.TabIndex = 4;
            this.label19.Text = "İade Sayısı:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(262, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "Satış Sayısı:";
            // 
            // lblHangiYillarArasinda
            // 
            this.lblHangiYillarArasinda.AutoSize = true;
            this.lblHangiYillarArasinda.Location = new System.Drawing.Point(20, 43);
            this.lblHangiYillarArasinda.Name = "lblHangiYillarArasinda";
            this.lblHangiYillarArasinda.Size = new System.Drawing.Size(0, 17);
            this.lblHangiYillarArasinda.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Kar/Zarar(TL):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.chkEnCokMu);
            this.groupBox3.Controls.Add(this.chkEnAzMi);
            this.groupBox3.Controls.Add(this.txtSatilanUrunLimiti);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnBilgileriGetir);
            this.groupBox3.Controls.Add(this.txtEndYear);
            this.groupBox3.Controls.Add(this.txtStartYear);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(16, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 262);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yıllara Göre Listele";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(297, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(213, 17);
            this.label17.TabIndex = 13;
            this.label17.Text = "***Satış sayısı limitini giriniz.";
            // 
            // chkEnCokMu
            // 
            this.chkEnCokMu.AutoSize = true;
            this.chkEnCokMu.Location = new System.Drawing.Point(21, 214);
            this.chkEnCokMu.Name = "chkEnCokMu";
            this.chkEnCokMu.Size = new System.Drawing.Size(195, 21);
            this.chkEnCokMu.TabIndex = 12;
            this.chkEnCokMu.Text = "En Çok Satılan Ürünler";
            this.chkEnCokMu.UseVisualStyleBackColor = true;
            // 
            // chkEnAzMi
            // 
            this.chkEnAzMi.AutoSize = true;
            this.chkEnAzMi.Location = new System.Drawing.Point(21, 178);
            this.chkEnAzMi.Name = "chkEnAzMi";
            this.chkEnAzMi.Size = new System.Drawing.Size(186, 21);
            this.chkEnAzMi.TabIndex = 11;
            this.chkEnAzMi.Text = "En Az Satılan Ürünler";
            this.chkEnAzMi.UseVisualStyleBackColor = true;
            // 
            // txtSatilanUrunLimiti
            // 
            this.txtSatilanUrunLimiti.BackColor = System.Drawing.Color.LightCoral;
            this.txtSatilanUrunLimiti.Location = new System.Drawing.Point(131, 132);
            this.txtSatilanUrunLimiti.Name = "txtSatilanUrunLimiti";
            this.txtSatilanUrunLimiti.Size = new System.Drawing.Size(138, 22);
            this.txtSatilanUrunLimiti.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 137);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 17);
            this.label21.TabIndex = 9;
            this.label21.Text = "Satış Sayısı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 34);
            this.label13.TabIndex = 6;
            this.label13.Text = "***Tarih aralıklarını sadece \r\nyıl olarak giriniz.";
            // 
            // btnBilgileriGetir
            // 
            this.btnBilgileriGetir.BackColor = System.Drawing.Color.LightGreen;
            this.btnBilgileriGetir.Location = new System.Drawing.Point(370, 200);
            this.btnBilgileriGetir.Name = "btnBilgileriGetir";
            this.btnBilgileriGetir.Size = new System.Drawing.Size(126, 35);
            this.btnBilgileriGetir.TabIndex = 5;
            this.btnBilgileriGetir.Text = "Bilgileri Getir";
            this.btnBilgileriGetir.UseVisualStyleBackColor = false;
            this.btnBilgileriGetir.Click += new System.EventHandler(this.btnBilgileriGetir_Click);
            // 
            // txtEndYear
            // 
            this.txtEndYear.BackColor = System.Drawing.Color.LightCoral;
            this.txtEndYear.Location = new System.Drawing.Point(131, 73);
            this.txtEndYear.Name = "txtEndYear";
            this.txtEndYear.Size = new System.Drawing.Size(138, 22);
            this.txtEndYear.TabIndex = 4;
            // 
            // txtStartYear
            // 
            this.txtStartYear.BackColor = System.Drawing.Color.LightCoral;
            this.txtStartYear.Location = new System.Drawing.Point(131, 40);
            this.txtStartYear.Name = "txtStartYear";
            this.txtStartYear.Size = new System.Drawing.Size(138, 22);
            this.txtStartYear.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(18, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Bitiş Yılı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(15, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Başlangıç Yılı:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCodeDataGridViewTextBoxColumn1,
            this.ProductName,
            this.dataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.DataSource = this.saleDetailDtoBindingSource1;
            this.dataGridView2.GridColor = System.Drawing.Color.Coral;
            this.dataGridView2.Location = new System.Drawing.Point(16, 319);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1054, 305);
            this.dataGridView2.TabIndex = 0;
            // 
            // productCodeDataGridViewTextBoxColumn1
            // 
            this.productCodeDataGridViewTextBoxColumn1.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn1.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.productCodeDataGridViewTextBoxColumn1.Name = "productCodeDataGridViewTextBoxColumn1";
            this.productCodeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SupplierName";
            this.dataGridViewTextBoxColumn1.HeaderText = "SupplierName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PurchasePrice";
            this.dataGridViewTextBoxColumn2.HeaderText = "PurchasePrice";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ReturnAmount";
            this.dataGridViewTextBoxColumn3.HeaderText = "ReturnAmount";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StockAmount";
            this.dataGridViewTextBoxColumn4.HeaderText = "StockAmount";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SaleAmount";
            this.dataGridViewTextBoxColumn5.HeaderText = "SaleAmount";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // saleDetailDtoBindingSource1
            // 
            this.saleDetailDtoBindingSource1.DataSource = typeof(Entities.DTOs.SaleDetailDto);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.lblInfo3);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1510, 639);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ürün Satış/İade İşlemleri";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Silver;
            this.groupBox7.Controls.Add(this.label47);
            this.groupBox7.Controls.Add(this.label46);
            this.groupBox7.Controls.Add(this.label45);
            this.groupBox7.Controls.Add(this.rxtAciklamaFatura);
            this.groupBox7.Controls.Add(this.label44);
            this.groupBox7.Controls.Add(this.txtUrunKoduFatura);
            this.groupBox7.Controls.Add(this.label43);
            this.groupBox7.Controls.Add(this.label42);
            this.groupBox7.Controls.Add(this.label41);
            this.groupBox7.Controls.Add(this.txtTelNoFatura);
            this.groupBox7.Controls.Add(this.label40);
            this.groupBox7.Controls.Add(this.txtSoyadFatura);
            this.groupBox7.Controls.Add(this.txtAdFatura);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.txtIadeTutariFatura);
            this.groupBox7.Controls.Add(this.txtSatisFiyatiFatura);
            this.groupBox7.Controls.Add(this.lblIadeTutariFatura);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.txtIadeTarihiFatura);
            this.groupBox7.Controls.Add(this.txtSatisTarihiFatura);
            this.groupBox7.Controls.Add(this.lblIadeTarihiFatura);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.txtSatisKoduFatura);
            this.groupBox7.Controls.Add(this.txtIadeKoduFatura);
            this.groupBox7.Controls.Add(this.lblIadeKoduFatura);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(777, 48);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(537, 573);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Fatura";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(90, 546);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(364, 17);
            this.label47.TabIndex = 27;
            this.label47.Text = "BİZİ TERCİH ETTİĞİNİZ İÇİN TEŞEKKÜR EDERİZ.";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(36, 442);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(141, 17);
            this.label46.TabIndex = 26;
            this.label46.Text = "ÖDEME BİLGİLERİ";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(35, 326);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(131, 17);
            this.label45.TabIndex = 25;
            this.label45.Text = "İŞLEM BİLGİLERİ";
            // 
            // rxtAciklamaFatura
            // 
            this.rxtAciklamaFatura.BackColor = System.Drawing.Color.Silver;
            this.rxtAciklamaFatura.Enabled = false;
            this.rxtAciklamaFatura.Location = new System.Drawing.Point(203, 238);
            this.rxtAciklamaFatura.Name = "rxtAciklamaFatura";
            this.rxtAciklamaFatura.Size = new System.Drawing.Size(298, 66);
            this.rxtAciklamaFatura.TabIndex = 24;
            this.rxtAciklamaFatura.Text = "";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(36, 241);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(117, 17);
            this.label44.TabIndex = 23;
            this.label44.Text = "Ürün Açıklama:";
            // 
            // txtUrunKoduFatura
            // 
            this.txtUrunKoduFatura.BackColor = System.Drawing.Color.Silver;
            this.txtUrunKoduFatura.Enabled = false;
            this.txtUrunKoduFatura.Location = new System.Drawing.Point(203, 201);
            this.txtUrunKoduFatura.Name = "txtUrunKoduFatura";
            this.txtUrunKoduFatura.Size = new System.Drawing.Size(100, 22);
            this.txtUrunKoduFatura.TabIndex = 22;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(35, 204);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(90, 17);
            this.label43.TabIndex = 21;
            this.label43.Text = "Ürün Kodu:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(35, 172);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(130, 17);
            this.label42.TabIndex = 20;
            this.label42.Text = "ÜRÜN BİLGİLERİ";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(35, 28);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(154, 17);
            this.label41.TabIndex = 19;
            this.label41.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // txtTelNoFatura
            // 
            this.txtTelNoFatura.BackColor = System.Drawing.Color.Silver;
            this.txtTelNoFatura.Enabled = false;
            this.txtTelNoFatura.Location = new System.Drawing.Point(203, 126);
            this.txtTelNoFatura.Name = "txtTelNoFatura";
            this.txtTelNoFatura.Size = new System.Drawing.Size(100, 22);
            this.txtTelNoFatura.TabIndex = 18;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(35, 131);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(93, 17);
            this.label40.TabIndex = 17;
            this.label40.Text = "Telefon No:";
            // 
            // txtSoyadFatura
            // 
            this.txtSoyadFatura.BackColor = System.Drawing.Color.Silver;
            this.txtSoyadFatura.Enabled = false;
            this.txtSoyadFatura.Location = new System.Drawing.Point(203, 89);
            this.txtSoyadFatura.Name = "txtSoyadFatura";
            this.txtSoyadFatura.Size = new System.Drawing.Size(100, 22);
            this.txtSoyadFatura.TabIndex = 15;
            // 
            // txtAdFatura
            // 
            this.txtAdFatura.BackColor = System.Drawing.Color.Silver;
            this.txtAdFatura.Enabled = false;
            this.txtAdFatura.Location = new System.Drawing.Point(203, 53);
            this.txtAdFatura.Name = "txtAdFatura";
            this.txtAdFatura.Size = new System.Drawing.Size(100, 22);
            this.txtAdFatura.TabIndex = 14;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(35, 94);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(58, 17);
            this.label39.TabIndex = 13;
            this.label39.Text = "Soyad:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(36, 58);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(32, 17);
            this.label38.TabIndex = 12;
            this.label38.Text = "Ad:";
            // 
            // txtIadeTutariFatura
            // 
            this.txtIadeTutariFatura.BackColor = System.Drawing.Color.Silver;
            this.txtIadeTutariFatura.Enabled = false;
            this.txtIadeTutariFatura.Location = new System.Drawing.Point(181, 501);
            this.txtIadeTutariFatura.Name = "txtIadeTutariFatura";
            this.txtIadeTutariFatura.Size = new System.Drawing.Size(100, 22);
            this.txtIadeTutariFatura.TabIndex = 11;
            // 
            // txtSatisFiyatiFatura
            // 
            this.txtSatisFiyatiFatura.BackColor = System.Drawing.Color.Silver;
            this.txtSatisFiyatiFatura.Enabled = false;
            this.txtSatisFiyatiFatura.Location = new System.Drawing.Point(181, 472);
            this.txtSatisFiyatiFatura.Name = "txtSatisFiyatiFatura";
            this.txtSatisFiyatiFatura.Size = new System.Drawing.Size(100, 22);
            this.txtSatisFiyatiFatura.TabIndex = 10;
            // 
            // lblIadeTutariFatura
            // 
            this.lblIadeTutariFatura.AutoSize = true;
            this.lblIadeTutariFatura.Location = new System.Drawing.Point(36, 507);
            this.lblIadeTutariFatura.Name = "lblIadeTutariFatura";
            this.lblIadeTutariFatura.Size = new System.Drawing.Size(138, 17);
            this.lblIadeTutariFatura.TabIndex = 9;
            this.lblIadeTutariFatura.Text = "İade Edilen Tutar:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(36, 475);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(48, 17);
            this.label37.TabIndex = 8;
            this.label37.Text = "Fiyat:";
            // 
            // txtIadeTarihiFatura
            // 
            this.txtIadeTarihiFatura.BackColor = System.Drawing.Color.Silver;
            this.txtIadeTarihiFatura.Enabled = false;
            this.txtIadeTarihiFatura.Location = new System.Drawing.Point(404, 395);
            this.txtIadeTarihiFatura.Name = "txtIadeTarihiFatura";
            this.txtIadeTarihiFatura.Size = new System.Drawing.Size(100, 22);
            this.txtIadeTarihiFatura.TabIndex = 7;
            // 
            // txtSatisTarihiFatura
            // 
            this.txtSatisTarihiFatura.BackColor = System.Drawing.Color.Silver;
            this.txtSatisTarihiFatura.Enabled = false;
            this.txtSatisTarihiFatura.Location = new System.Drawing.Point(404, 355);
            this.txtSatisTarihiFatura.Name = "txtSatisTarihiFatura";
            this.txtSatisTarihiFatura.Size = new System.Drawing.Size(100, 22);
            this.txtSatisTarihiFatura.TabIndex = 6;
            // 
            // lblIadeTarihiFatura
            // 
            this.lblIadeTarihiFatura.AutoSize = true;
            this.lblIadeTarihiFatura.Location = new System.Drawing.Point(285, 398);
            this.lblIadeTarihiFatura.Name = "lblIadeTarihiFatura";
            this.lblIadeTarihiFatura.Size = new System.Drawing.Size(91, 17);
            this.lblIadeTarihiFatura.TabIndex = 5;
            this.lblIadeTarihiFatura.Text = "İade Tarihi:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(285, 358);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(96, 17);
            this.label36.TabIndex = 4;
            this.label36.Text = "Satış Tarihi:";
            // 
            // txtSatisKoduFatura
            // 
            this.txtSatisKoduFatura.BackColor = System.Drawing.Color.Silver;
            this.txtSatisKoduFatura.Enabled = false;
            this.txtSatisKoduFatura.Location = new System.Drawing.Point(143, 355);
            this.txtSatisKoduFatura.Name = "txtSatisKoduFatura";
            this.txtSatisKoduFatura.Size = new System.Drawing.Size(100, 22);
            this.txtSatisKoduFatura.TabIndex = 3;
            // 
            // txtIadeKoduFatura
            // 
            this.txtIadeKoduFatura.BackColor = System.Drawing.Color.Silver;
            this.txtIadeKoduFatura.Enabled = false;
            this.txtIadeKoduFatura.Location = new System.Drawing.Point(143, 395);
            this.txtIadeKoduFatura.Name = "txtIadeKoduFatura";
            this.txtIadeKoduFatura.Size = new System.Drawing.Size(100, 22);
            this.txtIadeKoduFatura.TabIndex = 2;
            // 
            // lblIadeKoduFatura
            // 
            this.lblIadeKoduFatura.AutoSize = true;
            this.lblIadeKoduFatura.Location = new System.Drawing.Point(37, 398);
            this.lblIadeKoduFatura.Name = "lblIadeKoduFatura";
            this.lblIadeKoduFatura.Size = new System.Drawing.Size(86, 17);
            this.lblIadeKoduFatura.TabIndex = 1;
            this.lblIadeKoduFatura.Text = "İade Kodu:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(36, 358);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(91, 17);
            this.label35.TabIndex = 0;
            this.label35.Text = "Satış Kodu:";
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo3.Location = new System.Drawing.Point(31, 14);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(0, 25);
            this.lblInfo3.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Controls.Add(this.txtTelNoIade);
            this.groupBox6.Controls.Add(this.txtSatisTarihiIade);
            this.groupBox6.Controls.Add(this.txtUrunKoduIade);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.btnSatisGetir);
            this.groupBox6.Controls.Add(this.btnIadeAl);
            this.groupBox6.Controls.Add(this.txtSatisIDIade);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Location = new System.Drawing.Point(16, 419);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(755, 202);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ürün İade";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(426, 35);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(314, 51);
            this.label34.TabIndex = 10;
            this.label34.Text = "***Satış Kodu olmadan iade işlemleri \r\nyapılamaz. Satış Kodu girildikten sonra \r\n" +
    "satış bilgileri getirilir ve iade işlemi yapılır.";
            // 
            // txtTelNoIade
            // 
            this.txtTelNoIade.BackColor = System.Drawing.Color.LightCoral;
            this.txtTelNoIade.Enabled = false;
            this.txtTelNoIade.Location = new System.Drawing.Point(125, 157);
            this.txtTelNoIade.Name = "txtTelNoIade";
            this.txtTelNoIade.Size = new System.Drawing.Size(119, 22);
            this.txtTelNoIade.TabIndex = 9;
            // 
            // txtSatisTarihiIade
            // 
            this.txtSatisTarihiIade.BackColor = System.Drawing.Color.LightCoral;
            this.txtSatisTarihiIade.Enabled = false;
            this.txtSatisTarihiIade.Location = new System.Drawing.Point(125, 118);
            this.txtSatisTarihiIade.Name = "txtSatisTarihiIade";
            this.txtSatisTarihiIade.Size = new System.Drawing.Size(118, 22);
            this.txtSatisTarihiIade.TabIndex = 8;
            // 
            // txtUrunKoduIade
            // 
            this.txtUrunKoduIade.BackColor = System.Drawing.Color.LightCoral;
            this.txtUrunKoduIade.Enabled = false;
            this.txtUrunKoduIade.Location = new System.Drawing.Point(125, 77);
            this.txtUrunKoduIade.Name = "txtUrunKoduIade";
            this.txtUrunKoduIade.Size = new System.Drawing.Size(118, 22);
            this.txtUrunKoduIade.TabIndex = 7;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(19, 163);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(93, 17);
            this.label33.TabIndex = 6;
            this.label33.Text = "Telefon No:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(19, 121);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(96, 17);
            this.label32.TabIndex = 5;
            this.label32.Text = "Satış Tarihi:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(19, 80);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 17);
            this.label31.TabIndex = 4;
            this.label31.Text = "Ürün Kodu:";
            // 
            // btnSatisGetir
            // 
            this.btnSatisGetir.BackColor = System.Drawing.Color.LightGreen;
            this.btnSatisGetir.Location = new System.Drawing.Point(272, 35);
            this.btnSatisGetir.Name = "btnSatisGetir";
            this.btnSatisGetir.Size = new System.Drawing.Size(104, 29);
            this.btnSatisGetir.TabIndex = 3;
            this.btnSatisGetir.Text = "Satış Getir";
            this.btnSatisGetir.UseVisualStyleBackColor = false;
            this.btnSatisGetir.Click += new System.EventHandler(this.btnSatisGetir_Click);
            // 
            // btnIadeAl
            // 
            this.btnIadeAl.BackColor = System.Drawing.Color.OrangeRed;
            this.btnIadeAl.Location = new System.Drawing.Point(608, 148);
            this.btnIadeAl.Name = "btnIadeAl";
            this.btnIadeAl.Size = new System.Drawing.Size(123, 31);
            this.btnIadeAl.TabIndex = 2;
            this.btnIadeAl.Text = "İade Al";
            this.btnIadeAl.UseVisualStyleBackColor = false;
            this.btnIadeAl.Click += new System.EventHandler(this.btnIadeAl_Click);
            // 
            // txtSatisIDIade
            // 
            this.txtSatisIDIade.BackColor = System.Drawing.Color.LightCoral;
            this.txtSatisIDIade.Location = new System.Drawing.Point(125, 37);
            this.txtSatisIDIade.Name = "txtSatisIDIade";
            this.txtSatisIDIade.Size = new System.Drawing.Size(118, 22);
            this.txtSatisIDIade.TabIndex = 1;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(19, 40);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(91, 17);
            this.label30.TabIndex = 0;
            this.label30.Text = "Satış Kodu:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.txtFiyatSatis);
            this.groupBox5.Controls.Add(this.rxtAciklamaSatis);
            this.groupBox5.Controls.Add(this.btnSatisYap);
            this.groupBox5.Controls.Add(this.txtMusteriSoyadSatis);
            this.groupBox5.Controls.Add(this.txtMusteriAdSatis);
            this.groupBox5.Controls.Add(this.txtTelNoSatis);
            this.groupBox5.Controls.Add(this.txtUrunKoduSatis);
            this.groupBox5.Controls.Add(this.btnMusteriEkle);
            this.groupBox5.Controls.Add(this.btnMusteriGetir);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.btnUrunGetir);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Location = new System.Drawing.Point(16, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(755, 365);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ürün Satış";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(426, 37);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(305, 68);
            this.label23.TabIndex = 19;
            this.label23.Text = "***Önce Ürün Kodu ile satışı yapılacak \r\nürün, sonra telefon numarası ile satış \r" +
    "\nyapılacak Müşteri getirilir. Müşteri kayıtlı \r\ndeğilse kaydedilir.";
            // 
            // txtFiyatSatis
            // 
            this.txtFiyatSatis.BackColor = System.Drawing.Color.LightCoral;
            this.txtFiyatSatis.Enabled = false;
            this.txtFiyatSatis.Location = new System.Drawing.Point(143, 75);
            this.txtFiyatSatis.Name = "txtFiyatSatis";
            this.txtFiyatSatis.Size = new System.Drawing.Size(100, 22);
            this.txtFiyatSatis.TabIndex = 18;
            // 
            // rxtAciklamaSatis
            // 
            this.rxtAciklamaSatis.BackColor = System.Drawing.Color.LightCoral;
            this.rxtAciklamaSatis.Enabled = false;
            this.rxtAciklamaSatis.Location = new System.Drawing.Point(143, 113);
            this.rxtAciklamaSatis.Name = "rxtAciklamaSatis";
            this.rxtAciklamaSatis.Size = new System.Drawing.Size(253, 98);
            this.rxtAciklamaSatis.TabIndex = 17;
            this.rxtAciklamaSatis.Text = "";
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSatisYap.Location = new System.Drawing.Point(608, 297);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(123, 31);
            this.btnSatisYap.TabIndex = 16;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = false;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // txtMusteriSoyadSatis
            // 
            this.txtMusteriSoyadSatis.BackColor = System.Drawing.Color.LightCoral;
            this.txtMusteriSoyadSatis.Location = new System.Drawing.Point(143, 320);
            this.txtMusteriSoyadSatis.Name = "txtMusteriSoyadSatis";
            this.txtMusteriSoyadSatis.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriSoyadSatis.TabIndex = 15;
            // 
            // txtMusteriAdSatis
            // 
            this.txtMusteriAdSatis.BackColor = System.Drawing.Color.LightCoral;
            this.txtMusteriAdSatis.Location = new System.Drawing.Point(143, 279);
            this.txtMusteriAdSatis.Name = "txtMusteriAdSatis";
            this.txtMusteriAdSatis.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriAdSatis.TabIndex = 14;
            // 
            // txtTelNoSatis
            // 
            this.txtTelNoSatis.BackColor = System.Drawing.Color.LightCoral;
            this.txtTelNoSatis.Location = new System.Drawing.Point(144, 239);
            this.txtTelNoSatis.Name = "txtTelNoSatis";
            this.txtTelNoSatis.Size = new System.Drawing.Size(100, 22);
            this.txtTelNoSatis.TabIndex = 13;
            // 
            // txtUrunKoduSatis
            // 
            this.txtUrunKoduSatis.BackColor = System.Drawing.Color.LightCoral;
            this.txtUrunKoduSatis.Location = new System.Drawing.Point(143, 35);
            this.txtUrunKoduSatis.Name = "txtUrunKoduSatis";
            this.txtUrunKoduSatis.Size = new System.Drawing.Size(100, 22);
            this.txtUrunKoduSatis.TabIndex = 10;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btnMusteriEkle.Location = new System.Drawing.Point(273, 297);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(123, 31);
            this.btnMusteriEkle.TabIndex = 9;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriGetir
            // 
            this.btnMusteriGetir.BackColor = System.Drawing.Color.LightGreen;
            this.btnMusteriGetir.Location = new System.Drawing.Point(273, 262);
            this.btnMusteriGetir.Name = "btnMusteriGetir";
            this.btnMusteriGetir.Size = new System.Drawing.Size(123, 29);
            this.btnMusteriGetir.TabIndex = 8;
            this.btnMusteriGetir.Text = "Müşteri Getir";
            this.btnMusteriGetir.UseVisualStyleBackColor = false;
            this.btnMusteriGetir.Click += new System.EventHandler(this.btnMusteriGetir_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(22, 245);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(93, 17);
            this.label29.TabIndex = 7;
            this.label29.Text = "Telefon No:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(22, 325);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 17);
            this.label28.TabIndex = 5;
            this.label28.Text = "Müşteri Soyadı:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(20, 285);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(94, 17);
            this.label27.TabIndex = 4;
            this.label27.Text = "Müşteri Adı:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(20, 113);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 17);
            this.label26.TabIndex = 3;
            this.label26.Text = "Açıklama:";
            // 
            // btnUrunGetir
            // 
            this.btnUrunGetir.BackColor = System.Drawing.Color.LightGreen;
            this.btnUrunGetir.Location = new System.Drawing.Point(272, 35);
            this.btnUrunGetir.Name = "btnUrunGetir";
            this.btnUrunGetir.Size = new System.Drawing.Size(123, 31);
            this.btnUrunGetir.TabIndex = 2;
            this.btnUrunGetir.Text = "Ürün Getir";
            this.btnUrunGetir.UseVisualStyleBackColor = false;
            this.btnUrunGetir.Click += new System.EventHandler(this.btnUrunGetir_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(22, 78);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 17);
            this.label25.TabIndex = 1;
            this.label25.Text = "Fiyatı(TL):";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 40);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 17);
            this.label24.TabIndex = 0;
            this.label24.Text = "Ürün Kodu:";
            // 
            // saleReturnDetailDtoBindingSource
            // 
            this.saleReturnDetailDtoBindingSource.DataSource = typeof(Entities.DTOs.SaleReturnDetailDto);
            // 
            // saleDetailDtoBindingSource
            // 
            this.saleDetailDtoBindingSource.DataSource = typeof(Entities.DTOs.SaleDetailDto);
            // 
            // productDetailDtoBindingSource1
            // 
            this.productDetailDtoBindingSource1.DataSource = typeof(Entities.DTOs.ProductDetailDto);
            // 
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataSource = typeof(Entities.Concrete.Supplier);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 694);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Computer Item Stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpUrunList.ResumeLayout(false);
            this.grpUrunList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailDtoBindingSource1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleReturnDetailDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailDtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTedarikciler;
        private System.Windows.Forms.TextBox txtStokSayisi;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStokSayisi;
        private System.Windows.Forms.Label lblTedarikci;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtMensei;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblMensei;
        private System.Windows.Forms.Label lblUrunCode;
        private System.Windows.Forms.TextBox txtUrunCode;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.GroupBox grpUrunList;
        private System.Windows.Forms.ComboBox cmbTedarikcilerListe;
        private System.Windows.Forms.TextBox txtStokSayisiListe;
        private System.Windows.Forms.TextBox txtBrandListe;
        private System.Windows.Forms.TextBox txtPriceListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrunAdiListe;
        private System.Windows.Forms.TextBox txtMenseiListe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUrunKoduListe;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource productDetailDtoBindingSource;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStokLimiti;
        private System.Windows.Forms.Button btnAzalanStok;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEndYear;
        private System.Windows.Forms.TextBox txtStartYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource productDetailDtoBindingSource1;
        private System.Windows.Forms.TextBox txtAlisFiyatiList;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnAmount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblHangiYillarArasinda;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtSaleAmount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtUrunCesidi;
        private System.Windows.Forms.TextBox txtReturnAmount;
        private System.Windows.Forms.TextBox txtTedarikciSayisi;
        private System.Windows.Forms.TextBox txtKarZarar;
        private System.Windows.Forms.Button btnBilgileriGetir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSatilanUrunLimiti;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.BindingSource saleDetailDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource saleDetailDtoBindingSource1;
        private System.Windows.Forms.CheckBox chkEnCokMu;
        private System.Windows.Forms.CheckBox chkEnAzMi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnUrunGetir;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtUrunKoduSatis;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriGetir;
        private System.Windows.Forms.Button btnIadeAl;
        private System.Windows.Forms.TextBox txtSatisIDIade;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.TextBox txtMusteriSoyadSatis;
        private System.Windows.Forms.TextBox txtMusteriAdSatis;
        private System.Windows.Forms.TextBox txtTelNoSatis;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnSatisGetir;
        private System.Windows.Forms.TextBox txtSatisTarihiIade;
        private System.Windows.Forms.TextBox txtUrunKoduIade;
        private System.Windows.Forms.TextBox txtTelNoIade;
        private System.Windows.Forms.BindingSource saleReturnDetailDtoBindingSource;
        private System.Windows.Forms.TextBox txtFiyatSatis;
        private System.Windows.Forms.RichTextBox rxtAciklamaSatis;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.RichTextBox txtAciklamaListe;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtTelNoFatura;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtSoyadFatura;
        private System.Windows.Forms.TextBox txtAdFatura;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtIadeTutariFatura;
        private System.Windows.Forms.TextBox txtSatisFiyatiFatura;
        private System.Windows.Forms.Label lblIadeTutariFatura;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtIadeTarihiFatura;
        private System.Windows.Forms.TextBox txtSatisTarihiFatura;
        private System.Windows.Forms.Label lblIadeTarihiFatura;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtSatisKoduFatura;
        private System.Windows.Forms.TextBox txtIadeKoduFatura;
        private System.Windows.Forms.Label lblIadeKoduFatura;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.RichTextBox rxtAciklamaFatura;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtUrunKoduFatura;
    }
}

