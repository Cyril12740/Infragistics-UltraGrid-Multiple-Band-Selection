using Infragistics.Win.UltraWinGrid;

namespace TestGrilleEvenementWinforms
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Evenement", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Title");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Company");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DateTime");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Evenements");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Image", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.RowLayout rowLayout1 = new Infragistics.Win.UltraWinGrid.RowLayout("fdsgd");
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo1 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Title", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo2 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Company", -1, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo3 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DateTime", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo4 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Evenements", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo5 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Image", -1, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Evenements", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Title");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Company");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DateTime");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Image");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.ultraGrid1 = new MultipleBandSelectionUltraGrid();
            this.evenementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGrid1
            // 
            this.ultraGrid1.DataSource = this.evenementBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGrid1.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            ultraGridColumn1.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            ultraGridColumn1.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            ultraGridColumn1.AutoEditMode = Infragistics.Win.DefaultableBoolean.False;
            ultraGridColumn1.AutoSizeEdit = Infragistics.Win.DefaultableBoolean.False;
            ultraGridColumn1.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.MaxWidth = 200;
            ultraGridColumn1.Width = 200;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 298;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 200;
            ultraGridColumn4.Header.VisiblePosition = 4;
            ultraGridColumn5.Header.VisiblePosition = 3;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5});
            ultraGridBand1.GroupHeadersVisible = false;
            ultraGridBand1.Override.CellPadding = 5;
            ultraGridBand1.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay;
            ultraGridBand1.Override.HeaderPlacement = Infragistics.Win.UltraWinGrid.HeaderPlacement.FixedOnTop;
            rowLayout1.ColumnInfos.AddRange(new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo[] {
            rowLayoutColumnInfo1,
            rowLayoutColumnInfo2,
            rowLayoutColumnInfo3,
            rowLayoutColumnInfo4,
            rowLayoutColumnInfo5});
            ultraGridBand1.RowLayouts.AddRange(new Infragistics.Win.UltraWinGrid.RowLayout[] {
            rowLayout1});
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn6.Header.VisiblePosition = 0;
            ultraGridColumn7.Header.VisiblePosition = 1;
            ultraGridColumn8.Header.VisiblePosition = 2;
            ultraGridColumn8.Width = 200;
            ultraGridColumn9.Header.VisiblePosition = 3;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9});
            ultraGridBand2.Header.Enabled = false;
            ultraGridBand2.Override.CellPadding = 5;
            ultraGridBand2.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay;
            this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.ultraGrid1.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            this.ultraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid1.DisplayLayout.Override.AutoEditMode = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGrid1.DisplayLayout.Override.CellAppearance = appearance8;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ultraGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.ultraGrid1.DisplayLayout.Override.RowAppearance = appearance11;
            this.ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGrid1.Location = new System.Drawing.Point(0, 0);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(800, 450);
            this.ultraGrid1.TabIndex = 0;
            this.ultraGrid1.Text = "ultraGrid1";
            this.ultraGrid1.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.ultraGrid1_InitializeRow);
            // 
            // evenementBindingSource
            // 
            this.evenementBindingSource.DataSource = typeof(TestGrilleEvenement.Data.Evenement);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ultraGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MultipleBandSelectionUltraGrid ultraGrid1;
        private System.Windows.Forms.BindingSource evenementBindingSource;
    }
}

