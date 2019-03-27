namespace TestWinForm.UI
{
    partial class Form_Plan
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("通识必修");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("通识选修");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("通识教育课", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("专业核心课");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("专业选修课");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("其他专业核心课");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("实践教学环节");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("其他专业实践必修课");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("第二课堂");
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 417);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点8";
            treeNode1.Text = "通识必修";
            treeNode2.Name = "节点10";
            treeNode2.Text = "通识选修";
            treeNode3.Name = "节点通识";
            treeNode3.Text = "通识教育课";
            treeNode4.Name = "节点专业核心";
            treeNode4.Text = "专业核心课";
            treeNode5.Name = "节点专选";
            treeNode5.Text = "专业选修课";
            treeNode6.Name = "节点其他专核";
            treeNode6.Text = "其他专业核心课";
            treeNode7.Name = "节点实践";
            treeNode7.Text = "实践教学环节";
            treeNode8.Name = "节点其他实践";
            treeNode8.Text = "其他专业实践必修课";
            treeNode9.Name = "节点第二课堂";
            treeNode9.Text = "第二课堂";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(812, 417);
            this.treeView1.TabIndex = 0;
            // 
            // Form_Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 441);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Plan";
            this.Text = "培养方案";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
    }
}