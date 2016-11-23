using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace filtersource
{
  public class MainForm : Form
  {
    private IContainer components = (IContainer) null;
    private Button about;
    private Button exit;
    private PictureBox pictureBox1;
    private TextBox fleetguardfilter;
    private Label label9;
    private TextBox atlascopcofilter;
    private Label label8;
    private TextBox compairfilter;
    private Label label7;
    private TextBox dynapacfilter;
    private TextBox donaldsonfilter;
    private TextBox rycofilter;
    private TextBox caterpillarfilter;
    private TextBox perkinsfilter;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Button findbutton;
    private TextBox textBox1;

    public MainForm()
    {
      this.InitializeComponent();
      this.infoToolTip();
      if (File.Exists("database.dat"))
        this.Text = "Filtersource 1.2Beta POC Database date stamp " + new StreamReader("database.dat").ReadLine();
      else if (MessageBox.Show("Database file not found Filtersource will now close", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
        Environment.Exit(0);
    }

    private void infoToolTip()
    {
      new ToolTip().SetToolTip((Control) this.textBox1, "Please type in filter part number EXACTLY as shown on filter");
    }

    private void ExitClick(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void AboutClick(object sender, EventArgs e)
    {
      new aboutform().Show();
    }

    private void FindbuttonClick(object sender, EventArgs e)
    {
      StreamReader streamReader = new StreamReader("database.dat");
      string str;
      while ((str = streamReader.ReadLine()) != null)
      {
        if (str.Contains("|" + this.textBox1.Text + "|"))
        {
          string[] strArray = str.Split('|');
          this.perkinsfilter.Text = strArray[1];
          this.caterpillarfilter.Text = strArray[2];
          this.rycofilter.Text = strArray[3];
          this.donaldsonfilter.Text = strArray[4];
          this.dynapacfilter.Text = strArray[5];
          this.compairfilter.Text = strArray[6];
          this.atlascopcofilter.Text = strArray[7];
          this.fleetguardfilter.Text = strArray[8];
          this.textBox1.Clear();
          this.textBox1.Focus();
          break;
        }
        if (str.Contains("|END OF FILE|"))
        {
          int num = (int) MessageBox.Show("Sorry but no filter with that part-number exists in DataBase", "No listing found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.textBox1.Clear();
          this.textBox1.Focus();
        }
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MainForm));
      this.textBox1 = new TextBox();
      this.findbutton = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label6 = new Label();
      this.perkinsfilter = new TextBox();
      this.caterpillarfilter = new TextBox();
      this.rycofilter = new TextBox();
      this.donaldsonfilter = new TextBox();
      this.dynapacfilter = new TextBox();
      this.label7 = new Label();
      this.compairfilter = new TextBox();
      this.label8 = new Label();
      this.atlascopcofilter = new TextBox();
      this.label9 = new Label();
      this.fleetguardfilter = new TextBox();
      this.pictureBox1 = new PictureBox();
      this.exit = new Button();
      this.about = new Button();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.textBox1.CharacterCasing = CharacterCasing.Upper;
      this.textBox1.Location = new Point(199, 173);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(279, 22);
      this.textBox1.TabIndex = 0;
      this.findbutton.Location = new Point(484, 173);
      this.findbutton.Name = "findbutton";
      this.findbutton.Size = new Size(143, 22);
      this.findbutton.TabIndex = 1;
      this.findbutton.Text = "Find";
      this.findbutton.UseVisualStyleBackColor = true;
      this.findbutton.Click += new EventHandler(this.FindbuttonClick);
      this.label1.Location = new Point(12, 173);
      this.label1.Name = "label1";
      this.label1.Size = new Size(181, 22);
      this.label1.TabIndex = 2;
      this.label1.Text = "Please type filter number";
      this.label2.Location = new Point(12, 210);
      this.label2.Name = "label2";
      this.label2.Size = new Size(181, 22);
      this.label2.TabIndex = 3;
      this.label2.Text = "Perkins";
      this.label3.Location = new Point(199, 210);
      this.label3.Name = "label3";
      this.label3.Size = new Size(181, 22);
      this.label3.TabIndex = 4;
      this.label3.Text = "Caterpillar";
      this.label4.Location = new Point(386, 210);
      this.label4.Name = "label4";
      this.label4.Size = new Size(181, 22);
      this.label4.TabIndex = 5;
      this.label4.Text = "Ryco";
      this.label5.Location = new Point(573, 210);
      this.label5.Name = "label5";
      this.label5.Size = new Size(181, 22);
      this.label5.TabIndex = 6;
      this.label5.Text = "Donaldson";
      this.label6.Location = new Point(12, 290);
      this.label6.Name = "label6";
      this.label6.Size = new Size(181, 22);
      this.label6.TabIndex = 7;
      this.label6.Text = "Dynapac";
      this.perkinsfilter.Location = new Point(12, 235);
      this.perkinsfilter.Name = "perkinsfilter";
      this.perkinsfilter.ReadOnly = true;
      this.perkinsfilter.Size = new Size(181, 22);
      this.perkinsfilter.TabIndex = 8;
      this.caterpillarfilter.Location = new Point(199, 235);
      this.caterpillarfilter.Name = "caterpillarfilter";
      this.caterpillarfilter.ReadOnly = true;
      this.caterpillarfilter.Size = new Size(181, 22);
      this.caterpillarfilter.TabIndex = 9;
      this.rycofilter.Location = new Point(386, 235);
      this.rycofilter.Name = "rycofilter";
      this.rycofilter.ReadOnly = true;
      this.rycofilter.Size = new Size(181, 22);
      this.rycofilter.TabIndex = 10;
      this.donaldsonfilter.Location = new Point(573, 235);
      this.donaldsonfilter.Name = "donaldsonfilter";
      this.donaldsonfilter.ReadOnly = true;
      this.donaldsonfilter.Size = new Size(181, 22);
      this.donaldsonfilter.TabIndex = 11;
      this.dynapacfilter.Location = new Point(12, 315);
      this.dynapacfilter.Name = "dynapacfilter";
      this.dynapacfilter.ReadOnly = true;
      this.dynapacfilter.Size = new Size(181, 22);
      this.dynapacfilter.TabIndex = 12;
      this.label7.Location = new Point(199, 290);
      this.label7.Name = "label7";
      this.label7.Size = new Size(181, 22);
      this.label7.TabIndex = 13;
      this.label7.Text = "Compair";
      this.compairfilter.Location = new Point(199, 315);
      this.compairfilter.Name = "compairfilter";
      this.compairfilter.ReadOnly = true;
      this.compairfilter.Size = new Size(181, 22);
      this.compairfilter.TabIndex = 14;
      this.label8.Location = new Point(386, 290);
      this.label8.Name = "label8";
      this.label8.Size = new Size(181, 22);
      this.label8.TabIndex = 15;
      this.label8.Text = "Atlascopco";
      this.atlascopcofilter.Location = new Point(386, 315);
      this.atlascopcofilter.Name = "atlascopcofilter";
      this.atlascopcofilter.ReadOnly = true;
      this.atlascopcofilter.Size = new Size(181, 22);
      this.atlascopcofilter.TabIndex = 16;
      this.label9.Location = new Point(573, 290);
      this.label9.Name = "label9";
      this.label9.Size = new Size(181, 22);
      this.label9.TabIndex = 17;
      this.label9.Text = "Fleetguard";
      this.fleetguardfilter.Location = new Point(573, 315);
      this.fleetguardfilter.Name = "fleetguardfilter";
      this.fleetguardfilter.ReadOnly = true;
      this.fleetguardfilter.Size = new Size(181, 22);
      this.fleetguardfilter.TabIndex = 18;
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.InitialImage = (Image) null;
      this.pictureBox1.Location = new Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(753, 155);
      this.pictureBox1.TabIndex = 19;
      this.pictureBox1.TabStop = false;
      this.exit.Location = new Point(611, 353);
      this.exit.Name = "exit";
      this.exit.Size = new Size(143, 22);
      this.exit.TabIndex = 20;
      this.exit.Text = "Exit";
      this.exit.UseVisualStyleBackColor = true;
      this.exit.Click += new EventHandler(this.ExitClick);
      this.about.Location = new Point(462, 353);
      this.about.Name = "about";
      this.about.Size = new Size(143, 22);
      this.about.TabIndex = 21;
      this.about.Text = "About";
      this.about.UseVisualStyleBackColor = true;
      this.about.Click += new EventHandler(this.AboutClick);
      this.AcceptButton = (IButtonControl) this.findbutton;
      this.AutoScaleMode = AutoScaleMode.None;
      this.ClientSize = new Size(777, 383);
      this.Controls.Add((Control) this.about);
      this.Controls.Add((Control) this.exit);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.fleetguardfilter);
      this.Controls.Add((Control) this.label9);
      this.Controls.Add((Control) this.atlascopcofilter);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.compairfilter);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.dynapacfilter);
      this.Controls.Add((Control) this.donaldsonfilter);
      this.Controls.Add((Control) this.rycofilter);
      this.Controls.Add((Control) this.caterpillarfilter);
      this.Controls.Add((Control) this.perkinsfilter);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.findbutton);
      this.Controls.Add((Control) this.textBox1);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Filter Source  0.1A";
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
