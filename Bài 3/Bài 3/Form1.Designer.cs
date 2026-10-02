using static System.Net.Mime.MediaTypeNames;

namespace Bài_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportCsvToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblInput;
        private TableLayoutPanel tblRight;

        private Label lblProductId;
        private Label lblProductName;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblCategory;
        private Label lblAvatar;
        private Label lblSearch;

        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtSearch;

        private ComboBox cboCategory;

        private PictureBox picAvatar;
        private Button btnChooseImage;

        private FlowLayoutPanel pnlButtons;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private ErrorProvider errorProvider1;

        private DataGridView dgvProducts;

        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colQuantity;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportCsvToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();

            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();

            tblMain = new TableLayoutPanel();
            tblInput = new TableLayoutPanel();
            tblRight = new TableLayoutPanel();

            lblProductId = new Label();
            lblProductName = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            lblCategory = new Label();
            lblAvatar = new Label();
            lblSearch = new Label();

            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            txtSearch = new TextBox();

            cboCategory = new ComboBox();

            picAvatar = new PictureBox();
            btnChooseImage = new Button();

            pnlButtons = new FlowLayoutPanel();

            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            errorProvider1 = new ErrorProvider(components);

            dgvProducts = new DataGridView();

            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();

            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();

            tblMain.SuspendLayout();
            tblInput.SuspendLayout();
            tblRight.SuspendLayout();

            pnlButtons.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();

            SuspendLayout();

            // =====================================================
            // MENU
            // =====================================================

            menuStrip1.Items.AddRange(
                new ToolStripItem[]
                {
                    fileToolStripMenuItem
                });

            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1200, 24);

            fileToolStripMenuItem.Text = "File";

            fileToolStripMenuItem.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    exportCsvToolStripMenuItem,
                    exitToolStripMenuItem
                });

            exportCsvToolStripMenuItem.Text = "Export CSV";

            exportCsvToolStripMenuItem.ShortcutKeys =
                Keys.Control | Keys.E;

            exportCsvToolStripMenuItem.Click +=
                exportCsvToolStripMenuItem_Click;

            exitToolStripMenuItem.Text = "Exit";

            exitToolStripMenuItem.ShortcutKeys =
                Keys.Control | Keys.X;

            exitToolStripMenuItem.Click +=
                exitToolStripMenuItem_Click;

            // =====================================================
            // STATUS
            // =====================================================

            statusStrip1.Items.AddRange(
                new ToolStripItem[]
                {
                    lblStatus
                });

            statusStrip1.Dock = DockStyle.Bottom;

            lblStatus.Text =
                "Tổng số sản phẩm: 0";

            // =====================================================
            // MAIN TABLE
            // =====================================================

            tblMain.ColumnCount = 2;

            tblMain.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    35F));

            tblMain.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    65F));

            tblMain.RowCount = 1;

            tblMain.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F));

            tblMain.Dock = DockStyle.Fill;

            tblMain.Padding = new Padding(8);

            // =====================================================
            // INPUT TABLE
            // =====================================================

            tblInput.ColumnCount = 2;

            tblInput.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    32F));

            tblInput.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    68F));

            tblInput.RowCount = 8;

            tblInput.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    42F));

            tblInput.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    42F));

            tblInput.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    42F));

            tblInput.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    42F));

            tblInput.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    42F));

            // HÀNG ẢNH - TỰ CO GIÃN

            tblInput.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F));

            tblInput.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    42F));

            tblInput.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    55F));

            tblInput.Dock = DockStyle.Fill;

            // =====================================================
            // LABEL
            // =====================================================

            lblProductId.Text = "Mã SP";
            lblProductId.Anchor = AnchorStyles.Left;

            lblProductName.Text = "Tên SP";
            lblProductName.Anchor = AnchorStyles.Left;

            lblUnitPrice.Text = "Đơn giá";
            lblUnitPrice.Anchor = AnchorStyles.Left;

            lblQuantity.Text = "Số lượng";
            lblQuantity.Anchor = AnchorStyles.Left;

            lblCategory.Text = "Danh mục";
            lblCategory.Anchor = AnchorStyles.Left;

            lblAvatar.Text = "Ảnh SP";
            lblAvatar.Anchor = AnchorStyles.Left;

            // =====================================================
            // TEXTBOX
            // =====================================================

            txtProductId.Dock = DockStyle.Fill;

            txtProductName.Dock = DockStyle.Fill;

            txtUnitPrice.Dock = DockStyle.Fill;

            txtQuantity.Dock = DockStyle.Fill;

            // =====================================================
            // COMBOBOX
            // =====================================================

            cboCategory.Dock = DockStyle.Fill;

            cboCategory.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // =====================================================
            // PICTUREBOX
            // =====================================================

            picAvatar.Dock = DockStyle.Fill;

            picAvatar.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            picAvatar.SizeMode =
                PictureBoxSizeMode.Zoom;

            picAvatar.BorderStyle =
                BorderStyle.FixedSingle;

            picAvatar.BackColor =
                Color.White;

            // =====================================================
            // CHOOSE IMAGE
            // =====================================================

            btnChooseImage.Text =
                "Chọn ảnh";

            btnChooseImage.Dock =
                DockStyle.Fill;

            btnChooseImage.Click +=
                btnChooseImage_Click;

            // =====================================================
            // BUTTON PANEL
            // =====================================================

            pnlButtons.Dock =
                DockStyle.Fill;

            pnlButtons.FlowDirection =
                FlowDirection.LeftToRight;

            pnlButtons.WrapContents =
                false;

            btnAdd.Text =
                "Thêm mới";

            btnAdd.Width = 80;
            btnAdd.Height = 34;

            btnAdd.Click +=
                btnAdd_Click;

            btnUpdate.Text =
                "Cập nhật";

            btnUpdate.Width = 80;
            btnUpdate.Height = 34;

            btnUpdate.Click +=
                btnUpdate_Click;

            btnDelete.Text =
                "Xóa";

            btnDelete.Width = 70;
            btnDelete.Height = 34;

            btnDelete.Click +=
                btnDelete_Click;

            btnClear.Text =
                "Làm mới";

            btnClear.Width = 80;
            btnClear.Height = 34;

            btnClear.Click +=
                btnClear_Click;

            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnClear);

            // =====================================================
            // INPUT LAYOUT
            // =====================================================

            tblInput.Controls.Add(
                lblProductId, 0, 0);

            tblInput.Controls.Add(
                txtProductId, 1, 0);

            tblInput.Controls.Add(
                lblProductName, 0, 1);

            tblInput.Controls.Add(
                txtProductName, 1, 1);

            tblInput.Controls.Add(
                lblUnitPrice, 0, 2);

            tblInput.Controls.Add(
                txtUnitPrice, 1, 2);

            tblInput.Controls.Add(
                lblQuantity, 0, 3);

            tblInput.Controls.Add(
                txtQuantity, 1, 3);

            tblInput.Controls.Add(
                lblCategory, 0, 4);

            tblInput.Controls.Add(
                cboCategory, 1, 4);

            tblInput.Controls.Add(
                lblAvatar, 0, 5);

            tblInput.Controls.Add(
                picAvatar, 1, 5);

            tblInput.Controls.Add(
                btnChooseImage, 1, 6);

            tblInput.Controls.Add(
                pnlButtons, 0, 7);

            tblInput.SetColumnSpan(
                pnlButtons, 2);

            // =====================================================
            // RIGHT TABLE
            // =====================================================

            tblRight.ColumnCount = 2;

            tblRight.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Absolute,
                    80F));

            tblRight.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    100F));

            tblRight.RowCount = 2;

            tblRight.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    42F));

            tblRight.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F));

            tblRight.Dock =
                DockStyle.Fill;

            // =====================================================
            // SEARCH
            // =====================================================

            lblSearch.Text =
                "Tìm kiếm:";

            lblSearch.Anchor =
                AnchorStyles.Left;

            txtSearch.Dock =
                DockStyle.Fill;

            txtSearch.TextChanged +=
                txtSearch_TextChanged;

            // =====================================================
            // DATAGRIDVIEW
            // =====================================================

            dgvProducts.Dock =
                DockStyle.Fill;

            dgvProducts.AutoGenerateColumns =
                false;

            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.MultiSelect =
                false;

            dgvProducts.ReadOnly =
                true;

            dgvProducts.AllowUserToAddRows =
                false;

            dgvProducts.AllowUserToDeleteRows =
                false;

            dgvProducts.RowHeadersVisible =
                false;

            dgvProducts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.CellClick +=
                dgvProducts_CellClick;

            // =====================================================
            // GRID COLUMNS
            // =====================================================

            colProductId.DataPropertyName =
                "ProductId";

            colProductId.HeaderText =
                "Mã SP";

            colProductName.DataPropertyName =
                "ProductName";

            colProductName.HeaderText =
                "Tên SP";

            colCategory.DataPropertyName =
                "CategoryName";

            colCategory.HeaderText =
                "Danh Mục";

            colUnitPrice.DataPropertyName =
                "UnitPrice";

            colUnitPrice.HeaderText =
                "Đơn Giá";

            colUnitPrice.DefaultCellStyle.Format =
                "N0";

            colQuantity.DataPropertyName =
                "Quantity";

            colQuantity.HeaderText =
                "Số Lượng";

            dgvProducts.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    colProductId,
                    colProductName,
                    colCategory,
                    colUnitPrice,
                    colQuantity
                });

            // =====================================================
            // RIGHT LAYOUT
            // =====================================================

            tblRight.Controls.Add(
                lblSearch, 0, 0);

            tblRight.Controls.Add(
                txtSearch, 1, 0);

            tblRight.Controls.Add(
                dgvProducts, 0, 1);

            tblRight.SetColumnSpan(
                dgvProducts, 2);

            // =====================================================
            // MAIN LAYOUT
            // =====================================================

            tblMain.Controls.Add(
                tblInput, 0, 0);

            tblMain.Controls.Add(
                tblRight, 1, 0);

            // =====================================================
            // FORM
            // =====================================================

            AutoScaleDimensions =
                new SizeF(7F, 15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(1200, 700);

            MinimumSize =
                new Size(900, 550);

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Bài 3 - TechMart Product Manager";

            MainMenuStrip =
                menuStrip1;

            Controls.Add(tblMain);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);

            Load +=
                Form1_Load;

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();

            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();

            tblMain.ResumeLayout(false);
            tblInput.ResumeLayout(false);
            tblRight.ResumeLayout(false);

            pnlButtons.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                picAvatar).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                errorProvider1).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                dgvProducts).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}