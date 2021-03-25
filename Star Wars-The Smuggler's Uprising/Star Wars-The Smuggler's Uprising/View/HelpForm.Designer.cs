namespace TheGame
{
    partial class HelpForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Сюжет");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Правила");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Карты");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Пазаак", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Гробницы Коррибана");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Руины Дантуина");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Раскопки", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Анклав джедаев");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Академия ситхов");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Пункты сдачи", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Нар-Шаддаа");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Нал-Хатта");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Коррибан");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Дантуин");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Татуин");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Планеты", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Орден джедаев");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Орден ситхов");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Картель Хаттов");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Организация \"Обмен\"");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Фракции", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Горячие клавиши");
            this.helpMenuView = new System.Windows.Forms.TreeView();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // helpMenuView
            // 
            this.helpMenuView.Dock = System.Windows.Forms.DockStyle.Left;
            this.helpMenuView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpMenuView.Location = new System.Drawing.Point(0, 0);
            this.helpMenuView.Name = "helpMenuView";
            treeNode1.Name = "Node2";
            treeNode1.Tag = "0";
            treeNode1.Text = "Сюжет";
            treeNode2.Name = "Node4";
            treeNode2.Tag = "1";
            treeNode2.Text = "Правила";
            treeNode3.Name = "Node5";
            treeNode3.Tag = "2";
            treeNode3.Text = "Карты";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Пазаак";
            treeNode5.Name = "Node7";
            treeNode5.Tag = "3";
            treeNode5.Text = "Гробницы Коррибана";
            treeNode6.Name = "Node8";
            treeNode6.Tag = "4";
            treeNode6.Text = "Руины Дантуина";
            treeNode7.Name = "Node6";
            treeNode7.Text = "Раскопки";
            treeNode8.Name = "Node11";
            treeNode8.Tag = "5";
            treeNode8.Text = "Анклав джедаев";
            treeNode9.Name = "Node10";
            treeNode9.Tag = "6";
            treeNode9.Text = "Академия ситхов";
            treeNode10.Name = "Node9";
            treeNode10.Text = "Пункты сдачи";
            treeNode11.Name = "Node14";
            treeNode11.Tag = "7";
            treeNode11.Text = "Нар-Шаддаа";
            treeNode12.Name = "Node13";
            treeNode12.Tag = "8";
            treeNode12.Text = "Нал-Хатта";
            treeNode13.Name = "Node15";
            treeNode13.Tag = "9";
            treeNode13.Text = "Коррибан";
            treeNode14.Name = "Node16";
            treeNode14.Tag = "10";
            treeNode14.Text = "Дантуин";
            treeNode15.Name = "Node17";
            treeNode15.Tag = "11";
            treeNode15.Text = "Татуин";
            treeNode16.Name = "Node12";
            treeNode16.Text = "Планеты";
            treeNode17.Name = "Node1";
            treeNode17.Tag = "13";
            treeNode17.Text = "Орден джедаев";
            treeNode18.Name = "Node2";
            treeNode18.Tag = "14";
            treeNode18.Text = "Орден ситхов";
            treeNode19.Name = "Node4";
            treeNode19.Tag = "15";
            treeNode19.Text = "Картель Хаттов";
            treeNode20.Name = "Node3";
            treeNode20.Tag = "16";
            treeNode20.Text = "Организация \"Обмен\"";
            treeNode21.Name = "Node0";
            treeNode21.Text = "Фракции";
            treeNode22.Name = "Node18";
            treeNode22.Tag = "12";
            treeNode22.Text = "Горячие клавиши";
            this.helpMenuView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode7,
            treeNode10,
            treeNode16,
            treeNode21,
            treeNode22});
            this.helpMenuView.Size = new System.Drawing.Size(306, 630);
            this.helpMenuView.TabIndex = 0;
            this.helpMenuView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.helpMenuView_NodeMouseDoubleClick);
            // 
            // infoBox
            // 
            this.infoBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.infoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBox.Location = new System.Drawing.Point(377, 0);
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(528, 630);
            this.infoBox.TabIndex = 1;
            this.infoBox.Text = "";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(905, 630);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.helpMenuView);
            this.MaximumSize = new System.Drawing.Size(921, 669);
            this.MinimumSize = new System.Drawing.Size(648, 669);
            this.Name = "HelpForm";
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView helpMenuView;
        private System.Windows.Forms.RichTextBox infoBox;
    }
}