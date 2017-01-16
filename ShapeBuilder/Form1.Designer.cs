namespace ShapeBuilder
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelParam = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxLightSource = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelLightSource = new System.Windows.Forms.TableLayoutPanel();
            this.labelMaxZLight = new System.Windows.Forms.Label();
            this.labelMinZLight = new System.Windows.Forms.Label();
            this.labelValZLight = new System.Windows.Forms.Label();
            this.labelZLight = new System.Windows.Forms.Label();
            this.labelMaxYLight = new System.Windows.Forms.Label();
            this.labelMinYLight = new System.Windows.Forms.Label();
            this.labelValYLight = new System.Windows.Forms.Label();
            this.labelYLight = new System.Windows.Forms.Label();
            this.labelMaxXLight = new System.Windows.Forms.Label();
            this.labelMinXLight = new System.Windows.Forms.Label();
            this.labelValXLight = new System.Windows.Forms.Label();
            this.labelXLight = new System.Windows.Forms.Label();
            this.trackBarXLight = new System.Windows.Forms.TrackBar();
            this.trackBarYLight = new System.Windows.Forms.TrackBar();
            this.trackBarZLight = new System.Windows.Forms.TrackBar();
            this.groupBoxShape = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelShape = new System.Windows.Forms.TableLayoutPanel();
            this.labelU = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelDU = new System.Windows.Forms.Label();
            this.labelDV = new System.Windows.Forms.Label();
            this.labelValU = new System.Windows.Forms.Label();
            this.labelValV = new System.Windows.Forms.Label();
            this.labelValA = new System.Windows.Forms.Label();
            this.labelValDU = new System.Windows.Forms.Label();
            this.labelValDV = new System.Windows.Forms.Label();
            this.labelMinU = new System.Windows.Forms.Label();
            this.labelMinV = new System.Windows.Forms.Label();
            this.labelMinA = new System.Windows.Forms.Label();
            this.labelMinDU = new System.Windows.Forms.Label();
            this.labelMinDV = new System.Windows.Forms.Label();
            this.labelMaxU = new System.Windows.Forms.Label();
            this.labelMaxV = new System.Windows.Forms.Label();
            this.labelMaxA = new System.Windows.Forms.Label();
            this.labelMaxDU = new System.Windows.Forms.Label();
            this.labelMaxDV = new System.Windows.Forms.Label();
            this.trackBarU = new System.Windows.Forms.TrackBar();
            this.trackBarV = new System.Windows.Forms.TrackBar();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarDU = new System.Windows.Forms.TrackBar();
            this.trackBarDV = new System.Windows.Forms.TrackBar();
            this.groupBoxRotate = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelRotate = new System.Windows.Forms.TableLayoutPanel();
            this.labelMaxZ = new System.Windows.Forms.Label();
            this.labelMinZ = new System.Windows.Forms.Label();
            this.labelValZ = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelMaxY = new System.Windows.Forms.Label();
            this.labelMinY = new System.Windows.Forms.Label();
            this.labelValY = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelMaxX = new System.Windows.Forms.Label();
            this.labelMinX = new System.Windows.Forms.Label();
            this.labelValX = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.groupBoxLightParam = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelLightParam = new System.Windows.Forms.TableLayoutPanel();
            this.labelMaxPower = new System.Windows.Forms.Label();
            this.labelMaxSpecularLight = new System.Windows.Forms.Label();
            this.labelMaxDiffuseLight = new System.Windows.Forms.Label();
            this.labelMaxAmbientLight = new System.Windows.Forms.Label();
            this.labelMinDiffuseLight = new System.Windows.Forms.Label();
            this.labelMinSpecularLight = new System.Windows.Forms.Label();
            this.labelValPower = new System.Windows.Forms.Label();
            this.labelMinPower = new System.Windows.Forms.Label();
            this.labelMinAmbientLight = new System.Windows.Forms.Label();
            this.labelValSpecularLight = new System.Windows.Forms.Label();
            this.labelValDiffuseLight = new System.Windows.Forms.Label();
            this.labelValAmbientLight = new System.Windows.Forms.Label();
            this.labelPower = new System.Windows.Forms.Label();
            this.labelSpecularLight = new System.Windows.Forms.Label();
            this.labelDiffuseLight = new System.Windows.Forms.Label();
            this.labelAmbientLight = new System.Windows.Forms.Label();
            this.trackBarAmbientLight = new System.Windows.Forms.TrackBar();
            this.trackBarDiffuseLight = new System.Windows.Forms.TrackBar();
            this.trackBarSpecularLight = new System.Windows.Forms.TrackBar();
            this.trackBarPower = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanelDraw = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelFill = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxFillMethod = new System.Windows.Forms.GroupBox();
            this.radioButtonGouraudShading = new System.Windows.Forms.RadioButton();
            this.radioButtonPhongShading = new System.Windows.Forms.RadioButton();
            this.radioButtonFlatHLSRFrame = new System.Windows.Forms.RadioButton();
            this.checkBoxPolyZSort = new System.Windows.Forms.CheckBox();
            this.radioButtonFlatFrame = new System.Windows.Forms.RadioButton();
            this.radioButtonWireframe = new System.Windows.Forms.RadioButton();
            this.groupBoxFillColor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelFillColor = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFillColorInternal = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxIntern = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelFillColorInternalParam = new System.Windows.Forms.TableLayoutPanel();
            this.labelValB2 = new System.Windows.Forms.Label();
            this.labelB2 = new System.Windows.Forms.Label();
            this.trackBarR1 = new System.Windows.Forms.TrackBar();
            this.trackBarG1 = new System.Windows.Forms.TrackBar();
            this.trackBarB1 = new System.Windows.Forms.TrackBar();
            this.labelR2 = new System.Windows.Forms.Label();
            this.labelValR2 = new System.Windows.Forms.Label();
            this.labelMaxR2 = new System.Windows.Forms.Label();
            this.labelG2 = new System.Windows.Forms.Label();
            this.labelValG2 = new System.Windows.Forms.Label();
            this.labelMaxG2 = new System.Windows.Forms.Label();
            this.labelMaxB2 = new System.Windows.Forms.Label();
            this.labelInternal = new System.Windows.Forms.Label();
            this.tableLayoutPanelFillColorExternal = new System.Windows.Forms.TableLayoutPanel();
            this.labelExternal = new System.Windows.Forms.Label();
            this.pictureBoxExtern = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelFillColorExternalParam = new System.Windows.Forms.TableLayoutPanel();
            this.labelMaxB1 = new System.Windows.Forms.Label();
            this.labelValB1 = new System.Windows.Forms.Label();
            this.labelB1 = new System.Windows.Forms.Label();
            this.labelMaxG1 = new System.Windows.Forms.Label();
            this.labelValG1 = new System.Windows.Forms.Label();
            this.labelG1 = new System.Windows.Forms.Label();
            this.labelMaxR1 = new System.Windows.Forms.Label();
            this.labelValR1 = new System.Windows.Forms.Label();
            this.trackBarR2 = new System.Windows.Forms.TrackBar();
            this.trackBarG2 = new System.Windows.Forms.TrackBar();
            this.trackBarB2 = new System.Windows.Forms.TrackBar();
            this.labelR1 = new System.Windows.Forms.Label();
            this.groupBoxLightColor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelLightColor = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelDirect = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelDirectParam = new System.Windows.Forms.TableLayoutPanel();
            this.labelMaxB3 = new System.Windows.Forms.Label();
            this.labelValB3 = new System.Windows.Forms.Label();
            this.labelB3 = new System.Windows.Forms.Label();
            this.labelMaxG3 = new System.Windows.Forms.Label();
            this.labelValG3 = new System.Windows.Forms.Label();
            this.labelG3 = new System.Windows.Forms.Label();
            this.labelMaxR3 = new System.Windows.Forms.Label();
            this.labelValR3 = new System.Windows.Forms.Label();
            this.labelR3 = new System.Windows.Forms.Label();
            this.trackBarR3 = new System.Windows.Forms.TrackBar();
            this.trackBarG3 = new System.Windows.Forms.TrackBar();
            this.trackBarB3 = new System.Windows.Forms.TrackBar();
            this.labelDirect = new System.Windows.Forms.Label();
            this.pictureBoxDirect = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelAmbient = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxAmbient = new System.Windows.Forms.PictureBox();
            this.labelAmbient = new System.Windows.Forms.Label();
            this.tableLayoutPanelAmbientParam = new System.Windows.Forms.TableLayoutPanel();
            this.labelMaxB4 = new System.Windows.Forms.Label();
            this.labelValB4 = new System.Windows.Forms.Label();
            this.labelB4 = new System.Windows.Forms.Label();
            this.labelMaxG4 = new System.Windows.Forms.Label();
            this.labelValG4 = new System.Windows.Forms.Label();
            this.labelG4 = new System.Windows.Forms.Label();
            this.labelMaxR4 = new System.Windows.Forms.Label();
            this.labelValR4 = new System.Windows.Forms.Label();
            this.labelR4 = new System.Windows.Forms.Label();
            this.trackBarR4 = new System.Windows.Forms.TrackBar();
            this.trackBarG4 = new System.Windows.Forms.TrackBar();
            this.trackBarB4 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelParam.SuspendLayout();
            this.groupBoxLightSource.SuspendLayout();
            this.tableLayoutPanelLightSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZLight)).BeginInit();
            this.groupBoxShape.SuspendLayout();
            this.tableLayoutPanelShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDV)).BeginInit();
            this.groupBoxRotate.SuspendLayout();
            this.tableLayoutPanelRotate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            this.groupBoxLightParam.SuspendLayout();
            this.tableLayoutPanelLightParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbientLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDiffuseLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpecularLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPower)).BeginInit();
            this.tableLayoutPanelDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).BeginInit();
            this.tableLayoutPanelFill.SuspendLayout();
            this.groupBoxFillMethod.SuspendLayout();
            this.groupBoxFillColor.SuspendLayout();
            this.tableLayoutPanelFillColor.SuspendLayout();
            this.tableLayoutPanelFillColorInternal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIntern)).BeginInit();
            this.tableLayoutPanelFillColorInternalParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB1)).BeginInit();
            this.tableLayoutPanelFillColorExternal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtern)).BeginInit();
            this.tableLayoutPanelFillColorExternalParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB2)).BeginInit();
            this.groupBoxLightColor.SuspendLayout();
            this.tableLayoutPanelLightColor.SuspendLayout();
            this.tableLayoutPanelDirect.SuspendLayout();
            this.tableLayoutPanelDirectParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDirect)).BeginInit();
            this.tableLayoutPanelAmbient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmbient)).BeginInit();
            this.tableLayoutPanelAmbientParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelParam, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelDraw, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.04348F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.95652F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(944, 622);
            this.tableLayoutPanelMain.TabIndex = 3;
            // 
            // tableLayoutPanelParam
            // 
            this.tableLayoutPanelParam.ColumnCount = 3;
            this.tableLayoutPanelParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelParam.Controls.Add(this.groupBoxLightSource, 0, 1);
            this.tableLayoutPanelParam.Controls.Add(this.groupBoxShape, 1, 0);
            this.tableLayoutPanelParam.Controls.Add(this.groupBoxRotate, 0, 0);
            this.tableLayoutPanelParam.Controls.Add(this.groupBoxLightParam, 2, 0);
            this.tableLayoutPanelParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelParam.Location = new System.Drawing.Point(3, 395);
            this.tableLayoutPanelParam.Name = "tableLayoutPanelParam";
            this.tableLayoutPanelParam.RowCount = 2;
            this.tableLayoutPanelParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelParam.Size = new System.Drawing.Size(938, 224);
            this.tableLayoutPanelParam.TabIndex = 3;
            // 
            // groupBoxLightSource
            // 
            this.groupBoxLightSource.Controls.Add(this.tableLayoutPanelLightSource);
            this.groupBoxLightSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLightSource.Location = new System.Drawing.Point(3, 115);
            this.groupBoxLightSource.Name = "groupBoxLightSource";
            this.groupBoxLightSource.Size = new System.Drawing.Size(306, 106);
            this.groupBoxLightSource.TabIndex = 3;
            this.groupBoxLightSource.TabStop = false;
            this.groupBoxLightSource.Text = "Координаты источника света";
            // 
            // tableLayoutPanelLightSource
            // 
            this.tableLayoutPanelLightSource.ColumnCount = 5;
            this.tableLayoutPanelLightSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLightSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLightSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLightSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLightSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLightSource.Controls.Add(this.labelMaxZLight, 4, 2);
            this.tableLayoutPanelLightSource.Controls.Add(this.labelMinZLight, 2, 2);
            this.tableLayoutPanelLightSource.Controls.Add(this.labelValZLight, 1, 2);
            this.tableLayoutPanelLightSource.Controls.Add(this.labelZLight, 0, 2);
            this.tableLayoutPanelLightSource.Controls.Add(this.labelMaxYLight, 4, 1);
            this.tableLayoutPanelLightSource.Controls.Add(this.labelMinYLight, 2, 1);
            this.tableLayoutPanelLightSource.Controls.Add(this.labelValYLight, 1, 1);
            this.tableLayoutPanelLightSource.Controls.Add(this.labelYLight, 0, 1);
            this.tableLayoutPanelLightSource.Controls.Add(this.labelMaxXLight, 4, 0);
            this.tableLayoutPanelLightSource.Controls.Add(this.labelMinXLight, 2, 0);
            this.tableLayoutPanelLightSource.Controls.Add(this.labelValXLight, 1, 0);
            this.tableLayoutPanelLightSource.Controls.Add(this.labelXLight, 0, 0);
            this.tableLayoutPanelLightSource.Controls.Add(this.trackBarXLight, 3, 0);
            this.tableLayoutPanelLightSource.Controls.Add(this.trackBarYLight, 3, 1);
            this.tableLayoutPanelLightSource.Controls.Add(this.trackBarZLight, 3, 2);
            this.tableLayoutPanelLightSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLightSource.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelLightSource.Name = "tableLayoutPanelLightSource";
            this.tableLayoutPanelLightSource.RowCount = 3;
            this.tableLayoutPanelLightSource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLightSource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLightSource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLightSource.Size = new System.Drawing.Size(300, 87);
            this.tableLayoutPanelLightSource.TabIndex = 0;
            // 
            // labelMaxZLight
            // 
            this.labelMaxZLight.AutoSize = true;
            this.labelMaxZLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxZLight.Location = new System.Drawing.Point(278, 58);
            this.labelMaxZLight.Name = "labelMaxZLight";
            this.labelMaxZLight.Size = new System.Drawing.Size(19, 29);
            this.labelMaxZLight.TabIndex = 22;
            this.labelMaxZLight.Text = "[v]";
            this.labelMaxZLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinZLight
            // 
            this.labelMinZLight.AutoSize = true;
            this.labelMinZLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinZLight.Location = new System.Drawing.Point(66, 58);
            this.labelMinZLight.Name = "labelMinZLight";
            this.labelMinZLight.Size = new System.Drawing.Size(19, 29);
            this.labelMinZLight.TabIndex = 21;
            this.labelMinZLight.Text = "[v]";
            this.labelMinZLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValZLight
            // 
            this.labelValZLight.AutoSize = true;
            this.labelValZLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValZLight.Location = new System.Drawing.Point(26, 58);
            this.labelValZLight.Name = "labelValZLight";
            this.labelValZLight.Size = new System.Drawing.Size(34, 29);
            this.labelValZLight.TabIndex = 20;
            this.labelValZLight.Text = "[v]";
            this.labelValZLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZLight
            // 
            this.labelZLight.AutoSize = true;
            this.labelZLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelZLight.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZLight.Location = new System.Drawing.Point(3, 58);
            this.labelZLight.Name = "labelZLight";
            this.labelZLight.Size = new System.Drawing.Size(17, 29);
            this.labelZLight.TabIndex = 19;
            this.labelZLight.Text = "Z";
            this.labelZLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxYLight
            // 
            this.labelMaxYLight.AutoSize = true;
            this.labelMaxYLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxYLight.Location = new System.Drawing.Point(278, 29);
            this.labelMaxYLight.Name = "labelMaxYLight";
            this.labelMaxYLight.Size = new System.Drawing.Size(19, 29);
            this.labelMaxYLight.TabIndex = 18;
            this.labelMaxYLight.Text = "[v]";
            this.labelMaxYLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinYLight
            // 
            this.labelMinYLight.AutoSize = true;
            this.labelMinYLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinYLight.Location = new System.Drawing.Point(66, 29);
            this.labelMinYLight.Name = "labelMinYLight";
            this.labelMinYLight.Size = new System.Drawing.Size(19, 29);
            this.labelMinYLight.TabIndex = 17;
            this.labelMinYLight.Text = "[v]";
            this.labelMinYLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValYLight
            // 
            this.labelValYLight.AutoSize = true;
            this.labelValYLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValYLight.Location = new System.Drawing.Point(26, 29);
            this.labelValYLight.Name = "labelValYLight";
            this.labelValYLight.Size = new System.Drawing.Size(34, 29);
            this.labelValYLight.TabIndex = 16;
            this.labelValYLight.Text = "[v]";
            this.labelValYLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYLight
            // 
            this.labelYLight.AutoSize = true;
            this.labelYLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelYLight.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYLight.Location = new System.Drawing.Point(3, 29);
            this.labelYLight.Name = "labelYLight";
            this.labelYLight.Size = new System.Drawing.Size(17, 29);
            this.labelYLight.TabIndex = 15;
            this.labelYLight.Text = "Y";
            this.labelYLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxXLight
            // 
            this.labelMaxXLight.AutoSize = true;
            this.labelMaxXLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxXLight.Location = new System.Drawing.Point(278, 0);
            this.labelMaxXLight.Name = "labelMaxXLight";
            this.labelMaxXLight.Size = new System.Drawing.Size(19, 29);
            this.labelMaxXLight.TabIndex = 14;
            this.labelMaxXLight.Text = "[v]";
            this.labelMaxXLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinXLight
            // 
            this.labelMinXLight.AutoSize = true;
            this.labelMinXLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinXLight.Location = new System.Drawing.Point(66, 0);
            this.labelMinXLight.Name = "labelMinXLight";
            this.labelMinXLight.Size = new System.Drawing.Size(19, 29);
            this.labelMinXLight.TabIndex = 13;
            this.labelMinXLight.Text = "[v]";
            this.labelMinXLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValXLight
            // 
            this.labelValXLight.AutoSize = true;
            this.labelValXLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValXLight.Location = new System.Drawing.Point(26, 0);
            this.labelValXLight.Name = "labelValXLight";
            this.labelValXLight.Size = new System.Drawing.Size(34, 29);
            this.labelValXLight.TabIndex = 12;
            this.labelValXLight.Text = "[v]";
            this.labelValXLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelXLight
            // 
            this.labelXLight.AutoSize = true;
            this.labelXLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelXLight.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXLight.Location = new System.Drawing.Point(3, 0);
            this.labelXLight.Name = "labelXLight";
            this.labelXLight.Size = new System.Drawing.Size(17, 29);
            this.labelXLight.TabIndex = 11;
            this.labelXLight.Text = "X";
            this.labelXLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarXLight
            // 
            this.trackBarXLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarXLight.Location = new System.Drawing.Point(91, 3);
            this.trackBarXLight.Maximum = 360;
            this.trackBarXLight.Minimum = -360;
            this.trackBarXLight.Name = "trackBarXLight";
            this.trackBarXLight.Size = new System.Drawing.Size(181, 23);
            this.trackBarXLight.TabIndex = 0;
            this.trackBarXLight.Scroll += new System.EventHandler(this.onLightSourceChanged);
            // 
            // trackBarYLight
            // 
            this.trackBarYLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarYLight.Location = new System.Drawing.Point(91, 32);
            this.trackBarYLight.Maximum = 360;
            this.trackBarYLight.Minimum = -360;
            this.trackBarYLight.Name = "trackBarYLight";
            this.trackBarYLight.Size = new System.Drawing.Size(181, 23);
            this.trackBarYLight.TabIndex = 1;
            this.trackBarYLight.Scroll += new System.EventHandler(this.onLightSourceChanged);
            // 
            // trackBarZLight
            // 
            this.trackBarZLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarZLight.Location = new System.Drawing.Point(91, 61);
            this.trackBarZLight.Maximum = 360;
            this.trackBarZLight.Minimum = -360;
            this.trackBarZLight.Name = "trackBarZLight";
            this.trackBarZLight.Size = new System.Drawing.Size(181, 23);
            this.trackBarZLight.TabIndex = 2;
            this.trackBarZLight.Value = 50;
            this.trackBarZLight.Scroll += new System.EventHandler(this.onLightSourceChanged);
            // 
            // groupBoxShape
            // 
            this.groupBoxShape.Controls.Add(this.tableLayoutPanelShape);
            this.groupBoxShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxShape.Location = new System.Drawing.Point(315, 3);
            this.groupBoxShape.Name = "groupBoxShape";
            this.tableLayoutPanelParam.SetRowSpan(this.groupBoxShape, 2);
            this.groupBoxShape.Size = new System.Drawing.Size(306, 218);
            this.groupBoxShape.TabIndex = 0;
            this.groupBoxShape.TabStop = false;
            this.groupBoxShape.Text = "Параметры поверхности";
            // 
            // tableLayoutPanelShape
            // 
            this.tableLayoutPanelShape.ColumnCount = 5;
            this.tableLayoutPanelShape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelShape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelShape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelShape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelShape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelShape.Controls.Add(this.labelU, 0, 0);
            this.tableLayoutPanelShape.Controls.Add(this.labelV, 0, 1);
            this.tableLayoutPanelShape.Controls.Add(this.labelA, 0, 2);
            this.tableLayoutPanelShape.Controls.Add(this.labelDU, 0, 3);
            this.tableLayoutPanelShape.Controls.Add(this.labelDV, 0, 4);
            this.tableLayoutPanelShape.Controls.Add(this.labelValU, 1, 0);
            this.tableLayoutPanelShape.Controls.Add(this.labelValV, 1, 1);
            this.tableLayoutPanelShape.Controls.Add(this.labelValA, 1, 2);
            this.tableLayoutPanelShape.Controls.Add(this.labelValDU, 1, 3);
            this.tableLayoutPanelShape.Controls.Add(this.labelValDV, 1, 4);
            this.tableLayoutPanelShape.Controls.Add(this.labelMinU, 2, 0);
            this.tableLayoutPanelShape.Controls.Add(this.labelMinV, 2, 1);
            this.tableLayoutPanelShape.Controls.Add(this.labelMinA, 2, 2);
            this.tableLayoutPanelShape.Controls.Add(this.labelMinDU, 2, 3);
            this.tableLayoutPanelShape.Controls.Add(this.labelMinDV, 2, 4);
            this.tableLayoutPanelShape.Controls.Add(this.labelMaxU, 4, 0);
            this.tableLayoutPanelShape.Controls.Add(this.labelMaxV, 4, 1);
            this.tableLayoutPanelShape.Controls.Add(this.labelMaxA, 4, 2);
            this.tableLayoutPanelShape.Controls.Add(this.labelMaxDU, 4, 3);
            this.tableLayoutPanelShape.Controls.Add(this.labelMaxDV, 4, 4);
            this.tableLayoutPanelShape.Controls.Add(this.trackBarU, 3, 0);
            this.tableLayoutPanelShape.Controls.Add(this.trackBarV, 3, 1);
            this.tableLayoutPanelShape.Controls.Add(this.trackBarA, 3, 2);
            this.tableLayoutPanelShape.Controls.Add(this.trackBarDU, 3, 3);
            this.tableLayoutPanelShape.Controls.Add(this.trackBarDV, 3, 4);
            this.tableLayoutPanelShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelShape.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelShape.Name = "tableLayoutPanelShape";
            this.tableLayoutPanelShape.RowCount = 5;
            this.tableLayoutPanelShape.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelShape.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelShape.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelShape.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelShape.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelShape.Size = new System.Drawing.Size(300, 199);
            this.tableLayoutPanelShape.TabIndex = 1;
            // 
            // labelU
            // 
            this.labelU.AutoSize = true;
            this.labelU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelU.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelU.Location = new System.Drawing.Point(3, 0);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(25, 39);
            this.labelU.TabIndex = 0;
            this.labelU.Text = "U";
            this.labelU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelV.Location = new System.Drawing.Point(3, 39);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(25, 39);
            this.labelV.TabIndex = 1;
            this.labelV.Text = "V";
            this.labelV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(3, 78);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(25, 39);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "a";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDU
            // 
            this.labelDU.AutoSize = true;
            this.labelDU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDU.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDU.Location = new System.Drawing.Point(3, 117);
            this.labelDU.Name = "labelDU";
            this.labelDU.Size = new System.Drawing.Size(25, 39);
            this.labelDU.TabIndex = 3;
            this.labelDU.Text = "dU";
            this.labelDU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDV
            // 
            this.labelDV.AutoSize = true;
            this.labelDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDV.Location = new System.Drawing.Point(3, 156);
            this.labelDV.Name = "labelDV";
            this.labelDV.Size = new System.Drawing.Size(25, 43);
            this.labelDV.TabIndex = 4;
            this.labelDV.Text = "dV";
            this.labelDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValU
            // 
            this.labelValU.AutoSize = true;
            this.labelValU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValU.Location = new System.Drawing.Point(34, 0);
            this.labelValU.Name = "labelValU";
            this.labelValU.Size = new System.Drawing.Size(34, 39);
            this.labelValU.TabIndex = 5;
            this.labelValU.Text = "[v]";
            this.labelValU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValV
            // 
            this.labelValV.AutoSize = true;
            this.labelValV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValV.Location = new System.Drawing.Point(34, 39);
            this.labelValV.Name = "labelValV";
            this.labelValV.Size = new System.Drawing.Size(34, 39);
            this.labelValV.TabIndex = 6;
            this.labelValV.Text = "[v]";
            this.labelValV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValA
            // 
            this.labelValA.AutoSize = true;
            this.labelValA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValA.Location = new System.Drawing.Point(34, 78);
            this.labelValA.Name = "labelValA";
            this.labelValA.Size = new System.Drawing.Size(34, 39);
            this.labelValA.TabIndex = 7;
            this.labelValA.Text = "[v]";
            this.labelValA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValDU
            // 
            this.labelValDU.AutoSize = true;
            this.labelValDU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValDU.Location = new System.Drawing.Point(34, 117);
            this.labelValDU.Name = "labelValDU";
            this.labelValDU.Size = new System.Drawing.Size(34, 39);
            this.labelValDU.TabIndex = 8;
            this.labelValDU.Text = "[v]";
            this.labelValDU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValDV
            // 
            this.labelValDV.AutoSize = true;
            this.labelValDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValDV.Location = new System.Drawing.Point(34, 156);
            this.labelValDV.Name = "labelValDV";
            this.labelValDV.Size = new System.Drawing.Size(34, 43);
            this.labelValDV.TabIndex = 9;
            this.labelValDV.Text = "[v]";
            this.labelValDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinU
            // 
            this.labelMinU.AutoSize = true;
            this.labelMinU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinU.Location = new System.Drawing.Point(74, 0);
            this.labelMinU.Name = "labelMinU";
            this.labelMinU.Size = new System.Drawing.Size(19, 39);
            this.labelMinU.TabIndex = 10;
            this.labelMinU.Text = "[v]";
            this.labelMinU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinV
            // 
            this.labelMinV.AutoSize = true;
            this.labelMinV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinV.Location = new System.Drawing.Point(74, 39);
            this.labelMinV.Name = "labelMinV";
            this.labelMinV.Size = new System.Drawing.Size(19, 39);
            this.labelMinV.TabIndex = 11;
            this.labelMinV.Text = "[v]";
            this.labelMinV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinA
            // 
            this.labelMinA.AutoSize = true;
            this.labelMinA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinA.Location = new System.Drawing.Point(74, 78);
            this.labelMinA.Name = "labelMinA";
            this.labelMinA.Size = new System.Drawing.Size(19, 39);
            this.labelMinA.TabIndex = 12;
            this.labelMinA.Text = "[v]";
            this.labelMinA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinDU
            // 
            this.labelMinDU.AutoSize = true;
            this.labelMinDU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinDU.Location = new System.Drawing.Point(74, 117);
            this.labelMinDU.Name = "labelMinDU";
            this.labelMinDU.Size = new System.Drawing.Size(19, 39);
            this.labelMinDU.TabIndex = 13;
            this.labelMinDU.Text = "[v]";
            this.labelMinDU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinDV
            // 
            this.labelMinDV.AutoSize = true;
            this.labelMinDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinDV.Location = new System.Drawing.Point(74, 156);
            this.labelMinDV.Name = "labelMinDV";
            this.labelMinDV.Size = new System.Drawing.Size(19, 43);
            this.labelMinDV.TabIndex = 14;
            this.labelMinDV.Text = "[v]";
            this.labelMinDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxU
            // 
            this.labelMaxU.AutoSize = true;
            this.labelMaxU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxU.Location = new System.Drawing.Point(278, 0);
            this.labelMaxU.Name = "labelMaxU";
            this.labelMaxU.Size = new System.Drawing.Size(19, 39);
            this.labelMaxU.TabIndex = 15;
            this.labelMaxU.Text = "[v]";
            this.labelMaxU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxV
            // 
            this.labelMaxV.AutoSize = true;
            this.labelMaxV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxV.Location = new System.Drawing.Point(278, 39);
            this.labelMaxV.Name = "labelMaxV";
            this.labelMaxV.Size = new System.Drawing.Size(19, 39);
            this.labelMaxV.TabIndex = 16;
            this.labelMaxV.Text = "[v]";
            this.labelMaxV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxA
            // 
            this.labelMaxA.AutoSize = true;
            this.labelMaxA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxA.Location = new System.Drawing.Point(278, 78);
            this.labelMaxA.Name = "labelMaxA";
            this.labelMaxA.Size = new System.Drawing.Size(19, 39);
            this.labelMaxA.TabIndex = 17;
            this.labelMaxA.Text = "[v]";
            this.labelMaxA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxDU
            // 
            this.labelMaxDU.AutoSize = true;
            this.labelMaxDU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxDU.Location = new System.Drawing.Point(278, 117);
            this.labelMaxDU.Name = "labelMaxDU";
            this.labelMaxDU.Size = new System.Drawing.Size(19, 39);
            this.labelMaxDU.TabIndex = 18;
            this.labelMaxDU.Text = "[v]";
            this.labelMaxDU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxDV
            // 
            this.labelMaxDV.AutoSize = true;
            this.labelMaxDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxDV.Location = new System.Drawing.Point(278, 156);
            this.labelMaxDV.Name = "labelMaxDV";
            this.labelMaxDV.Size = new System.Drawing.Size(19, 43);
            this.labelMaxDV.TabIndex = 19;
            this.labelMaxDV.Text = "[v]";
            this.labelMaxDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarU
            // 
            this.trackBarU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarU.Location = new System.Drawing.Point(99, 3);
            this.trackBarU.Maximum = 360;
            this.trackBarU.Name = "trackBarU";
            this.trackBarU.Size = new System.Drawing.Size(173, 33);
            this.trackBarU.TabIndex = 20;
            this.trackBarU.Value = 360;
            this.trackBarU.Scroll += new System.EventHandler(this.onShapeParameterChanged);
            // 
            // trackBarV
            // 
            this.trackBarV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarV.Location = new System.Drawing.Point(99, 42);
            this.trackBarV.Maximum = 360;
            this.trackBarV.Name = "trackBarV";
            this.trackBarV.Size = new System.Drawing.Size(173, 33);
            this.trackBarV.TabIndex = 21;
            this.trackBarV.Value = 300;
            this.trackBarV.Scroll += new System.EventHandler(this.onShapeParameterChanged);
            // 
            // trackBarA
            // 
            this.trackBarA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarA.Location = new System.Drawing.Point(99, 81);
            this.trackBarA.Maximum = 250;
            this.trackBarA.Minimum = 2;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(173, 33);
            this.trackBarA.TabIndex = 22;
            this.trackBarA.Value = 100;
            this.trackBarA.Scroll += new System.EventHandler(this.onShapeParameterChanged);
            // 
            // trackBarDU
            // 
            this.trackBarDU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarDU.Location = new System.Drawing.Point(99, 120);
            this.trackBarDU.Maximum = 100;
            this.trackBarDU.Minimum = 2;
            this.trackBarDU.Name = "trackBarDU";
            this.trackBarDU.Size = new System.Drawing.Size(173, 33);
            this.trackBarDU.TabIndex = 23;
            this.trackBarDU.Value = 30;
            this.trackBarDU.Scroll += new System.EventHandler(this.onShapeParameterChanged);
            // 
            // trackBarDV
            // 
            this.trackBarDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarDV.Location = new System.Drawing.Point(99, 159);
            this.trackBarDV.Maximum = 100;
            this.trackBarDV.Minimum = 2;
            this.trackBarDV.Name = "trackBarDV";
            this.trackBarDV.Size = new System.Drawing.Size(173, 37);
            this.trackBarDV.TabIndex = 24;
            this.trackBarDV.Value = 30;
            this.trackBarDV.Scroll += new System.EventHandler(this.onShapeParameterChanged);
            // 
            // groupBoxRotate
            // 
            this.groupBoxRotate.Controls.Add(this.tableLayoutPanelRotate);
            this.groupBoxRotate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRotate.Location = new System.Drawing.Point(3, 3);
            this.groupBoxRotate.Name = "groupBoxRotate";
            this.groupBoxRotate.Size = new System.Drawing.Size(306, 106);
            this.groupBoxRotate.TabIndex = 1;
            this.groupBoxRotate.TabStop = false;
            this.groupBoxRotate.Text = "Поворот поверхности вокруг осей координат";
            // 
            // tableLayoutPanelRotate
            // 
            this.tableLayoutPanelRotate.ColumnCount = 5;
            this.tableLayoutPanelRotate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRotate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRotate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRotate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRotate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRotate.Controls.Add(this.labelMaxZ, 4, 2);
            this.tableLayoutPanelRotate.Controls.Add(this.labelMinZ, 2, 2);
            this.tableLayoutPanelRotate.Controls.Add(this.labelValZ, 1, 2);
            this.tableLayoutPanelRotate.Controls.Add(this.labelZ, 0, 2);
            this.tableLayoutPanelRotate.Controls.Add(this.labelMaxY, 4, 1);
            this.tableLayoutPanelRotate.Controls.Add(this.labelMinY, 2, 1);
            this.tableLayoutPanelRotate.Controls.Add(this.labelValY, 1, 1);
            this.tableLayoutPanelRotate.Controls.Add(this.labelY, 0, 1);
            this.tableLayoutPanelRotate.Controls.Add(this.labelMaxX, 4, 0);
            this.tableLayoutPanelRotate.Controls.Add(this.labelMinX, 2, 0);
            this.tableLayoutPanelRotate.Controls.Add(this.labelValX, 1, 0);
            this.tableLayoutPanelRotate.Controls.Add(this.labelX, 0, 0);
            this.tableLayoutPanelRotate.Controls.Add(this.trackBarX, 3, 0);
            this.tableLayoutPanelRotate.Controls.Add(this.trackBarY, 3, 1);
            this.tableLayoutPanelRotate.Controls.Add(this.trackBarZ, 3, 2);
            this.tableLayoutPanelRotate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRotate.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelRotate.Name = "tableLayoutPanelRotate";
            this.tableLayoutPanelRotate.RowCount = 3;
            this.tableLayoutPanelRotate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelRotate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelRotate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelRotate.Size = new System.Drawing.Size(300, 87);
            this.tableLayoutPanelRotate.TabIndex = 0;
            // 
            // labelMaxZ
            // 
            this.labelMaxZ.AutoSize = true;
            this.labelMaxZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxZ.Location = new System.Drawing.Point(278, 58);
            this.labelMaxZ.Name = "labelMaxZ";
            this.labelMaxZ.Size = new System.Drawing.Size(19, 29);
            this.labelMaxZ.TabIndex = 22;
            this.labelMaxZ.Text = "[v]";
            this.labelMaxZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinZ
            // 
            this.labelMinZ.AutoSize = true;
            this.labelMinZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinZ.Location = new System.Drawing.Point(66, 58);
            this.labelMinZ.Name = "labelMinZ";
            this.labelMinZ.Size = new System.Drawing.Size(19, 29);
            this.labelMinZ.TabIndex = 21;
            this.labelMinZ.Text = "[v]";
            this.labelMinZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValZ
            // 
            this.labelValZ.AutoSize = true;
            this.labelValZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValZ.Location = new System.Drawing.Point(26, 58);
            this.labelValZ.Name = "labelValZ";
            this.labelValZ.Size = new System.Drawing.Size(34, 29);
            this.labelValZ.TabIndex = 20;
            this.labelValZ.Text = "[v]";
            this.labelValZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelZ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZ.Location = new System.Drawing.Point(3, 58);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(17, 29);
            this.labelZ.TabIndex = 19;
            this.labelZ.Text = "Z";
            this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxY
            // 
            this.labelMaxY.AutoSize = true;
            this.labelMaxY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxY.Location = new System.Drawing.Point(278, 29);
            this.labelMaxY.Name = "labelMaxY";
            this.labelMaxY.Size = new System.Drawing.Size(19, 29);
            this.labelMaxY.TabIndex = 18;
            this.labelMaxY.Text = "[v]";
            this.labelMaxY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinY
            // 
            this.labelMinY.AutoSize = true;
            this.labelMinY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinY.Location = new System.Drawing.Point(66, 29);
            this.labelMinY.Name = "labelMinY";
            this.labelMinY.Size = new System.Drawing.Size(19, 29);
            this.labelMinY.TabIndex = 17;
            this.labelMinY.Text = "[v]";
            this.labelMinY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValY
            // 
            this.labelValY.AutoSize = true;
            this.labelValY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValY.Location = new System.Drawing.Point(26, 29);
            this.labelValY.Name = "labelValY";
            this.labelValY.Size = new System.Drawing.Size(34, 29);
            this.labelValY.TabIndex = 16;
            this.labelValY.Text = "[v]";
            this.labelValY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelY.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(3, 29);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 29);
            this.labelY.TabIndex = 15;
            this.labelY.Text = "Y";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxX
            // 
            this.labelMaxX.AutoSize = true;
            this.labelMaxX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxX.Location = new System.Drawing.Point(278, 0);
            this.labelMaxX.Name = "labelMaxX";
            this.labelMaxX.Size = new System.Drawing.Size(19, 29);
            this.labelMaxX.TabIndex = 14;
            this.labelMaxX.Text = "[v]";
            this.labelMaxX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinX
            // 
            this.labelMinX.AutoSize = true;
            this.labelMinX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinX.Location = new System.Drawing.Point(66, 0);
            this.labelMinX.Name = "labelMinX";
            this.labelMinX.Size = new System.Drawing.Size(19, 29);
            this.labelMinX.TabIndex = 13;
            this.labelMinX.Text = "[v]";
            this.labelMinX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValX
            // 
            this.labelValX.AutoSize = true;
            this.labelValX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValX.Location = new System.Drawing.Point(26, 0);
            this.labelValX.Name = "labelValX";
            this.labelValX.Size = new System.Drawing.Size(34, 29);
            this.labelValX.TabIndex = 12;
            this.labelValX.Text = "[v]";
            this.labelValX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(3, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 29);
            this.labelX.TabIndex = 11;
            this.labelX.Text = "X";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarX
            // 
            this.trackBarX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarX.Location = new System.Drawing.Point(91, 3);
            this.trackBarX.Maximum = 360;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(181, 23);
            this.trackBarX.TabIndex = 0;
            this.trackBarX.Scroll += new System.EventHandler(this.onRotation);
            // 
            // trackBarY
            // 
            this.trackBarY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarY.Location = new System.Drawing.Point(91, 32);
            this.trackBarY.Maximum = 360;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(181, 23);
            this.trackBarY.TabIndex = 1;
            this.trackBarY.Scroll += new System.EventHandler(this.onRotation);
            // 
            // trackBarZ
            // 
            this.trackBarZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarZ.Location = new System.Drawing.Point(91, 61);
            this.trackBarZ.Maximum = 360;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(181, 23);
            this.trackBarZ.TabIndex = 2;
            this.trackBarZ.Scroll += new System.EventHandler(this.onRotation);
            // 
            // groupBoxLightParam
            // 
            this.groupBoxLightParam.Controls.Add(this.tableLayoutPanelLightParam);
            this.groupBoxLightParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLightParam.Location = new System.Drawing.Point(627, 3);
            this.groupBoxLightParam.Name = "groupBoxLightParam";
            this.tableLayoutPanelParam.SetRowSpan(this.groupBoxLightParam, 2);
            this.groupBoxLightParam.Size = new System.Drawing.Size(308, 218);
            this.groupBoxLightParam.TabIndex = 2;
            this.groupBoxLightParam.TabStop = false;
            this.groupBoxLightParam.Text = "Параметры составляющих света";
            // 
            // tableLayoutPanelLightParam
            // 
            this.tableLayoutPanelLightParam.ColumnCount = 5;
            this.tableLayoutPanelLightParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLightParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLightParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLightParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLightParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLightParam.Controls.Add(this.labelMaxPower, 4, 3);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelMaxSpecularLight, 4, 2);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelMaxDiffuseLight, 4, 1);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelMaxAmbientLight, 4, 0);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelMinDiffuseLight, 2, 1);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelMinSpecularLight, 2, 2);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelValPower, 1, 3);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelMinPower, 1, 3);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelMinAmbientLight, 2, 0);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelValSpecularLight, 1, 2);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelValDiffuseLight, 1, 1);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelValAmbientLight, 1, 0);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelPower, 0, 3);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelSpecularLight, 0, 2);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelDiffuseLight, 0, 1);
            this.tableLayoutPanelLightParam.Controls.Add(this.labelAmbientLight, 0, 0);
            this.tableLayoutPanelLightParam.Controls.Add(this.trackBarAmbientLight, 3, 0);
            this.tableLayoutPanelLightParam.Controls.Add(this.trackBarDiffuseLight, 3, 1);
            this.tableLayoutPanelLightParam.Controls.Add(this.trackBarSpecularLight, 3, 2);
            this.tableLayoutPanelLightParam.Controls.Add(this.trackBarPower, 3, 3);
            this.tableLayoutPanelLightParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLightParam.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelLightParam.Name = "tableLayoutPanelLightParam";
            this.tableLayoutPanelLightParam.RowCount = 4;
            this.tableLayoutPanelLightParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLightParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLightParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLightParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLightParam.Size = new System.Drawing.Size(302, 199);
            this.tableLayoutPanelLightParam.TabIndex = 0;
            // 
            // labelMaxPower
            // 
            this.labelMaxPower.AutoSize = true;
            this.labelMaxPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxPower.Location = new System.Drawing.Point(280, 147);
            this.labelMaxPower.Name = "labelMaxPower";
            this.labelMaxPower.Size = new System.Drawing.Size(19, 52);
            this.labelMaxPower.TabIndex = 28;
            this.labelMaxPower.Text = "[v]";
            this.labelMaxPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxSpecularLight
            // 
            this.labelMaxSpecularLight.AutoSize = true;
            this.labelMaxSpecularLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxSpecularLight.Location = new System.Drawing.Point(280, 98);
            this.labelMaxSpecularLight.Name = "labelMaxSpecularLight";
            this.labelMaxSpecularLight.Size = new System.Drawing.Size(19, 49);
            this.labelMaxSpecularLight.TabIndex = 27;
            this.labelMaxSpecularLight.Text = "[v]";
            this.labelMaxSpecularLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxDiffuseLight
            // 
            this.labelMaxDiffuseLight.AutoSize = true;
            this.labelMaxDiffuseLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxDiffuseLight.Location = new System.Drawing.Point(280, 49);
            this.labelMaxDiffuseLight.Name = "labelMaxDiffuseLight";
            this.labelMaxDiffuseLight.Size = new System.Drawing.Size(19, 49);
            this.labelMaxDiffuseLight.TabIndex = 26;
            this.labelMaxDiffuseLight.Text = "[v]";
            this.labelMaxDiffuseLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxAmbientLight
            // 
            this.labelMaxAmbientLight.AutoSize = true;
            this.labelMaxAmbientLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxAmbientLight.Location = new System.Drawing.Point(280, 0);
            this.labelMaxAmbientLight.Name = "labelMaxAmbientLight";
            this.labelMaxAmbientLight.Size = new System.Drawing.Size(19, 49);
            this.labelMaxAmbientLight.TabIndex = 25;
            this.labelMaxAmbientLight.Text = "[v]";
            this.labelMaxAmbientLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinDiffuseLight
            // 
            this.labelMinDiffuseLight.AutoSize = true;
            this.labelMinDiffuseLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinDiffuseLight.Location = new System.Drawing.Point(160, 49);
            this.labelMinDiffuseLight.Name = "labelMinDiffuseLight";
            this.labelMinDiffuseLight.Size = new System.Drawing.Size(19, 49);
            this.labelMinDiffuseLight.TabIndex = 20;
            this.labelMinDiffuseLight.Text = "[v]";
            this.labelMinDiffuseLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinSpecularLight
            // 
            this.labelMinSpecularLight.AutoSize = true;
            this.labelMinSpecularLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinSpecularLight.Location = new System.Drawing.Point(160, 98);
            this.labelMinSpecularLight.Name = "labelMinSpecularLight";
            this.labelMinSpecularLight.Size = new System.Drawing.Size(19, 49);
            this.labelMinSpecularLight.TabIndex = 19;
            this.labelMinSpecularLight.Text = "[v]";
            this.labelMinSpecularLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValPower
            // 
            this.labelValPower.AutoSize = true;
            this.labelValPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValPower.Location = new System.Drawing.Point(135, 147);
            this.labelValPower.Name = "labelValPower";
            this.labelValPower.Size = new System.Drawing.Size(19, 52);
            this.labelValPower.TabIndex = 18;
            this.labelValPower.Text = "[v]";
            this.labelValPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinPower
            // 
            this.labelMinPower.AutoSize = true;
            this.labelMinPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinPower.Location = new System.Drawing.Point(160, 147);
            this.labelMinPower.Name = "labelMinPower";
            this.labelMinPower.Size = new System.Drawing.Size(19, 52);
            this.labelMinPower.TabIndex = 17;
            this.labelMinPower.Text = "[v]";
            this.labelMinPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinAmbientLight
            // 
            this.labelMinAmbientLight.AutoSize = true;
            this.labelMinAmbientLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinAmbientLight.Location = new System.Drawing.Point(160, 0);
            this.labelMinAmbientLight.Name = "labelMinAmbientLight";
            this.labelMinAmbientLight.Size = new System.Drawing.Size(19, 49);
            this.labelMinAmbientLight.TabIndex = 16;
            this.labelMinAmbientLight.Text = "[v]";
            this.labelMinAmbientLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValSpecularLight
            // 
            this.labelValSpecularLight.AutoSize = true;
            this.labelValSpecularLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValSpecularLight.Location = new System.Drawing.Point(135, 98);
            this.labelValSpecularLight.Name = "labelValSpecularLight";
            this.labelValSpecularLight.Size = new System.Drawing.Size(19, 49);
            this.labelValSpecularLight.TabIndex = 15;
            this.labelValSpecularLight.Text = "[v]";
            this.labelValSpecularLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValDiffuseLight
            // 
            this.labelValDiffuseLight.AutoSize = true;
            this.labelValDiffuseLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValDiffuseLight.Location = new System.Drawing.Point(135, 49);
            this.labelValDiffuseLight.Name = "labelValDiffuseLight";
            this.labelValDiffuseLight.Size = new System.Drawing.Size(19, 49);
            this.labelValDiffuseLight.TabIndex = 14;
            this.labelValDiffuseLight.Text = "[v]";
            this.labelValDiffuseLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValAmbientLight
            // 
            this.labelValAmbientLight.AutoSize = true;
            this.labelValAmbientLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValAmbientLight.Location = new System.Drawing.Point(135, 0);
            this.labelValAmbientLight.Name = "labelValAmbientLight";
            this.labelValAmbientLight.Size = new System.Drawing.Size(19, 49);
            this.labelValAmbientLight.TabIndex = 13;
            this.labelValAmbientLight.Text = "[v]";
            this.labelValAmbientLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPower.Location = new System.Drawing.Point(3, 147);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(126, 52);
            this.labelPower.TabIndex = 3;
            this.labelPower.Text = "Степень (p)";
            this.labelPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSpecularLight
            // 
            this.labelSpecularLight.AutoSize = true;
            this.labelSpecularLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSpecularLight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSpecularLight.Location = new System.Drawing.Point(3, 98);
            this.labelSpecularLight.Name = "labelSpecularLight";
            this.labelSpecularLight.Size = new System.Drawing.Size(126, 49);
            this.labelSpecularLight.TabIndex = 2;
            this.labelSpecularLight.Text = "Отражаемы свет-Ks";
            this.labelSpecularLight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDiffuseLight
            // 
            this.labelDiffuseLight.AutoSize = true;
            this.labelDiffuseLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDiffuseLight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDiffuseLight.Location = new System.Drawing.Point(3, 49);
            this.labelDiffuseLight.Name = "labelDiffuseLight";
            this.labelDiffuseLight.Size = new System.Drawing.Size(126, 49);
            this.labelDiffuseLight.TabIndex = 1;
            this.labelDiffuseLight.Text = "Рассеиваемый свет-Ka";
            this.labelDiffuseLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAmbientLight
            // 
            this.labelAmbientLight.AutoSize = true;
            this.labelAmbientLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAmbientLight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAmbientLight.Location = new System.Drawing.Point(3, 0);
            this.labelAmbientLight.Name = "labelAmbientLight";
            this.labelAmbientLight.Size = new System.Drawing.Size(126, 49);
            this.labelAmbientLight.TabIndex = 0;
            this.labelAmbientLight.Text = "Фоновый свет-Kd";
            this.labelAmbientLight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBarAmbientLight
            // 
            this.trackBarAmbientLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarAmbientLight.Location = new System.Drawing.Point(185, 3);
            this.trackBarAmbientLight.Name = "trackBarAmbientLight";
            this.trackBarAmbientLight.Size = new System.Drawing.Size(89, 43);
            this.trackBarAmbientLight.TabIndex = 21;
            this.trackBarAmbientLight.Value = 2;
            this.trackBarAmbientLight.Scroll += new System.EventHandler(this.onDrawChanged);
            // 
            // trackBarDiffuseLight
            // 
            this.trackBarDiffuseLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarDiffuseLight.Location = new System.Drawing.Point(185, 52);
            this.trackBarDiffuseLight.Name = "trackBarDiffuseLight";
            this.trackBarDiffuseLight.Size = new System.Drawing.Size(89, 43);
            this.trackBarDiffuseLight.TabIndex = 22;
            this.trackBarDiffuseLight.Value = 10;
            this.trackBarDiffuseLight.Scroll += new System.EventHandler(this.onDrawChanged);
            // 
            // trackBarSpecularLight
            // 
            this.trackBarSpecularLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarSpecularLight.Location = new System.Drawing.Point(185, 101);
            this.trackBarSpecularLight.Name = "trackBarSpecularLight";
            this.trackBarSpecularLight.Size = new System.Drawing.Size(89, 43);
            this.trackBarSpecularLight.TabIndex = 23;
            this.trackBarSpecularLight.Value = 8;
            this.trackBarSpecularLight.Scroll += new System.EventHandler(this.onDrawChanged);
            // 
            // trackBarPower
            // 
            this.trackBarPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarPower.Location = new System.Drawing.Point(185, 150);
            this.trackBarPower.Maximum = 50;
            this.trackBarPower.Name = "trackBarPower";
            this.trackBarPower.Size = new System.Drawing.Size(89, 46);
            this.trackBarPower.TabIndex = 24;
            this.trackBarPower.Value = 25;
            this.trackBarPower.Scroll += new System.EventHandler(this.onDrawChanged);
            // 
            // tableLayoutPanelDraw
            // 
            this.tableLayoutPanelDraw.ColumnCount = 2;
            this.tableLayoutPanelDraw.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDraw.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDraw.Controls.Add(this.pictureBoxDraw, 0, 0);
            this.tableLayoutPanelDraw.Controls.Add(this.tableLayoutPanelFill, 1, 0);
            this.tableLayoutPanelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDraw.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelDraw.Name = "tableLayoutPanelDraw";
            this.tableLayoutPanelDraw.RowCount = 1;
            this.tableLayoutPanelDraw.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDraw.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDraw.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDraw.Size = new System.Drawing.Size(938, 386);
            this.tableLayoutPanelDraw.TabIndex = 2;
            // 
            // pictureBoxDraw
            // 
            this.pictureBoxDraw.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDraw.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxDraw.Name = "pictureBoxDraw";
            this.pictureBoxDraw.Size = new System.Drawing.Size(463, 380);
            this.pictureBoxDraw.TabIndex = 0;
            this.pictureBoxDraw.TabStop = false;
            this.pictureBoxDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.onShapeDraw);
            this.pictureBoxDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDraw_MouseDown);
            this.pictureBoxDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDraw_MouseMove);
            this.pictureBoxDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDraw_MouseUp);
            // 
            // tableLayoutPanelFill
            // 
            this.tableLayoutPanelFill.ColumnCount = 2;
            this.tableLayoutPanelFill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFill.Controls.Add(this.groupBoxFillMethod, 0, 0);
            this.tableLayoutPanelFill.Controls.Add(this.groupBoxFillColor, 0, 1);
            this.tableLayoutPanelFill.Controls.Add(this.groupBoxLightColor, 1, 1);
            this.tableLayoutPanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFill.Location = new System.Drawing.Point(472, 3);
            this.tableLayoutPanelFill.Name = "tableLayoutPanelFill";
            this.tableLayoutPanelFill.RowCount = 2;
            this.tableLayoutPanelFill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelFill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFill.Size = new System.Drawing.Size(463, 380);
            this.tableLayoutPanelFill.TabIndex = 1;
            // 
            // groupBoxFillMethod
            // 
            this.tableLayoutPanelFill.SetColumnSpan(this.groupBoxFillMethod, 2);
            this.groupBoxFillMethod.Controls.Add(this.radioButtonGouraudShading);
            this.groupBoxFillMethod.Controls.Add(this.radioButtonPhongShading);
            this.groupBoxFillMethod.Controls.Add(this.radioButtonFlatHLSRFrame);
            this.groupBoxFillMethod.Controls.Add(this.checkBoxPolyZSort);
            this.groupBoxFillMethod.Controls.Add(this.radioButtonFlatFrame);
            this.groupBoxFillMethod.Controls.Add(this.radioButtonWireframe);
            this.groupBoxFillMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFillMethod.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFillMethod.Name = "groupBoxFillMethod";
            this.groupBoxFillMethod.Size = new System.Drawing.Size(457, 94);
            this.groupBoxFillMethod.TabIndex = 0;
            this.groupBoxFillMethod.TabStop = false;
            this.groupBoxFillMethod.Text = "Метод закраски";
            // 
            // radioButtonGouraudShading
            // 
            this.radioButtonGouraudShading.AutoSize = true;
            this.radioButtonGouraudShading.Location = new System.Drawing.Point(182, 65);
            this.radioButtonGouraudShading.Name = "radioButtonGouraudShading";
            this.radioButtonGouraudShading.Size = new System.Drawing.Size(100, 17);
            this.radioButtonGouraudShading.TabIndex = 5;
            this.radioButtonGouraudShading.TabStop = true;
            this.radioButtonGouraudShading.Text = "Закраска Гуро";
            this.radioButtonGouraudShading.UseVisualStyleBackColor = true;
            this.radioButtonGouraudShading.CheckedChanged += new System.EventHandler(this.onDrawChanged);
            // 
            // radioButtonPhongShading
            // 
            this.radioButtonPhongShading.AutoSize = true;
            this.radioButtonPhongShading.Location = new System.Drawing.Point(182, 42);
            this.radioButtonPhongShading.Name = "radioButtonPhongShading";
            this.radioButtonPhongShading.Size = new System.Drawing.Size(111, 17);
            this.radioButtonPhongShading.TabIndex = 4;
            this.radioButtonPhongShading.TabStop = true;
            this.radioButtonPhongShading.Text = "Закраска Фонга";
            this.radioButtonPhongShading.UseVisualStyleBackColor = true;
            this.radioButtonPhongShading.CheckedChanged += new System.EventHandler(this.onDrawChanged);
            // 
            // radioButtonFlatHLSRFrame
            // 
            this.radioButtonFlatHLSRFrame.AutoSize = true;
            this.radioButtonFlatHLSRFrame.Location = new System.Drawing.Point(182, 19);
            this.radioButtonFlatHLSRFrame.Name = "radioButtonFlatHLSRFrame";
            this.radioButtonFlatHLSRFrame.Size = new System.Drawing.Size(137, 17);
            this.radioButtonFlatHLSRFrame.TabIndex = 3;
            this.radioButtonFlatHLSRFrame.TabStop = true;
            this.radioButtonFlatHLSRFrame.Text = "Flat закраска с УНЛП";
            this.radioButtonFlatHLSRFrame.UseVisualStyleBackColor = true;
            this.radioButtonFlatHLSRFrame.CheckedChanged += new System.EventHandler(this.onDrawChanged);
            // 
            // checkBoxPolyZSort
            // 
            this.checkBoxPolyZSort.AutoSize = true;
            this.checkBoxPolyZSort.Location = new System.Drawing.Point(353, 19);
            this.checkBoxPolyZSort.Name = "checkBoxPolyZSort";
            this.checkBoxPolyZSort.Size = new System.Drawing.Size(110, 17);
            this.checkBoxPolyZSort.TabIndex = 2;
            this.checkBoxPolyZSort.Text = "сортировка по Z";
            this.checkBoxPolyZSort.UseVisualStyleBackColor = true;
            this.checkBoxPolyZSort.Visible = false;
            this.checkBoxPolyZSort.CheckedChanged += new System.EventHandler(this.onDrawChanged);
            // 
            // radioButtonFlatFrame
            // 
            this.radioButtonFlatFrame.AutoSize = true;
            this.radioButtonFlatFrame.Location = new System.Drawing.Point(12, 42);
            this.radioButtonFlatFrame.Name = "radioButtonFlatFrame";
            this.radioButtonFlatFrame.Size = new System.Drawing.Size(93, 17);
            this.radioButtonFlatFrame.TabIndex = 1;
            this.radioButtonFlatFrame.Text = "Flat закраска";
            this.radioButtonFlatFrame.UseVisualStyleBackColor = true;
            this.radioButtonFlatFrame.CheckedChanged += new System.EventHandler(this.onDrawChanged);
            // 
            // radioButtonWireframe
            // 
            this.radioButtonWireframe.AutoSize = true;
            this.radioButtonWireframe.Checked = true;
            this.radioButtonWireframe.Location = new System.Drawing.Point(12, 19);
            this.radioButtonWireframe.Name = "radioButtonWireframe";
            this.radioButtonWireframe.Size = new System.Drawing.Size(131, 17);
            this.radioButtonWireframe.TabIndex = 0;
            this.radioButtonWireframe.TabStop = true;
            this.radioButtonWireframe.Text = "Каркасная закраска";
            this.radioButtonWireframe.UseVisualStyleBackColor = true;
            this.radioButtonWireframe.CheckedChanged += new System.EventHandler(this.onDrawChanged);
            // 
            // groupBoxFillColor
            // 
            this.groupBoxFillColor.Controls.Add(this.tableLayoutPanelFillColor);
            this.groupBoxFillColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFillColor.Location = new System.Drawing.Point(3, 103);
            this.groupBoxFillColor.Name = "groupBoxFillColor";
            this.groupBoxFillColor.Size = new System.Drawing.Size(225, 274);
            this.groupBoxFillColor.TabIndex = 1;
            this.groupBoxFillColor.TabStop = false;
            this.groupBoxFillColor.Text = "Цвета сторон";
            // 
            // tableLayoutPanelFillColor
            // 
            this.tableLayoutPanelFillColor.ColumnCount = 1;
            this.tableLayoutPanelFillColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFillColor.Controls.Add(this.tableLayoutPanelFillColorInternal, 0, 1);
            this.tableLayoutPanelFillColor.Controls.Add(this.tableLayoutPanelFillColorExternal, 0, 0);
            this.tableLayoutPanelFillColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFillColor.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelFillColor.Name = "tableLayoutPanelFillColor";
            this.tableLayoutPanelFillColor.RowCount = 2;
            this.tableLayoutPanelFillColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFillColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFillColor.Size = new System.Drawing.Size(219, 255);
            this.tableLayoutPanelFillColor.TabIndex = 2;
            // 
            // tableLayoutPanelFillColorInternal
            // 
            this.tableLayoutPanelFillColorInternal.ColumnCount = 2;
            this.tableLayoutPanelFillColorInternal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.tableLayoutPanelFillColorInternal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanelFillColorInternal.Controls.Add(this.pictureBoxIntern, 1, 1);
            this.tableLayoutPanelFillColorInternal.Controls.Add(this.tableLayoutPanelFillColorInternalParam, 0, 1);
            this.tableLayoutPanelFillColorInternal.Controls.Add(this.labelInternal, 0, 0);
            this.tableLayoutPanelFillColorInternal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFillColorInternal.Location = new System.Drawing.Point(3, 130);
            this.tableLayoutPanelFillColorInternal.Name = "tableLayoutPanelFillColorInternal";
            this.tableLayoutPanelFillColorInternal.RowCount = 2;
            this.tableLayoutPanelFillColorInternal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.30986F));
            this.tableLayoutPanelFillColorInternal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.69014F));
            this.tableLayoutPanelFillColorInternal.Size = new System.Drawing.Size(213, 122);
            this.tableLayoutPanelFillColorInternal.TabIndex = 2;
            // 
            // pictureBoxIntern
            // 
            this.pictureBoxIntern.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxIntern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxIntern.Location = new System.Drawing.Point(187, 25);
            this.pictureBoxIntern.Name = "pictureBoxIntern";
            this.pictureBoxIntern.Size = new System.Drawing.Size(23, 94);
            this.pictureBoxIntern.TabIndex = 1;
            this.pictureBoxIntern.TabStop = false;
            // 
            // tableLayoutPanelFillColorInternalParam
            // 
            this.tableLayoutPanelFillColorInternalParam.ColumnCount = 4;
            this.tableLayoutPanelFillColorInternalParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFillColorInternalParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelFillColorInternalParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFillColorInternalParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFillColorInternalParam.Controls.Add(this.labelValB2, 0, 2);
            this.tableLayoutPanelFillColorInternalParam.Controls.Add(this.labelB2, 0, 2);
            this.tableLayoutPanelFillColorInternalParam.Controls.Add(this.trackBarR1, 2, 0);
            this.tableLayoutPanelFillColorInternalParam.Controls.Add(this.trackBarG1, 2, 1);
            this.tableLayoutPanelFillColorInternalParam.Controls.Add(this.trackBarB1, 2, 2);
            this.tableLayoutPanelFillColorInternalParam.Controls.Add(this.labelR2, 0, 0);
            this.tableLayoutPanelFillColorInternalParam.Controls.Add(this.labelValR2, 1, 0);
            this.tableLayoutPanelFillColorInternalParam.Controls.Add(this.labelMaxR2, 3, 0);
            this.tableLayoutPanelFillColorInternalParam.Controls.Add(this.labelG2, 0, 1);
            this.tableLayoutPanelFillColorInternalParam.Controls.Add(this.labelValG2, 1, 1);
            this.tableLayoutPanelFillColorInternalParam.Controls.Add(this.labelMaxG2, 3, 1);
            this.tableLayoutPanelFillColorInternalParam.Controls.Add(this.labelMaxB2, 3, 2);
            this.tableLayoutPanelFillColorInternalParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFillColorInternalParam.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanelFillColorInternalParam.Name = "tableLayoutPanelFillColorInternalParam";
            this.tableLayoutPanelFillColorInternalParam.RowCount = 3;
            this.tableLayoutPanelFillColorInternalParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFillColorInternalParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFillColorInternalParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFillColorInternalParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFillColorInternalParam.Size = new System.Drawing.Size(178, 94);
            this.tableLayoutPanelFillColorInternalParam.TabIndex = 2;
            // 
            // labelValB2
            // 
            this.labelValB2.AutoSize = true;
            this.labelValB2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValB2.Location = new System.Drawing.Point(24, 62);
            this.labelValB2.Name = "labelValB2";
            this.labelValB2.Size = new System.Drawing.Size(26, 32);
            this.labelValB2.TabIndex = 13;
            this.labelValB2.Text = "[v]";
            this.labelValB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelB2
            // 
            this.labelB2.AutoSize = true;
            this.labelB2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB2.Location = new System.Drawing.Point(3, 62);
            this.labelB2.Name = "labelB2";
            this.labelB2.Size = new System.Drawing.Size(15, 32);
            this.labelB2.TabIndex = 10;
            this.labelB2.Text = "B";
            this.labelB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarR1
            // 
            this.trackBarR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarR1.Location = new System.Drawing.Point(56, 3);
            this.trackBarR1.Maximum = 255;
            this.trackBarR1.Name = "trackBarR1";
            this.trackBarR1.Size = new System.Drawing.Size(94, 25);
            this.trackBarR1.TabIndex = 1;
            this.trackBarR1.Scroll += new System.EventHandler(this.onColorChanged);
            // 
            // trackBarG1
            // 
            this.trackBarG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarG1.Location = new System.Drawing.Point(56, 34);
            this.trackBarG1.Maximum = 255;
            this.trackBarG1.Name = "trackBarG1";
            this.trackBarG1.Size = new System.Drawing.Size(94, 25);
            this.trackBarG1.TabIndex = 2;
            this.trackBarG1.Scroll += new System.EventHandler(this.onColorChanged);
            // 
            // trackBarB1
            // 
            this.trackBarB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarB1.Location = new System.Drawing.Point(56, 65);
            this.trackBarB1.Maximum = 255;
            this.trackBarB1.Name = "trackBarB1";
            this.trackBarB1.Size = new System.Drawing.Size(94, 26);
            this.trackBarB1.TabIndex = 3;
            this.trackBarB1.Scroll += new System.EventHandler(this.onColorChanged);
            // 
            // labelR2
            // 
            this.labelR2.AutoSize = true;
            this.labelR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelR2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR2.Location = new System.Drawing.Point(3, 0);
            this.labelR2.Name = "labelR2";
            this.labelR2.Size = new System.Drawing.Size(15, 31);
            this.labelR2.TabIndex = 5;
            this.labelR2.Text = "R";
            this.labelR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValR2
            // 
            this.labelValR2.AutoSize = true;
            this.labelValR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValR2.Location = new System.Drawing.Point(24, 0);
            this.labelValR2.Name = "labelValR2";
            this.labelValR2.Size = new System.Drawing.Size(26, 31);
            this.labelValR2.TabIndex = 6;
            this.labelValR2.Text = "[v]";
            this.labelValR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxR2
            // 
            this.labelMaxR2.AutoSize = true;
            this.labelMaxR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxR2.Location = new System.Drawing.Point(156, 0);
            this.labelMaxR2.Name = "labelMaxR2";
            this.labelMaxR2.Size = new System.Drawing.Size(19, 31);
            this.labelMaxR2.TabIndex = 7;
            this.labelMaxR2.Text = "[v]";
            this.labelMaxR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelG2
            // 
            this.labelG2.AutoSize = true;
            this.labelG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelG2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG2.Location = new System.Drawing.Point(3, 31);
            this.labelG2.Name = "labelG2";
            this.labelG2.Size = new System.Drawing.Size(15, 31);
            this.labelG2.TabIndex = 8;
            this.labelG2.Text = "G";
            this.labelG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValG2
            // 
            this.labelValG2.AutoSize = true;
            this.labelValG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValG2.Location = new System.Drawing.Point(24, 31);
            this.labelValG2.Name = "labelValG2";
            this.labelValG2.Size = new System.Drawing.Size(26, 31);
            this.labelValG2.TabIndex = 9;
            this.labelValG2.Text = "[v]";
            this.labelValG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxG2
            // 
            this.labelMaxG2.AutoSize = true;
            this.labelMaxG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxG2.Location = new System.Drawing.Point(156, 31);
            this.labelMaxG2.Name = "labelMaxG2";
            this.labelMaxG2.Size = new System.Drawing.Size(19, 31);
            this.labelMaxG2.TabIndex = 11;
            this.labelMaxG2.Text = "[v]";
            this.labelMaxG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxB2
            // 
            this.labelMaxB2.AutoSize = true;
            this.labelMaxB2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxB2.Location = new System.Drawing.Point(156, 62);
            this.labelMaxB2.Name = "labelMaxB2";
            this.labelMaxB2.Size = new System.Drawing.Size(19, 32);
            this.labelMaxB2.TabIndex = 12;
            this.labelMaxB2.Text = "[v]";
            this.labelMaxB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInternal
            // 
            this.labelInternal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInternal.AutoSize = true;
            this.tableLayoutPanelFillColorInternal.SetColumnSpan(this.labelInternal, 2);
            this.labelInternal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInternal.Location = new System.Drawing.Point(3, 0);
            this.labelInternal.Name = "labelInternal";
            this.labelInternal.Size = new System.Drawing.Size(207, 22);
            this.labelInternal.TabIndex = 0;
            this.labelInternal.Text = "Внутренняя сторона";
            this.labelInternal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelFillColorExternal
            // 
            this.tableLayoutPanelFillColorExternal.ColumnCount = 2;
            this.tableLayoutPanelFillColorExternal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.tableLayoutPanelFillColorExternal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanelFillColorExternal.Controls.Add(this.labelExternal, 0, 0);
            this.tableLayoutPanelFillColorExternal.Controls.Add(this.pictureBoxExtern, 1, 1);
            this.tableLayoutPanelFillColorExternal.Controls.Add(this.tableLayoutPanelFillColorExternalParam, 0, 1);
            this.tableLayoutPanelFillColorExternal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFillColorExternal.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelFillColorExternal.Name = "tableLayoutPanelFillColorExternal";
            this.tableLayoutPanelFillColorExternal.RowCount = 2;
            this.tableLayoutPanelFillColorExternal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanelFillColorExternal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.25F));
            this.tableLayoutPanelFillColorExternal.Size = new System.Drawing.Size(213, 121);
            this.tableLayoutPanelFillColorExternal.TabIndex = 1;
            // 
            // labelExternal
            // 
            this.labelExternal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExternal.AutoSize = true;
            this.tableLayoutPanelFillColorExternal.SetColumnSpan(this.labelExternal, 2);
            this.labelExternal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExternal.Location = new System.Drawing.Point(3, 0);
            this.labelExternal.Name = "labelExternal";
            this.labelExternal.Size = new System.Drawing.Size(207, 22);
            this.labelExternal.TabIndex = 0;
            this.labelExternal.Text = "Внешняя сторона";
            this.labelExternal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxExtern
            // 
            this.pictureBoxExtern.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxExtern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxExtern.Location = new System.Drawing.Point(187, 25);
            this.pictureBoxExtern.Name = "pictureBoxExtern";
            this.pictureBoxExtern.Size = new System.Drawing.Size(23, 93);
            this.pictureBoxExtern.TabIndex = 1;
            this.pictureBoxExtern.TabStop = false;
            // 
            // tableLayoutPanelFillColorExternalParam
            // 
            this.tableLayoutPanelFillColorExternalParam.ColumnCount = 4;
            this.tableLayoutPanelFillColorExternalParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFillColorExternalParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelFillColorExternalParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFillColorExternalParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFillColorExternalParam.Controls.Add(this.labelMaxB1, 3, 2);
            this.tableLayoutPanelFillColorExternalParam.Controls.Add(this.labelValB1, 1, 2);
            this.tableLayoutPanelFillColorExternalParam.Controls.Add(this.labelB1, 0, 2);
            this.tableLayoutPanelFillColorExternalParam.Controls.Add(this.labelMaxG1, 3, 1);
            this.tableLayoutPanelFillColorExternalParam.Controls.Add(this.labelValG1, 1, 1);
            this.tableLayoutPanelFillColorExternalParam.Controls.Add(this.labelG1, 0, 1);
            this.tableLayoutPanelFillColorExternalParam.Controls.Add(this.labelMaxR1, 3, 0);
            this.tableLayoutPanelFillColorExternalParam.Controls.Add(this.labelValR1, 1, 0);
            this.tableLayoutPanelFillColorExternalParam.Controls.Add(this.trackBarR2, 2, 0);
            this.tableLayoutPanelFillColorExternalParam.Controls.Add(this.trackBarG2, 2, 1);
            this.tableLayoutPanelFillColorExternalParam.Controls.Add(this.trackBarB2, 2, 2);
            this.tableLayoutPanelFillColorExternalParam.Controls.Add(this.labelR1, 0, 0);
            this.tableLayoutPanelFillColorExternalParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFillColorExternalParam.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanelFillColorExternalParam.Name = "tableLayoutPanelFillColorExternalParam";
            this.tableLayoutPanelFillColorExternalParam.RowCount = 3;
            this.tableLayoutPanelFillColorExternalParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFillColorExternalParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFillColorExternalParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFillColorExternalParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFillColorExternalParam.Size = new System.Drawing.Size(178, 93);
            this.tableLayoutPanelFillColorExternalParam.TabIndex = 2;
            // 
            // labelMaxB1
            // 
            this.labelMaxB1.AutoSize = true;
            this.labelMaxB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxB1.Location = new System.Drawing.Point(156, 62);
            this.labelMaxB1.Name = "labelMaxB1";
            this.labelMaxB1.Size = new System.Drawing.Size(19, 31);
            this.labelMaxB1.TabIndex = 12;
            this.labelMaxB1.Text = "[v]";
            this.labelMaxB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValB1
            // 
            this.labelValB1.AutoSize = true;
            this.labelValB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValB1.Location = new System.Drawing.Point(24, 62);
            this.labelValB1.Name = "labelValB1";
            this.labelValB1.Size = new System.Drawing.Size(26, 31);
            this.labelValB1.TabIndex = 11;
            this.labelValB1.Text = "[v]";
            this.labelValB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelB1
            // 
            this.labelB1.AutoSize = true;
            this.labelB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB1.Location = new System.Drawing.Point(3, 62);
            this.labelB1.Name = "labelB1";
            this.labelB1.Size = new System.Drawing.Size(15, 31);
            this.labelB1.TabIndex = 10;
            this.labelB1.Text = "B";
            this.labelB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxG1
            // 
            this.labelMaxG1.AutoSize = true;
            this.labelMaxG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxG1.Location = new System.Drawing.Point(156, 31);
            this.labelMaxG1.Name = "labelMaxG1";
            this.labelMaxG1.Size = new System.Drawing.Size(19, 31);
            this.labelMaxG1.TabIndex = 9;
            this.labelMaxG1.Text = "[v]";
            this.labelMaxG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValG1
            // 
            this.labelValG1.AutoSize = true;
            this.labelValG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValG1.Location = new System.Drawing.Point(24, 31);
            this.labelValG1.Name = "labelValG1";
            this.labelValG1.Size = new System.Drawing.Size(26, 31);
            this.labelValG1.TabIndex = 8;
            this.labelValG1.Text = "[v]";
            this.labelValG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelG1
            // 
            this.labelG1.AutoSize = true;
            this.labelG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelG1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG1.Location = new System.Drawing.Point(3, 31);
            this.labelG1.Name = "labelG1";
            this.labelG1.Size = new System.Drawing.Size(15, 31);
            this.labelG1.TabIndex = 7;
            this.labelG1.Text = "G";
            this.labelG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxR1
            // 
            this.labelMaxR1.AutoSize = true;
            this.labelMaxR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxR1.Location = new System.Drawing.Point(156, 0);
            this.labelMaxR1.Name = "labelMaxR1";
            this.labelMaxR1.Size = new System.Drawing.Size(19, 31);
            this.labelMaxR1.TabIndex = 6;
            this.labelMaxR1.Text = "[v]";
            this.labelMaxR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValR1
            // 
            this.labelValR1.AutoSize = true;
            this.labelValR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValR1.Location = new System.Drawing.Point(24, 0);
            this.labelValR1.Name = "labelValR1";
            this.labelValR1.Size = new System.Drawing.Size(26, 31);
            this.labelValR1.TabIndex = 5;
            this.labelValR1.Text = "[v]";
            this.labelValR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarR2
            // 
            this.trackBarR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarR2.Location = new System.Drawing.Point(56, 3);
            this.trackBarR2.Maximum = 255;
            this.trackBarR2.Name = "trackBarR2";
            this.trackBarR2.Size = new System.Drawing.Size(94, 25);
            this.trackBarR2.TabIndex = 1;
            this.trackBarR2.Scroll += new System.EventHandler(this.onColorChanged);
            // 
            // trackBarG2
            // 
            this.trackBarG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarG2.Location = new System.Drawing.Point(56, 34);
            this.trackBarG2.Maximum = 255;
            this.trackBarG2.Name = "trackBarG2";
            this.trackBarG2.Size = new System.Drawing.Size(94, 25);
            this.trackBarG2.TabIndex = 2;
            this.trackBarG2.Scroll += new System.EventHandler(this.onColorChanged);
            // 
            // trackBarB2
            // 
            this.trackBarB2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarB2.Location = new System.Drawing.Point(56, 65);
            this.trackBarB2.Maximum = 255;
            this.trackBarB2.Name = "trackBarB2";
            this.trackBarB2.Size = new System.Drawing.Size(94, 25);
            this.trackBarB2.TabIndex = 3;
            this.trackBarB2.Scroll += new System.EventHandler(this.onColorChanged);
            // 
            // labelR1
            // 
            this.labelR1.AutoSize = true;
            this.labelR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelR1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR1.Location = new System.Drawing.Point(3, 0);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(15, 31);
            this.labelR1.TabIndex = 4;
            this.labelR1.Text = "R";
            this.labelR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxLightColor
            // 
            this.groupBoxLightColor.Controls.Add(this.tableLayoutPanelLightColor);
            this.groupBoxLightColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLightColor.Location = new System.Drawing.Point(234, 103);
            this.groupBoxLightColor.Name = "groupBoxLightColor";
            this.groupBoxLightColor.Size = new System.Drawing.Size(226, 274);
            this.groupBoxLightColor.TabIndex = 2;
            this.groupBoxLightColor.TabStop = false;
            this.groupBoxLightColor.Text = "Цвет источника цвета";
            // 
            // tableLayoutPanelLightColor
            // 
            this.tableLayoutPanelLightColor.ColumnCount = 1;
            this.tableLayoutPanelLightColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLightColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLightColor.Controls.Add(this.tableLayoutPanelDirect, 0, 0);
            this.tableLayoutPanelLightColor.Controls.Add(this.tableLayoutPanelAmbient, 0, 1);
            this.tableLayoutPanelLightColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLightColor.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelLightColor.Name = "tableLayoutPanelLightColor";
            this.tableLayoutPanelLightColor.RowCount = 2;
            this.tableLayoutPanelLightColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLightColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLightColor.Size = new System.Drawing.Size(220, 255);
            this.tableLayoutPanelLightColor.TabIndex = 0;
            // 
            // tableLayoutPanelDirect
            // 
            this.tableLayoutPanelDirect.ColumnCount = 2;
            this.tableLayoutPanelDirect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.04673F));
            this.tableLayoutPanelDirect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.95327F));
            this.tableLayoutPanelDirect.Controls.Add(this.tableLayoutPanelDirectParam, 0, 1);
            this.tableLayoutPanelDirect.Controls.Add(this.labelDirect, 0, 0);
            this.tableLayoutPanelDirect.Controls.Add(this.pictureBoxDirect, 1, 1);
            this.tableLayoutPanelDirect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDirect.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelDirect.Name = "tableLayoutPanelDirect";
            this.tableLayoutPanelDirect.RowCount = 2;
            this.tableLayoutPanelDirect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.9781F));
            this.tableLayoutPanelDirect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.0219F));
            this.tableLayoutPanelDirect.Size = new System.Drawing.Size(214, 121);
            this.tableLayoutPanelDirect.TabIndex = 0;
            // 
            // tableLayoutPanelDirectParam
            // 
            this.tableLayoutPanelDirectParam.ColumnCount = 4;
            this.tableLayoutPanelDirectParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDirectParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelDirectParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDirectParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDirectParam.Controls.Add(this.labelMaxB3, 3, 2);
            this.tableLayoutPanelDirectParam.Controls.Add(this.labelValB3, 1, 2);
            this.tableLayoutPanelDirectParam.Controls.Add(this.labelB3, 0, 2);
            this.tableLayoutPanelDirectParam.Controls.Add(this.labelMaxG3, 3, 1);
            this.tableLayoutPanelDirectParam.Controls.Add(this.labelValG3, 1, 1);
            this.tableLayoutPanelDirectParam.Controls.Add(this.labelG3, 0, 1);
            this.tableLayoutPanelDirectParam.Controls.Add(this.labelMaxR3, 3, 0);
            this.tableLayoutPanelDirectParam.Controls.Add(this.labelValR3, 1, 0);
            this.tableLayoutPanelDirectParam.Controls.Add(this.labelR3, 0, 0);
            this.tableLayoutPanelDirectParam.Controls.Add(this.trackBarR3, 2, 0);
            this.tableLayoutPanelDirectParam.Controls.Add(this.trackBarG3, 2, 1);
            this.tableLayoutPanelDirectParam.Controls.Add(this.trackBarB3, 2, 2);
            this.tableLayoutPanelDirectParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDirectParam.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanelDirectParam.Name = "tableLayoutPanelDirectParam";
            this.tableLayoutPanelDirectParam.RowCount = 3;
            this.tableLayoutPanelDirectParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelDirectParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelDirectParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelDirectParam.Size = new System.Drawing.Size(176, 93);
            this.tableLayoutPanelDirectParam.TabIndex = 0;
            // 
            // labelMaxB3
            // 
            this.labelMaxB3.AutoSize = true;
            this.labelMaxB3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxB3.Location = new System.Drawing.Point(154, 62);
            this.labelMaxB3.Name = "labelMaxB3";
            this.labelMaxB3.Size = new System.Drawing.Size(19, 31);
            this.labelMaxB3.TabIndex = 13;
            this.labelMaxB3.Text = "[v]";
            this.labelMaxB3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValB3
            // 
            this.labelValB3.AutoSize = true;
            this.labelValB3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValB3.Location = new System.Drawing.Point(24, 62);
            this.labelValB3.Name = "labelValB3";
            this.labelValB3.Size = new System.Drawing.Size(26, 31);
            this.labelValB3.TabIndex = 12;
            this.labelValB3.Text = "[v]";
            this.labelValB3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelB3
            // 
            this.labelB3.AutoSize = true;
            this.labelB3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB3.Location = new System.Drawing.Point(3, 62);
            this.labelB3.Name = "labelB3";
            this.labelB3.Size = new System.Drawing.Size(15, 31);
            this.labelB3.TabIndex = 11;
            this.labelB3.Text = "B";
            this.labelB3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxG3
            // 
            this.labelMaxG3.AutoSize = true;
            this.labelMaxG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxG3.Location = new System.Drawing.Point(154, 31);
            this.labelMaxG3.Name = "labelMaxG3";
            this.labelMaxG3.Size = new System.Drawing.Size(19, 31);
            this.labelMaxG3.TabIndex = 10;
            this.labelMaxG3.Text = "[v]";
            this.labelMaxG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValG3
            // 
            this.labelValG3.AutoSize = true;
            this.labelValG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValG3.Location = new System.Drawing.Point(24, 31);
            this.labelValG3.Name = "labelValG3";
            this.labelValG3.Size = new System.Drawing.Size(26, 31);
            this.labelValG3.TabIndex = 9;
            this.labelValG3.Text = "[v]";
            this.labelValG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelG3
            // 
            this.labelG3.AutoSize = true;
            this.labelG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelG3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG3.Location = new System.Drawing.Point(3, 31);
            this.labelG3.Name = "labelG3";
            this.labelG3.Size = new System.Drawing.Size(15, 31);
            this.labelG3.TabIndex = 8;
            this.labelG3.Text = "G";
            this.labelG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxR3
            // 
            this.labelMaxR3.AutoSize = true;
            this.labelMaxR3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxR3.Location = new System.Drawing.Point(154, 0);
            this.labelMaxR3.Name = "labelMaxR3";
            this.labelMaxR3.Size = new System.Drawing.Size(19, 31);
            this.labelMaxR3.TabIndex = 7;
            this.labelMaxR3.Text = "[v]";
            this.labelMaxR3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValR3
            // 
            this.labelValR3.AutoSize = true;
            this.labelValR3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValR3.Location = new System.Drawing.Point(24, 0);
            this.labelValR3.Name = "labelValR3";
            this.labelValR3.Size = new System.Drawing.Size(26, 31);
            this.labelValR3.TabIndex = 6;
            this.labelValR3.Text = "[v]";
            this.labelValR3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelR3
            // 
            this.labelR3.AutoSize = true;
            this.labelR3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelR3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR3.Location = new System.Drawing.Point(3, 0);
            this.labelR3.Name = "labelR3";
            this.labelR3.Size = new System.Drawing.Size(15, 31);
            this.labelR3.TabIndex = 5;
            this.labelR3.Text = "R";
            this.labelR3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarR3
            // 
            this.trackBarR3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarR3.Location = new System.Drawing.Point(56, 3);
            this.trackBarR3.Maximum = 255;
            this.trackBarR3.Name = "trackBarR3";
            this.trackBarR3.Size = new System.Drawing.Size(92, 25);
            this.trackBarR3.TabIndex = 0;
            this.trackBarR3.Value = 255;
            this.trackBarR3.Scroll += new System.EventHandler(this.onColorChanged);
            // 
            // trackBarG3
            // 
            this.trackBarG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarG3.Location = new System.Drawing.Point(56, 34);
            this.trackBarG3.Maximum = 255;
            this.trackBarG3.Name = "trackBarG3";
            this.trackBarG3.Size = new System.Drawing.Size(92, 25);
            this.trackBarG3.TabIndex = 1;
            this.trackBarG3.Value = 255;
            this.trackBarG3.Scroll += new System.EventHandler(this.onColorChanged);
            // 
            // trackBarB3
            // 
            this.trackBarB3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarB3.Location = new System.Drawing.Point(56, 65);
            this.trackBarB3.Maximum = 255;
            this.trackBarB3.Name = "trackBarB3";
            this.trackBarB3.Size = new System.Drawing.Size(92, 25);
            this.trackBarB3.TabIndex = 2;
            this.trackBarB3.Value = 255;
            this.trackBarB3.Scroll += new System.EventHandler(this.onColorChanged);
            // 
            // labelDirect
            // 
            this.labelDirect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDirect.AutoSize = true;
            this.tableLayoutPanelDirect.SetColumnSpan(this.labelDirect, 2);
            this.labelDirect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirect.Location = new System.Drawing.Point(3, 0);
            this.labelDirect.Name = "labelDirect";
            this.labelDirect.Size = new System.Drawing.Size(208, 22);
            this.labelDirect.TabIndex = 1;
            this.labelDirect.Text = "Точечный";
            this.labelDirect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxDirect
            // 
            this.pictureBoxDirect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxDirect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDirect.Location = new System.Drawing.Point(185, 25);
            this.pictureBoxDirect.Name = "pictureBoxDirect";
            this.pictureBoxDirect.Size = new System.Drawing.Size(26, 93);
            this.pictureBoxDirect.TabIndex = 2;
            this.pictureBoxDirect.TabStop = false;
            // 
            // tableLayoutPanelAmbient
            // 
            this.tableLayoutPanelAmbient.ColumnCount = 2;
            this.tableLayoutPanelAmbient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.04673F));
            this.tableLayoutPanelAmbient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.95327F));
            this.tableLayoutPanelAmbient.Controls.Add(this.pictureBoxAmbient, 0, 1);
            this.tableLayoutPanelAmbient.Controls.Add(this.labelAmbient, 0, 0);
            this.tableLayoutPanelAmbient.Controls.Add(this.tableLayoutPanelAmbientParam, 0, 1);
            this.tableLayoutPanelAmbient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAmbient.Location = new System.Drawing.Point(3, 130);
            this.tableLayoutPanelAmbient.Name = "tableLayoutPanelAmbient";
            this.tableLayoutPanelAmbient.RowCount = 2;
            this.tableLayoutPanelAmbient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.84058F));
            this.tableLayoutPanelAmbient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.15942F));
            this.tableLayoutPanelAmbient.Size = new System.Drawing.Size(214, 122);
            this.tableLayoutPanelAmbient.TabIndex = 1;
            // 
            // pictureBoxAmbient
            // 
            this.pictureBoxAmbient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAmbient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAmbient.Location = new System.Drawing.Point(185, 25);
            this.pictureBoxAmbient.Name = "pictureBoxAmbient";
            this.pictureBoxAmbient.Size = new System.Drawing.Size(26, 94);
            this.pictureBoxAmbient.TabIndex = 3;
            this.pictureBoxAmbient.TabStop = false;
            // 
            // labelAmbient
            // 
            this.labelAmbient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAmbient.AutoSize = true;
            this.tableLayoutPanelAmbient.SetColumnSpan(this.labelAmbient, 2);
            this.labelAmbient.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmbient.Location = new System.Drawing.Point(3, 0);
            this.labelAmbient.Name = "labelAmbient";
            this.labelAmbient.Size = new System.Drawing.Size(208, 22);
            this.labelAmbient.TabIndex = 2;
            this.labelAmbient.Text = "Рассеянный";
            this.labelAmbient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelAmbientParam
            // 
            this.tableLayoutPanelAmbientParam.ColumnCount = 4;
            this.tableLayoutPanelAmbientParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAmbientParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelAmbientParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAmbientParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAmbientParam.Controls.Add(this.labelMaxB4, 3, 2);
            this.tableLayoutPanelAmbientParam.Controls.Add(this.labelValB4, 1, 2);
            this.tableLayoutPanelAmbientParam.Controls.Add(this.labelB4, 0, 2);
            this.tableLayoutPanelAmbientParam.Controls.Add(this.labelMaxG4, 3, 1);
            this.tableLayoutPanelAmbientParam.Controls.Add(this.labelValG4, 1, 1);
            this.tableLayoutPanelAmbientParam.Controls.Add(this.labelG4, 0, 1);
            this.tableLayoutPanelAmbientParam.Controls.Add(this.labelMaxR4, 3, 0);
            this.tableLayoutPanelAmbientParam.Controls.Add(this.labelValR4, 1, 0);
            this.tableLayoutPanelAmbientParam.Controls.Add(this.labelR4, 0, 0);
            this.tableLayoutPanelAmbientParam.Controls.Add(this.trackBarR4, 2, 0);
            this.tableLayoutPanelAmbientParam.Controls.Add(this.trackBarG4, 2, 1);
            this.tableLayoutPanelAmbientParam.Controls.Add(this.trackBarB4, 2, 2);
            this.tableLayoutPanelAmbientParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAmbientParam.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanelAmbientParam.Name = "tableLayoutPanelAmbientParam";
            this.tableLayoutPanelAmbientParam.RowCount = 3;
            this.tableLayoutPanelAmbientParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAmbientParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAmbientParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAmbientParam.Size = new System.Drawing.Size(176, 94);
            this.tableLayoutPanelAmbientParam.TabIndex = 1;
            // 
            // labelMaxB4
            // 
            this.labelMaxB4.AutoSize = true;
            this.labelMaxB4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxB4.Location = new System.Drawing.Point(154, 62);
            this.labelMaxB4.Name = "labelMaxB4";
            this.labelMaxB4.Size = new System.Drawing.Size(19, 32);
            this.labelMaxB4.TabIndex = 13;
            this.labelMaxB4.Text = "[v]";
            this.labelMaxB4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValB4
            // 
            this.labelValB4.AutoSize = true;
            this.labelValB4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValB4.Location = new System.Drawing.Point(24, 62);
            this.labelValB4.Name = "labelValB4";
            this.labelValB4.Size = new System.Drawing.Size(26, 32);
            this.labelValB4.TabIndex = 12;
            this.labelValB4.Text = "[v]";
            this.labelValB4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelB4
            // 
            this.labelB4.AutoSize = true;
            this.labelB4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB4.Location = new System.Drawing.Point(3, 62);
            this.labelB4.Name = "labelB4";
            this.labelB4.Size = new System.Drawing.Size(15, 32);
            this.labelB4.TabIndex = 11;
            this.labelB4.Text = "B";
            this.labelB4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxG4
            // 
            this.labelMaxG4.AutoSize = true;
            this.labelMaxG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxG4.Location = new System.Drawing.Point(154, 31);
            this.labelMaxG4.Name = "labelMaxG4";
            this.labelMaxG4.Size = new System.Drawing.Size(19, 31);
            this.labelMaxG4.TabIndex = 10;
            this.labelMaxG4.Text = "[v]";
            this.labelMaxG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValG4
            // 
            this.labelValG4.AutoSize = true;
            this.labelValG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValG4.Location = new System.Drawing.Point(24, 31);
            this.labelValG4.Name = "labelValG4";
            this.labelValG4.Size = new System.Drawing.Size(26, 31);
            this.labelValG4.TabIndex = 9;
            this.labelValG4.Text = "[v]";
            this.labelValG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelG4
            // 
            this.labelG4.AutoSize = true;
            this.labelG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelG4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG4.Location = new System.Drawing.Point(3, 31);
            this.labelG4.Name = "labelG4";
            this.labelG4.Size = new System.Drawing.Size(15, 31);
            this.labelG4.TabIndex = 8;
            this.labelG4.Text = "G";
            this.labelG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxR4
            // 
            this.labelMaxR4.AutoSize = true;
            this.labelMaxR4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxR4.Location = new System.Drawing.Point(154, 0);
            this.labelMaxR4.Name = "labelMaxR4";
            this.labelMaxR4.Size = new System.Drawing.Size(19, 31);
            this.labelMaxR4.TabIndex = 7;
            this.labelMaxR4.Text = "[v]";
            this.labelMaxR4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValR4
            // 
            this.labelValR4.AutoSize = true;
            this.labelValR4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValR4.Location = new System.Drawing.Point(24, 0);
            this.labelValR4.Name = "labelValR4";
            this.labelValR4.Size = new System.Drawing.Size(26, 31);
            this.labelValR4.TabIndex = 6;
            this.labelValR4.Text = "[v]";
            this.labelValR4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelR4
            // 
            this.labelR4.AutoSize = true;
            this.labelR4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelR4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR4.Location = new System.Drawing.Point(3, 0);
            this.labelR4.Name = "labelR4";
            this.labelR4.Size = new System.Drawing.Size(15, 31);
            this.labelR4.TabIndex = 5;
            this.labelR4.Text = "R";
            this.labelR4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarR4
            // 
            this.trackBarR4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarR4.Location = new System.Drawing.Point(56, 3);
            this.trackBarR4.Maximum = 255;
            this.trackBarR4.Name = "trackBarR4";
            this.trackBarR4.Size = new System.Drawing.Size(92, 25);
            this.trackBarR4.TabIndex = 0;
            this.trackBarR4.Value = 255;
            this.trackBarR4.Scroll += new System.EventHandler(this.onColorChanged);
            // 
            // trackBarG4
            // 
            this.trackBarG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarG4.Location = new System.Drawing.Point(56, 34);
            this.trackBarG4.Maximum = 255;
            this.trackBarG4.Name = "trackBarG4";
            this.trackBarG4.Size = new System.Drawing.Size(92, 25);
            this.trackBarG4.TabIndex = 1;
            this.trackBarG4.Value = 255;
            this.trackBarG4.Scroll += new System.EventHandler(this.onColorChanged);
            // 
            // trackBarB4
            // 
            this.trackBarB4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarB4.Location = new System.Drawing.Point(56, 65);
            this.trackBarB4.Maximum = 255;
            this.trackBarB4.Name = "trackBarB4";
            this.trackBarB4.Size = new System.Drawing.Size(92, 26);
            this.trackBarB4.TabIndex = 2;
            this.trackBarB4.Value = 255;
            this.trackBarB4.Scroll += new System.EventHandler(this.onColorChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 622);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №2 Выполнила Нугманова А.Е.";
            this.ClientSizeChanged += new System.EventHandler(this.onDrawChanged);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelParam.ResumeLayout(false);
            this.groupBoxLightSource.ResumeLayout(false);
            this.tableLayoutPanelLightSource.ResumeLayout(false);
            this.tableLayoutPanelLightSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZLight)).EndInit();
            this.groupBoxShape.ResumeLayout(false);
            this.tableLayoutPanelShape.ResumeLayout(false);
            this.tableLayoutPanelShape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDV)).EndInit();
            this.groupBoxRotate.ResumeLayout(false);
            this.tableLayoutPanelRotate.ResumeLayout(false);
            this.tableLayoutPanelRotate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            this.groupBoxLightParam.ResumeLayout(false);
            this.tableLayoutPanelLightParam.ResumeLayout(false);
            this.tableLayoutPanelLightParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbientLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDiffuseLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpecularLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPower)).EndInit();
            this.tableLayoutPanelDraw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            this.tableLayoutPanelFill.ResumeLayout(false);
            this.groupBoxFillMethod.ResumeLayout(false);
            this.groupBoxFillMethod.PerformLayout();
            this.groupBoxFillColor.ResumeLayout(false);
            this.tableLayoutPanelFillColor.ResumeLayout(false);
            this.tableLayoutPanelFillColorInternal.ResumeLayout(false);
            this.tableLayoutPanelFillColorInternal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIntern)).EndInit();
            this.tableLayoutPanelFillColorInternalParam.ResumeLayout(false);
            this.tableLayoutPanelFillColorInternalParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB1)).EndInit();
            this.tableLayoutPanelFillColorExternal.ResumeLayout(false);
            this.tableLayoutPanelFillColorExternal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtern)).EndInit();
            this.tableLayoutPanelFillColorExternalParam.ResumeLayout(false);
            this.tableLayoutPanelFillColorExternalParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB2)).EndInit();
            this.groupBoxLightColor.ResumeLayout(false);
            this.tableLayoutPanelLightColor.ResumeLayout(false);
            this.tableLayoutPanelDirect.ResumeLayout(false);
            this.tableLayoutPanelDirect.PerformLayout();
            this.tableLayoutPanelDirectParam.ResumeLayout(false);
            this.tableLayoutPanelDirectParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDirect)).EndInit();
            this.tableLayoutPanelAmbient.ResumeLayout(false);
            this.tableLayoutPanelAmbient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmbient)).EndInit();
            this.tableLayoutPanelAmbientParam.ResumeLayout(false);
            this.tableLayoutPanelAmbientParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelParam;
        private System.Windows.Forms.GroupBox groupBoxShape;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelShape;
        private System.Windows.Forms.Label labelU;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelDU;
        private System.Windows.Forms.Label labelDV;
        private System.Windows.Forms.Label labelValU;
        private System.Windows.Forms.Label labelValV;
        private System.Windows.Forms.Label labelValA;
        private System.Windows.Forms.Label labelValDU;
        private System.Windows.Forms.Label labelValDV;
        private System.Windows.Forms.Label labelMinU;
        private System.Windows.Forms.Label labelMinV;
        private System.Windows.Forms.Label labelMinA;
        private System.Windows.Forms.Label labelMinDU;
        private System.Windows.Forms.Label labelMinDV;
        private System.Windows.Forms.Label labelMaxU;
        private System.Windows.Forms.Label labelMaxV;
        private System.Windows.Forms.Label labelMaxA;
        private System.Windows.Forms.Label labelMaxDU;
        private System.Windows.Forms.Label labelMaxDV;
        private System.Windows.Forms.TrackBar trackBarU;
        private System.Windows.Forms.TrackBar trackBarV;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarDU;
        private System.Windows.Forms.TrackBar trackBarDV;
        private System.Windows.Forms.GroupBox groupBoxRotate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRotate;
        private System.Windows.Forms.Label labelMaxZ;
        private System.Windows.Forms.Label labelMinZ;
        private System.Windows.Forms.Label labelValZ;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelMaxY;
        private System.Windows.Forms.Label labelMinY;
        private System.Windows.Forms.Label labelValY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelMaxX;
        private System.Windows.Forms.Label labelMinX;
        private System.Windows.Forms.Label labelValX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDraw;
        private System.Windows.Forms.PictureBox pictureBoxDraw;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFill;
        private System.Windows.Forms.GroupBox groupBoxFillMethod;
        private System.Windows.Forms.CheckBox checkBoxPolyZSort;
        private System.Windows.Forms.RadioButton radioButtonFlatFrame;
        private System.Windows.Forms.RadioButton radioButtonWireframe;
        private System.Windows.Forms.GroupBox groupBoxFillColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFillColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFillColorInternal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFillColorInternalParam;
        private System.Windows.Forms.Label labelValB2;
        private System.Windows.Forms.Label labelB2;
        private System.Windows.Forms.Label labelR2;
        private System.Windows.Forms.Label labelValR2;
        private System.Windows.Forms.Label labelMaxR2;
        private System.Windows.Forms.Label labelG2;
        private System.Windows.Forms.Label labelValG2;
        private System.Windows.Forms.Label labelMaxG2;
        private System.Windows.Forms.Label labelMaxB2;
        private System.Windows.Forms.RadioButton radioButtonGouraudShading;
        private System.Windows.Forms.RadioButton radioButtonPhongShading;
        private System.Windows.Forms.RadioButton radioButtonFlatHLSRFrame;
        private System.Windows.Forms.GroupBox groupBoxLightColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLightColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDirect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAmbient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDirectParam;
        private System.Windows.Forms.TrackBar trackBarR3;
        private System.Windows.Forms.TrackBar trackBarG3;
        private System.Windows.Forms.TrackBar trackBarB3;
        private System.Windows.Forms.Label labelMaxB3;
        private System.Windows.Forms.Label labelValB3;
        private System.Windows.Forms.Label labelB3;
        private System.Windows.Forms.Label labelMaxG3;
        private System.Windows.Forms.Label labelValG3;
        private System.Windows.Forms.Label labelG3;
        private System.Windows.Forms.Label labelMaxR3;
        private System.Windows.Forms.Label labelValR3;
        private System.Windows.Forms.Label labelR3;
        private System.Windows.Forms.Label labelDirect;
        private System.Windows.Forms.PictureBox pictureBoxDirect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAmbientParam;
        private System.Windows.Forms.Label labelMaxB4;
        private System.Windows.Forms.Label labelValB4;
        private System.Windows.Forms.Label labelB4;
        private System.Windows.Forms.Label labelMaxG4;
        private System.Windows.Forms.Label labelValG4;
        private System.Windows.Forms.Label labelG4;
        private System.Windows.Forms.Label labelMaxR4;
        private System.Windows.Forms.Label labelValR4;
        private System.Windows.Forms.Label labelR4;
        private System.Windows.Forms.TrackBar trackBarR4;
        private System.Windows.Forms.TrackBar trackBarG4;
        private System.Windows.Forms.TrackBar trackBarB4;
        private System.Windows.Forms.PictureBox pictureBoxAmbient;
        private System.Windows.Forms.Label labelAmbient;
        private System.Windows.Forms.GroupBox groupBoxLightParam;
        private System.Windows.Forms.GroupBox groupBoxLightSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLightSource;
        private System.Windows.Forms.Label labelMaxZLight;
        private System.Windows.Forms.Label labelMinZLight;
        private System.Windows.Forms.Label labelValZLight;
        private System.Windows.Forms.Label labelZLight;
        private System.Windows.Forms.Label labelMaxYLight;
        private System.Windows.Forms.Label labelMinYLight;
        private System.Windows.Forms.Label labelValYLight;
        private System.Windows.Forms.Label labelYLight;
        private System.Windows.Forms.Label labelMaxXLight;
        private System.Windows.Forms.Label labelMinXLight;
        private System.Windows.Forms.Label labelValXLight;
        private System.Windows.Forms.Label labelXLight;
        private System.Windows.Forms.TrackBar trackBarXLight;
        private System.Windows.Forms.TrackBar trackBarYLight;
        private System.Windows.Forms.TrackBar trackBarZLight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLightParam;
        private System.Windows.Forms.Label labelAmbientLight;
        private System.Windows.Forms.Label labelDiffuseLight;
        private System.Windows.Forms.Label labelMaxPower;
        private System.Windows.Forms.Label labelMaxSpecularLight;
        private System.Windows.Forms.Label labelMaxDiffuseLight;
        private System.Windows.Forms.Label labelMaxAmbientLight;
        private System.Windows.Forms.Label labelMinDiffuseLight;
        private System.Windows.Forms.Label labelMinSpecularLight;
        private System.Windows.Forms.Label labelValPower;
        private System.Windows.Forms.Label labelMinPower;
        private System.Windows.Forms.Label labelMinAmbientLight;
        private System.Windows.Forms.Label labelValSpecularLight;
        private System.Windows.Forms.Label labelValDiffuseLight;
        private System.Windows.Forms.Label labelValAmbientLight;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelSpecularLight;
        private System.Windows.Forms.TrackBar trackBarAmbientLight;
        private System.Windows.Forms.TrackBar trackBarDiffuseLight;
        private System.Windows.Forms.TrackBar trackBarSpecularLight;
        private System.Windows.Forms.TrackBar trackBarPower;
        private System.Windows.Forms.PictureBox pictureBoxIntern;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFillColorExternal;
        private System.Windows.Forms.PictureBox pictureBoxExtern;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFillColorExternalParam;
        private System.Windows.Forms.Label labelMaxG1;
        private System.Windows.Forms.Label labelValG1;
        private System.Windows.Forms.Label labelG1;
        private System.Windows.Forms.Label labelMaxR1;
        private System.Windows.Forms.Label labelValR1;
        private System.Windows.Forms.Label labelR1;
        private System.Windows.Forms.Label labelInternal;
        private System.Windows.Forms.Label labelExternal;
        private System.Windows.Forms.TrackBar trackBarR1;
        private System.Windows.Forms.TrackBar trackBarG1;
        private System.Windows.Forms.TrackBar trackBarB1;
        private System.Windows.Forms.Label labelMaxB1;
        private System.Windows.Forms.Label labelValB1;
        private System.Windows.Forms.Label labelB1;
        private System.Windows.Forms.TrackBar trackBarR2;
        private System.Windows.Forms.TrackBar trackBarG2;
        private System.Windows.Forms.TrackBar trackBarB2;
    }
}

