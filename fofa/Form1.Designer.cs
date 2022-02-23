
namespace fofa
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_key = new System.Windows.Forms.TextBox();
            this.tb_proxy = new System.Windows.Forms.TextBox();
            this.cb_remember = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_result = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.host = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.protocol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.domain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.server = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_keyword = new System.Windows.Forms.ListBox();
            this.btn_cancelall = new System.Windows.Forms.Button();
            this.btn_adds = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_keyword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sleepTime = new System.Windows.Forms.Label();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.tb_timeSleep = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_proxy = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号邮箱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "API Key";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(95, 18);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(220, 25);
            this.tb_email.TabIndex = 2;
            this.tb_email.Text = "xxx@xx.com";
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(95, 61);
            this.tb_key.Margin = new System.Windows.Forms.Padding(4);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(220, 25);
            this.tb_key.TabIndex = 3;
            this.tb_key.Text = "xxxxxxxxxxxxxxxxxx";
            // 
            // tb_proxy
            // 
            this.tb_proxy.Location = new System.Drawing.Point(393, 61);
            this.tb_proxy.Name = "tb_proxy";
            this.tb_proxy.Size = new System.Drawing.Size(196, 25);
            this.tb_proxy.TabIndex = 5;
            this.tb_proxy.Text = "127.0.0.1:8080";
            // 
            // cb_remember
            // 
            this.cb_remember.AutoSize = true;
            this.cb_remember.Location = new System.Drawing.Point(627, 20);
            this.cb_remember.Margin = new System.Windows.Forms.Padding(4);
            this.cb_remember.Name = "cb_remember";
            this.cb_remember.Size = new System.Drawing.Size(89, 19);
            this.cb_remember.TabIndex = 6;
            this.cb_remember.Text = "保存配置";
            this.cb_remember.UseVisualStyleBackColor = true;
            this.cb_remember.CheckedChanged += new System.EventHandler(this.cb_remember_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(765, 24);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(147, 55);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(947, 24);
            this.btn_export.Margin = new System.Windows.Forms.Padding(4);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(129, 55);
            this.btn_export.TabIndex = 9;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_result);
            this.groupBox1.Controls.Add(this.lb_keyword);
            this.groupBox1.Controls.Add(this.btn_cancelall);
            this.groupBox1.Controls.Add(this.btn_adds);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.tb_keyword);
            this.groupBox1.Location = new System.Drawing.Point(8, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1361, 608);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lv_result
            // 
            this.lv_result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.host,
            this.ip,
            this.port,
            this.protocol,
            this.domain,
            this.title,
            this.server});
            this.lv_result.FullRowSelect = true;
            this.lv_result.GridLines = true;
            this.lv_result.HideSelection = false;
            this.lv_result.Location = new System.Drawing.Point(279, 22);
            this.lv_result.Margin = new System.Windows.Forms.Padding(4);
            this.lv_result.Name = "lv_result";
            this.lv_result.Size = new System.Drawing.Size(1077, 574);
            this.lv_result.TabIndex = 5;
            this.lv_result.UseCompatibleStateImageBehavior = false;
            this.lv_result.View = System.Windows.Forms.View.Details;
            this.lv_result.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_result_ColumnClick);
            this.lv_result.SelectedIndexChanged += new System.EventHandler(this.lv_result_SelectedIndexChanged);
            this.lv_result.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_result_MouseClick);
            this.lv_result.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_result_MouseDoubleClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 76;
            // 
            // host
            // 
            this.host.Text = "Host";
            this.host.Width = 137;
            // 
            // ip
            // 
            this.ip.Text = "IP";
            this.ip.Width = 150;
            // 
            // port
            // 
            this.port.Text = "Port";
            // 
            // protocol
            // 
            this.protocol.Text = "Protocol";
            this.protocol.Width = 100;
            // 
            // domain
            // 
            this.domain.Text = "Domain";
            this.domain.Width = 150;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 150;
            // 
            // server
            // 
            this.server.Text = "Server";
            this.server.Width = 100;
            // 
            // lb_keyword
            // 
            this.lb_keyword.FormattingEnabled = true;
            this.lb_keyword.ItemHeight = 15;
            this.lb_keyword.Location = new System.Drawing.Point(13, 82);
            this.lb_keyword.Margin = new System.Windows.Forms.Padding(4);
            this.lb_keyword.Name = "lb_keyword";
            this.lb_keyword.Size = new System.Drawing.Size(249, 514);
            this.lb_keyword.TabIndex = 4;
            this.lb_keyword.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_keyword_MouseDoubleClick);
            // 
            // btn_cancelall
            // 
            this.btn_cancelall.Location = new System.Drawing.Point(143, 52);
            this.btn_cancelall.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelall.Name = "btn_cancelall";
            this.btn_cancelall.Size = new System.Drawing.Size(121, 28);
            this.btn_cancelall.TabIndex = 3;
            this.btn_cancelall.Text = "全部取消";
            this.btn_cancelall.UseVisualStyleBackColor = true;
            this.btn_cancelall.Click += new System.EventHandler(this.btn_cancelall_Click);
            // 
            // btn_adds
            // 
            this.btn_adds.Location = new System.Drawing.Point(12, 52);
            this.btn_adds.Margin = new System.Windows.Forms.Padding(4);
            this.btn_adds.Name = "btn_adds";
            this.btn_adds.Size = new System.Drawing.Size(121, 28);
            this.btn_adds.TabIndex = 2;
            this.btn_adds.Text = "批量添加";
            this.btn_adds.UseVisualStyleBackColor = true;
            this.btn_adds.Click += new System.EventHandler(this.btn_adds_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(235, 21);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(31, 26);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_keyword
            // 
            this.tb_keyword.Location = new System.Drawing.Point(13, 21);
            this.tb_keyword.Margin = new System.Windows.Forms.Padding(4);
            this.tb_keyword.Name = "tb_keyword";
            this.tb_keyword.Size = new System.Drawing.Size(207, 25);
            this.tb_keyword.TabIndex = 0;
            this.tb_keyword.Text = "domain=\"qq.com\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "数量";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // sleepTime
            // 
            this.sleepTime.AutoSize = true;
            this.sleepTime.Location = new System.Drawing.Point(472, 24);
            this.sleepTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sleepTime.Name = "sleepTime";
            this.sleepTime.Size = new System.Drawing.Size(69, 15);
            this.sleepTime.TabIndex = 12;
            this.sleepTime.Text = "延时(/s)";
            // 
            // tb_size
            // 
            this.tb_size.Location = new System.Drawing.Point(394, 18);
            this.tb_size.Margin = new System.Windows.Forms.Padding(4);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(60, 25);
            this.tb_size.TabIndex = 13;
            this.tb_size.Text = "10";
            this.tb_size.TextChanged += new System.EventHandler(this.tb_size_TextChanged);
            // 
            // tb_timeSleep
            // 
            this.tb_timeSleep.Location = new System.Drawing.Point(549, 18);
            this.tb_timeSleep.Margin = new System.Windows.Forms.Padding(4);
            this.tb_timeSleep.Name = "tb_timeSleep";
            this.tb_timeSleep.Size = new System.Drawing.Size(40, 25);
            this.tb_timeSleep.TabIndex = 14;
            this.tb_timeSleep.Text = "0";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(9, 705);
            this.pb.Margin = new System.Windows.Forms.Padding(4);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(1359, 20);
            this.pb.Step = 1;
            this.pb.TabIndex = 16;
            this.pb.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.复制ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 52);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hostToolStripMenuItem,
            this.iPPortToolStripMenuItem,
            this.domainToolStripMenuItem});
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // hostToolStripMenuItem
            // 
            this.hostToolStripMenuItem.Name = "hostToolStripMenuItem";
            this.hostToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.hostToolStripMenuItem.Text = "Host";
            this.hostToolStripMenuItem.Click += new System.EventHandler(this.hostToolStripMenuItem_Click);
            // 
            // iPPortToolStripMenuItem
            // 
            this.iPPortToolStripMenuItem.Name = "iPPortToolStripMenuItem";
            this.iPPortToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.iPPortToolStripMenuItem.Text = "IP:Port";
            this.iPPortToolStripMenuItem.Click += new System.EventHandler(this.iPPortToolStripMenuItem_Click);
            // 
            // domainToolStripMenuItem
            // 
            this.domainToolStripMenuItem.Name = "domainToolStripMenuItem";
            this.domainToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.domainToolStripMenuItem.Text = "Domain";
            this.domainToolStripMenuItem.Click += new System.EventHandler(this.domainToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "代理";
            // 
            // cb_proxy
            // 
            this.cb_proxy.AutoSize = true;
            this.cb_proxy.Location = new System.Drawing.Point(627, 63);
            this.cb_proxy.Margin = new System.Windows.Forms.Padding(4);
            this.cb_proxy.Name = "cb_proxy";
            this.cb_proxy.Size = new System.Drawing.Size(89, 19);
            this.cb_proxy.TabIndex = 18;
            this.cb_proxy.Text = "启用代理";
            this.cb_proxy.UseVisualStyleBackColor = true;
            this.cb_proxy.CheckedChanged += new System.EventHandler(this.cb_proxy_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 730);
            this.Controls.Add(this.cb_proxy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.tb_timeSleep);
            this.Controls.Add(this.tb_size);
            this.Controls.Add(this.sleepTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cb_remember);
            this.Controls.Add(this.tb_proxy);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Fofa搜索工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.CheckBox cb_remember;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_keyword;
        private System.Windows.Forms.ListBox lb_keyword;
        private System.Windows.Forms.Button btn_cancelall;
        private System.Windows.Forms.Button btn_adds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sleepTime;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.TextBox tb_timeSleep;
        private System.Windows.Forms.ListView lv_result;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader host;
        private System.Windows.Forms.ColumnHeader ip;
        private System.Windows.Forms.ColumnHeader port;
        private System.Windows.Forms.ColumnHeader domain;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader server;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domainToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader protocol;
        private System.Windows.Forms.TextBox tb_proxy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_proxy;
    }
}

