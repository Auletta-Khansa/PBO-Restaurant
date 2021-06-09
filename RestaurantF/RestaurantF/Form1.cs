using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbBanana.Text = "0";
            tbChoco.Text = "0";
            tbCoffee.Text = "0";
            tbForest.Text = "0";
            tbGreen.Text = "0";
            tbOreo.Text = "0";
            tbStrawberry.Text = "0";
            tbTaro.Text = "0";
            tbVanilla.Text = "0";
            tbVelvet.Text = "0";
            lblMakanan.Text = "0";
            lblMinuman.Text = "0";
            lblService.Text = "0.05";
            lblTax.Text = "0";
            lblSubtotal.Text = "0";
            lblTotal.Text = "0"; 

            cbBanana.Checked = false;
            cbChoco.Checked = false;
            cbCoffee.Checked = false;
            cbForest.Checked = false;
            cbGreen.Checked = false;
            cbOreo.Checked = false;
            cbStrawberry.Checked = false;
            cbTaro.Checked = false;
            cbVanilla.Checked = false;
            cbVelvet.Checked = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            tbBanana.Text = "0";
            tbChoco.Text = "0";
            tbCoffee.Text = "0";
            tbForest.Text = "0";
            tbGreen.Text = "0";
            tbOreo.Text = "0";
            tbStrawberry.Text = "0";
            tbTaro.Text = "0";
            tbVanilla.Text = "0";
            tbVelvet.Text = "0";
            lblMakanan.Text = "0";
            lblMinuman.Text = "0";
            lblService.Text = "0.05";
            lblTax.Text = "0";
            lblSubtotal.Text = "0";
            lblTotal.Text = "0"; 

            tbChoco.Enabled = false;
            tbStrawberry.Enabled = false;
            tbBanana.Enabled = false;
            tbOreo.Enabled = false;
            tbTaro.Enabled = false;
            tbCoffee.Enabled = false;
            tbVanilla.Enabled = false;
            tbVelvet.Enabled = false;
            tbGreen.Enabled = false;
            tbForest.Enabled = false;

            cbBanana.Checked = false;
            cbChoco.Checked = false;
            cbCoffee.Checked = false;
            cbForest.Checked = false;
            cbGreen.Checked = false;
            cbOreo.Checked = false;
            cbStrawberry.Checked = false;
            cbTaro.Checked = false;
            cbVanilla.Checked = false;
            cbVelvet.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbChoco_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChoco.Checked == true)
            {
                tbChoco.Enabled = true;
            }

            if (cbChoco.Checked == false)
            {
                tbChoco.Enabled = false;
                tbChoco.Text = "0";
            }
        }

        private void tbChoco_Click(object sender, EventArgs e)
        {
            tbChoco.Text = "";
            tbChoco.Focus();
        }

        private void cbStrawberry_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStrawberry.Checked == true)
            {
                tbStrawberry.Enabled = true;
            }

            if (cbStrawberry.Checked == false)
            {
                tbStrawberry.Enabled = false;
                tbStrawberry.Text = "0";
            }
        }

        private void tbStrawberry_Click(object sender, EventArgs e)
        {
            tbStrawberry.Text = "";
            tbStrawberry.Focus();
        }

        private void cbBanana_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBanana.Checked == true)
            {
                tbBanana.Enabled = true;
            }

            if (cbBanana.Checked == false)
            {
                tbBanana.Enabled = false;
                tbBanana.Text = "0";
            }
        }

        private void tbBanana_Click(object sender, EventArgs e)
        {
            tbBanana.Text = "";
            tbBanana.Focus();
        }

        private void cbOreo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOreo.Checked == true)
            {
                tbOreo.Enabled = true;
            }

            if (cbOreo.Checked == false)
            {
                tbOreo.Enabled = false;
                tbOreo.Text = "0";
            }
        }

        private void tbOreo_Click(object sender, EventArgs e)
        {
            tbOreo.Text = "";
            tbOreo.Focus();
        }

        private void cbTaro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTaro.Checked == true)
            {
                tbTaro.Enabled = true;
            }

            if (cbTaro.Checked == false)
            {
                tbTaro.Enabled = false;
                tbTaro.Text = "0";
            }
        }

        private void tbTaro_Click(object sender, EventArgs e)
        {
            tbTaro.Text = "";
            tbTaro.Focus();
        }

        private void cbCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCoffee.Checked == true)
            {
                tbCoffee.Enabled = true;
            }

            if (cbCoffee.Checked == false)
            {
                tbCoffee.Enabled = false;
                tbCoffee.Text = "0";
            }
        }

        private void tbCoffee_Click(object sender, EventArgs e)
        {
            tbCoffee.Text = "";
            tbCoffee.Focus();
        }

        private void cbVanilla_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVanilla.Checked == true)
            {
                tbVanilla.Enabled = true;
            }

            if (cbVanilla.Checked == false)
            {
                tbVanilla.Enabled = false;
                tbVanilla.Text = "0";
            }
        }

        private void tbVanilla_Click(object sender, EventArgs e)
        {
            tbVanilla.Text = "";
            tbVanilla.Focus();
        }

        private void cbVelvet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVelvet.Checked == true)
            {
                tbVelvet.Enabled = true;
            }

            if (cbVelvet.Checked == false)
            {
                tbVelvet.Enabled = false;
                tbVelvet.Text = "0";
            }
        }

        private void tbVelvet_Click(object sender, EventArgs e)
        {
            tbVelvet.Text = "";
            tbVelvet.Focus();
        }

        private void cbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGreen.Checked == true)
            {
                tbGreen.Enabled = true;
            }

            if (cbGreen.Checked == false)
            {
                tbGreen.Enabled = false;
                tbGreen.Text = "0";
            }
        }

        private void tbGreen_Click(object sender, EventArgs e)
        {
            tbGreen.Text = "";
            tbGreen.Focus();
        }

        private void cbForest_CheckedChanged(object sender, EventArgs e)
        {
            if (cbForest.Checked == true)
            {
                tbForest.Enabled = true;
            }

            if (cbForest.Checked == false)
            {
                tbForest.Enabled = false;
                tbForest.Text = "0";
            }
        }

        private void tbForest_Click(object sender, EventArgs e)
        {
            tbForest.Text = "";
            tbForest.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rbReceipt.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rbReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rbReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rbReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rbReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rbReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rbReceipt.Text);
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rbReceipt.Clear();

            rbReceipt.AppendText(Environment.NewLine);
            rbReceipt.AppendText("----------------------------------------------" + Environment.NewLine);
            rbReceipt.AppendText("\t" + "Kittendust Restaurant" + Environment.NewLine);
            rbReceipt.AppendText("----------------------------------------------" + Environment.NewLine);

            rbReceipt.AppendText("Choco Crepes \t\t" + tbChoco.Text + Environment.NewLine);
            rbReceipt.AppendText("Strawberry Crepes \t\t" + tbStrawberry.Text + Environment.NewLine);
            rbReceipt.AppendText("Banana Crepes \t\t" + tbBanana.Text + Environment.NewLine);
            rbReceipt.AppendText("Oreo Crepes \t\t\t" + tbOreo.Text + Environment.NewLine);
            rbReceipt.AppendText("Taro Crepes \t\t\t" + tbTaro.Text + Environment.NewLine);

            rbReceipt.AppendText("Coffee Latte \t\t\t" + tbCoffee.Text + Environment.NewLine);
            rbReceipt.AppendText("Vanilla Latte \t\t\t" + tbVanilla.Text + Environment.NewLine);
            rbReceipt.AppendText("Red Velvet Latte \t\t" + tbVelvet.Text + Environment.NewLine);
            rbReceipt.AppendText("Green Tea Latte \t\t" + tbGreen.Text + Environment.NewLine);
            rbReceipt.AppendText("Black Forest Latte \t\t" + tbForest.Text + Environment.NewLine);

            rbReceipt.AppendText("----------------------------------------------" + Environment.NewLine);
            rbReceipt.AppendText("Service Charge \t" + lblService.Text + Environment.NewLine);
            rbReceipt.AppendText("Tax \t\t\t" + lblTax.Text + Environment.NewLine);
            rbReceipt.AppendText("Subtotal \t\t" + lblSubtotal.Text + Environment.NewLine);
            rbReceipt.AppendText("Total \t\t\t" + lblTotal.Text + Environment.NewLine);
            rbReceipt.AppendText("----------------------------------------------" + Environment.NewLine);
            rbReceipt.AppendText(lblTime.Text + "\t" + lblDate.Text);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double tax;
            tax = 10;
            double ChocoC, StrawberryC, BananaC, OreoC, TaroC;
            double CoffeeL, VanillaL, VelvetL, GreenL, ForestL;

            ChocoC = 5250; StrawberryC = 6300; BananaC = 6300; OreoC = 7350; TaroC = 7350;
            double Choco_Crepes = Convert.ToDouble(tbChoco.Text);
            double Strawberry_Crepes = Convert.ToDouble(tbStrawberry.Text);
            double Banana_Crepes = Convert.ToDouble(tbBanana.Text);
            double Oreo_Crepes = Convert.ToDouble(tbOreo.Text);
            double Taro_Crepes = Convert.ToDouble(tbTaro.Text);

            CoffeeL = 12600; VanillaL = 12600; VelvetL = 15750; GreenL = 15750; ForestL = 15750;
            double Coffee_Latte = Convert.ToDouble(tbCoffee.Text);
            double Vanilla_Latte = Convert.ToDouble(tbVanilla.Text);
            double Velvet_Latte = Convert.ToDouble(tbVelvet.Text);
            double Green_Latte = Convert.ToDouble(tbGreen.Text);
            double Forest_Latte = Convert.ToDouble(tbForest.Text);

            Resto dine_in = new Resto(Choco_Crepes, Strawberry_Crepes, Banana_Crepes, Oreo_Crepes, Taro_Crepes,
                Coffee_Latte, Vanilla_Latte, Velvet_Latte, Green_Latte, Forest_Latte);

            double total_makanan = (Choco_Crepes * ChocoC) + (Strawberry_Crepes * StrawberryC) + (Banana_Crepes * BananaC)
                + (Oreo_Crepes * OreoC) + (Taro_Crepes * TaroC);
            lblMakanan.Text = Convert.ToString(total_makanan);

            double total_minuman = (Coffee_Latte * CoffeeL) + (Vanilla_Latte * VanillaL) + (Velvet_Latte * VelvetL)
                + (Green_Latte * GreenL) + (Forest_Latte * ForestL);
            lblMinuman.Text = Convert.ToString(total_minuman);

            double service = Convert.ToDouble(lblService.Text);

            lblSubtotal.Text = Convert.ToString(total_makanan + total_minuman);
            lblTax.Text = Convert.ToString(((total_makanan + total_minuman + service) * tax)/100);
            double iTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(total_makanan + total_minuman + service + iTax);

        }
    }
}
