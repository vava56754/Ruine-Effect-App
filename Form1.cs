using RuneEffect;
using System.Data;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace RuneEffect
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            pictureBoxInput1.Tag = 8;
            pictureBoxInput2.Tag = 9;
            rune1.Tag = 1;
            rune2.Tag = 2;
            rune3.Tag = 3;
            rune4.Tag = 4;
            rune5.Tag = 5;
            rune6.Tag = 6;
            this.Controls.Add(pictureBoxInput1);
            this.Controls.Add(pictureBoxInput2);

            listViewStock.View = View.Details;
            listViewStock1.View = View.Details;
            listViewStock.Columns.Add("Ruin 1", 50);
            listViewStock.Columns.Add("", 20);

            listViewStock1.Columns.Add("Ruin 2", 50);
            listViewStock1.Columns.Add("", 20);
            listViewStock1.Columns.Add("numero", 50);


        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rune1_Click(object sender, EventArgs e)
        {
            manageRune(rune1);
        }

        private void rune2_Click(object sender, EventArgs e)
        {
            manageRune(rune2);
        }

        private void rune3_Click(object sender, EventArgs e)
        {
            manageRune(rune3);
        }

        private void rune4_Click(object sender, EventArgs e)
        {
            manageRune(rune4);
        }

        private void rune5_Click(object sender, EventArgs e)
        {
            manageRune(rune5);
        }

        private void rune6_Click(object sender, EventArgs e)
        {
            manageRune(rune6);
        }

        private void enter_Click(object sender, EventArgs e)
        {
            resultRune();
        }

        private void back_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void pictureBoxInput1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxInput2_Click(object sender, EventArgs e)
        {

        }

        private void manageRune(PictureBox rune)
        {
            if (pictureBoxInput1.Image == null)
            {
                pictureBoxInput1.Image = rune.Image;
                pictureBoxInput1.Tag = rune.Tag;
            }
            else
            {
                pictureBoxInput2.Image = rune.Image;
                pictureBoxInput2.Tag = rune.Tag;
            }
        }

        private void reset()
        {
            if (pictureBoxInput2.Image != null)
            {
                pictureBoxInput2.Image = null;
                pictureBoxInput2.Tag = 9;
            }
            else
            {
                pictureBoxInput1.Image = null;
                pictureBoxInput1.Tag = 8;
            }
            result.Text = "";
        }

        private void loadPicture()
        {

        }

        private void stockCalcul(string result, int index1, int index2)
        {
            int imageIndex1 = 0;
            int imageIndex2 = 1;

            ImageList images = new ImageList();
            Image image1 = Properties.Resources._1feu_petit;
            Image image2 = Properties.Resources._2eau_petit;
            Image image3 = Properties.Resources._3vent_petit;
            Image image4 = Properties.Resources._4terre_petit;
            Image image5 = Properties.Resources._5dark_petit;
            Image image6 = Properties.Resources._6light_petit;
            images.Images.Add(image1);
            images.Images.Add(image2);
            images.Images.Add(image3);
            images.Images.Add(image4);
            images.Images.Add(image5);
            images.Images.Add(image6);
            listViewStock.SmallImageList = images;
            listViewStock1.SmallImageList = images;




            ListViewItem item1 = new ListViewItem();
            item1.ImageIndex = index1 - 1;
            item1.SubItems.Add("+");


            ListViewItem item2 = new ListViewItem();
            item2.ImageIndex = index2 - 1;
            item2.SubItems.Add("=");
            item2.SubItems.Add(result);




            listViewStock.Items.Add(item1);
            listViewStock1.Items.Add(item2);
        }

        private void resultRune()
        {
            if (pictureBoxInput2.Image != null && pictureBoxInput1.Image != null)
            {
                int imageDisplay1Id = (int)pictureBoxInput1.Tag;
                int imageDisplay2Id = (int)pictureBoxInput2.Tag;


                switch (imageDisplay1Id)
                {
                    case 1:
                        switch (imageDisplay2Id)
                        {
                            case 1:
                                result.Text = "1";
                                break;
                            case 2:
                                result.Text = "7";
                                break;
                            case 3:
                                result.Text = "13";
                                break;
                            case 4:
                                result.Text = "19";
                                break;
                            case 5:
                                result.Text = "25";
                                break;
                            case 6:
                                result.Text = "31";
                                break;
                        }
                        break;

                    case 2:
                        switch (imageDisplay2Id)
                        {
                            case 1:
                                result.Text = "2";
                                break;
                            case 2:
                                result.Text = "8";
                                break;
                            case 3:
                                result.Text = "14";
                                break;
                            case 4:
                                result.Text = "20";
                                break;
                            case 5:
                                result.Text = "26";
                                break;
                            case 6:
                                result.Text = "32";
                                break;
                        }
                        break;

                    case 3:
                        switch (imageDisplay2Id)
                        {
                            case 1:
                                result.Text = "3";
                                break;
                            case 2:
                                result.Text = "9";
                                break;
                            case 3:
                                result.Text = "15";
                                break;
                            case 4:
                                result.Text = "21";
                                break;
                            case 5:
                                result.Text = "27";
                                break;
                            case 6:
                                result.Text = "33";
                                break;
                        }
                        break;

                    case 4:
                        switch (imageDisplay2Id)
                        {
                            case 1:
                                result.Text = "4";
                                break;
                            case 2:
                                result.Text = "10";
                                break;
                            case 3:
                                result.Text = "16";
                                break;
                            case 4:
                                result.Text = "22";
                                break;
                            case 5:
                                result.Text = "28";
                                break;
                            case 6:
                                result.Text = "34";
                                break;
                        }
                        break;

                    case 5:
                        switch (imageDisplay2Id)
                        {
                            case 1:
                                result.Text = "5";
                                break;
                            case 2:
                                result.Text = "11";
                                break;
                            case 3:
                                result.Text = "17";
                                break;
                            case 4:
                                result.Text = "23";
                                break;
                            case 5:
                                result.Text = "29";
                                break;
                            case 6:
                                result.Text = "35";
                                break;
                        }
                        break;

                    case 6:
                        switch (imageDisplay2Id)
                        {
                            case 1:
                                result.Text = "6";
                                break;
                            case 2:
                                result.Text = "12";
                                break;
                            case 3:
                                result.Text = "18";
                                break;
                            case 4:
                                result.Text = "24";
                                break;
                            case 5:
                                result.Text = "30";
                                break;
                            case 6:
                                result.Text = "36";
                                break;
                        }
                        break;
                }
                stockCalcul(result.Text, imageDisplay1Id, imageDisplay2Id);
            }


        }

        private void listViewStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
