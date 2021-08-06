/*======================================================================|
|                                                                       |
|  Notice!!! This one .cs file basically handles 99% of the operations, |
|  including Randomization. This isn't clean. You have been warned.     |
|                                                                       |
|                               ~ C#-Learning Programmer                |
|                                                                       |
|======================================================================*/

using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SBK64Randomizer
{
    public partial class Form1 : Form
    {
        public bool randomizeAble;
        public bool exitProgram;
        string filename;
        bool y = false;
        int z = 0;
        public Form1()
        {
            exitProgram = y;
            randomizeAble = y;
            bool activeMenu = false;
            InitializeComponent();
            readTheSettingsFileInitiate();

            if (activeMenu == false)
            {
                comboBox1.Enabled = false;
                //comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                //comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
                //comboBox8.Enabled = false;
                comboBox9.Enabled = false;
                //checkBox1.Enabled = false;
                //checkBox2.Enabled = false;
                //checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                //checkBox11.Enabled = false;
                checkBox12.Enabled = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }                                   //No active use
        private void button1_Click(object sender, EventArgs e)            //Initiate Randomization | TODO: Actually Randomize the game.
                                                                          //Implement the checksum calculator.
        {
            bool activeMenu = false;

            if (activeMenu == false)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox9.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
            }

            richTextBox1.Clear();
            int comboBox1Value = comboBox1.SelectedIndex;
            richTextBox1.Text = comboBox1Value.ToString() + "\n";

            trackCoin();                            //In progress
            weaponShops();             //N/A
            specialShops();            //N/A
            racers();                  //N/A
            racerBoards();             //N/A
            boardColors();             //N/A
            shotGameSnowmen();         //N/A
            speedGameFans();           //N/A
            trickGameUnlocks();         //N/A
            misc();                    //N/A

            //Randomization Ends Here

            //CRC Checksum Fix Ends Here | TODO: CRC Checksum fix implementation.

            //Save ROM ends here.


        }                                //No active use
        private void button2_Click(object sender, EventArgs v)
        {
            saveTheSettingsFile();
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }                                //No active use
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }                     //No active use
        private void openFileDialog1_FileOk(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            if (filename != null)
            {
                //comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                //comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                /*comboBox5.Enabled = true;
                comboBox6.Enabled = true;
                comboBox7.Enabled = true;
                comboBox8.Enabled = true;
                comboBox9.Enabled = true;*/
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                /*checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                checkBox10.Enabled = true;*/
                checkBox11.Enabled = true;
                //checkBox12.Enabled = true;
                if (randomizeAble)
                {
                    button1.Enabled = true;
                }
                else if (filename == null)
                {
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox5.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox7.Enabled = false;
                    checkBox8.Enabled = false;
                    checkBox9.Enabled = false;
                    checkBox10.Enabled = false;
                    checkBox11.Enabled = false;
                    checkBox12.Enabled = false;
                }
            }
            //byte[] readfile = File.ReadAllBytes(filename);
            //string readFileString = BitConverter.ToString(readfile);
            //richTextBox1.Text = readFileString;
        }
        private void saveFileDialog1_FileOk(object sender, EventArgs e)
        {

        }                       //No active use
        private void saveFileDialog2_FileOk(object sender, EventArgs e)
        {

        }                       //No active use
        private void exitMenuItem(object sender, EventArgs e)
        {
            Form2 popup = new Form2();
            if (filename != null)
            {
                DialogResult dialogResult = popup.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                popup.Dispose();
            }
            else
            {
                this.Close();
            }
        }

        //Setting File Reading
        public void readTheSettingsFileInitiate()
        {
            int a = z;
            int b = z;
            int c = z;
            int d = z;
            int e = z;
            int f = z;
            int g = z;
            int h = z;
            int i = z;
            bool j = y;
            bool k = y;
            bool l = y;
            bool m = y;
            bool n = y;
            bool o = y;
            bool p = y;
            bool q = y;
            bool r = y;
            bool s = y;
            bool t = y;
            bool u = y;
            var path = "settings.sbkconfig";
            if (!File.Exists(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("000ddd000ffffffffffff\n\nThe numbers if edited, can only be 0-2\nThe letters signify true or false.\n\nNOTICE! Removing any letters/numbers\non the first line will ultimately break your settings file! To make a new one or fix it, use this format... 000ddd000ffffffffffff\n\n0 ~ Can be 0-2.\nd ~ Can be d or e.\nf ~ Can be f or t.");
                using (FileStream fs = new FileStream("settings.sbkconfig", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    File.WriteAllBytes(path, info);
                    fs.Close();
                }
            }
            if (File.Exists(path))
            {
                readTheSettingsFileInt(path, ref a, ref b, ref c, ref g, ref h, ref i);
                readTheSettingsFileBool(path, ref d, ref e, ref f, ref j, ref k, ref l, ref m, ref n, ref o, ref p, ref q, ref r, ref s, ref t, ref u);
            }

                comboBox1.SelectedIndex = 0;    //Track coins.      0-2         a

            comboBox2.SelectedIndex = d;    //Racers            0-1

                comboBox3.SelectedIndex = 0;    //Weapon Shops      0-2         b

            comboBox4.SelectedIndex = e;    //Racer's Boards    0-1

                comboBox5.SelectedIndex = 0;    //Shot Game Snowmen 0-2         c
                comboBox6.SelectedIndex = 0;    //Speed Game Fans   0-2         g
                comboBox7.SelectedIndex = 0;    //Special Shops     0-2         h
                comboBox8.SelectedIndex = 0;    //Board Colors      0-1         f
                comboBox9.SelectedIndex = 0;    //Trick Game        0-2         i

            checkBox1.Checked = j;
            checkBox2.Checked = k;
            checkBox3.Checked = l;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            canRandomize();
        }
        public void readTheSettingsFileInt(string path, ref int a, ref int b, ref int c, ref int g, ref int h, ref int i)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                char[] ch = new char[9];
                a = sr.Read(ch, 0, 1);
                if (a > 2)
                {
                    a = 2;
                }
                b = sr.Read(ch, 1, 1);
                if (b > 2)
                {
                    b = 2;
                }
                c = sr.Read(ch, 2, 1);
                if (c > 2)
                {
                    c = 2;
                }
                g = sr.Read(ch, 6, 1);
                if (g > 2)
                {
                    g = 2;
                }
                h = sr.Read(ch, 7, 1);
                if (h > 2)
                {
                    h = 2;
                }
                i = sr.Read(ch, 8, 1);
                if (i > 2)
                {
                    i = 2;
                }
            }
        }
        public void readTheSettingsFileBool(string path, ref int d, ref int e, ref int f, ref bool j, ref bool k, ref bool l, ref bool m, ref bool n, ref bool o, ref bool p, ref bool q, ref bool r, ref bool s, ref bool t, ref bool u)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                int intCheck;
                string intToString;
                char[] ch = new char[21];
                intCheck = sr.Read(ch, 3, 1);
                intToString = intCheck.ToString();
                if (intToString == "e")
                {
                    d = 1;
                }
                else
                {
                    d = 0;
                }
                intCheck = sr.Read(ch, 4, 1);
                intToString = intCheck.ToString();
                if (intToString == "e")
                {
                    e = 1;
                }
                else
                {
                    e = 0;
                }
                intCheck = sr.Read(ch, 5, 1);
                intToString = intCheck.ToString();
                if (intToString == "e")
                {
                    f = 1;
                }
                else
                {
                    f = 0;
                }
                intCheck = sr.Read(ch, 9, 1);
                intToString = intCheck.ToString();
                if (intToString == "t")
                {
                    j = true;
                }
                else
                {
                    j = false;
                }
                intCheck = sr.Read(ch, 10, 1);
                intToString = intCheck.ToString();
                if (intToString == "t")
                {
                    k = true;
                }
                else
                {
                    k = false;
                }
                intCheck = sr.Read(ch, 11, 1);
                intToString = intCheck.ToString();
                if (intToString == "t")
                {
                    l = true;
                }
                else
                {
                    l = false;
                }
                intCheck = sr.Read(ch, 12, 1);
                intToString = intCheck.ToString();
                if (intToString == "t")
                {
                    m = true;
                }
                else
                {
                    m = false;
                }
                intCheck = sr.Read(ch, 13, 1);
                intToString = intCheck.ToString();
                if (intToString == "t")
                {
                    n = true;
                }
                else
                {
                    n = false;
                }
                intCheck = sr.Read(ch, 14, 1);
                intToString = intCheck.ToString();
                if (intToString == "t")
                {
                    o = true;
                }
                else
                {
                    o = false;
                }
                intCheck = sr.Read(ch, 15, 1);
                intToString = intCheck.ToString();
                if (intToString == "t")
                {
                    p = true;
                }
                else
                {
                    p = false;
                }
                intCheck = sr.Read(ch, 16, 1);
                intToString = intCheck.ToString();
                if (intToString == "t")
                {
                    q = true;
                }
                else
                {
                    q = false;
                }
                intCheck = sr.Read(ch, 17, 1);
                intToString = intCheck.ToString();
                if (intToString == "t")
                {
                    r = true;
                }
                else
                {
                    r = false;
                }
                intCheck = sr.Read(ch, 18, 1);
                intToString = intCheck.ToString();
                if (intToString == "t")
                {
                    s = true;
                }
                else
                {
                    s = false;
                }
                intCheck = sr.Read(ch, 19, 1);
                intToString = intCheck.ToString();
                if (intToString == "t")
                {
                    t = true;
                }
                else
                {
                    t = false;
                }
                intCheck = sr.Read(ch, 20, 1);
                intToString = intCheck.ToString();
                if (intToString == "t")
                {
                    u = true;
                }
                else
                {
                    u = false;
                }
            }
        }
        public void saveTheSettingsFile()
        {
            var a = comboBox1.SelectedIndex;    //Track coins.      0-2
            var d = comboBox2.SelectedIndex;    //Racers            0-1
            var b = comboBox3.SelectedIndex;    //Weapon Shops      0-2
            var e = comboBox4.SelectedIndex;    //Racer's Boards    0-1
            var c = comboBox5.SelectedIndex;    //Shot Game Snowmen 0-2
            var g = comboBox6.SelectedIndex;    //Speed Game Fans   0-2
            var h = comboBox7.SelectedIndex;    //Special Shops     0-2
            var f = comboBox8.SelectedIndex;    //Board Colors      0-1
            var i = comboBox9.SelectedIndex;    //Trick Game        0-2
            var j = checkBox1.Checked;
            var k = checkBox1.Checked;
            var l = checkBox1.Checked;
            var m = checkBox1.Checked;
            var n = checkBox1.Checked;
            var o = checkBox1.Checked;
            var p = checkBox1.Checked;
            var q = checkBox1.Checked;
            var r = checkBox1.Checked;
            var s = checkBox1.Checked;
            var t = checkBox1.Checked;
            var u = checkBox1.Checked;
            string sd = "d";
            string se = "d";
            string sf = "d";
            string sj;
            string sk;
            string sl;
            string sm;
            string sn;
            string so;
            string sp;
            string sq;
            string sr;
            string ss;
            string st;
            string su;

            if (d < 0 || d > 1)
            {
                Random rng = new Random();
                d = rng.Next(0, 2);
            }
            if (d == 1)
            {
                sd = "e";
            }
            if (d == 0)
            {
                sd = "d";
            }

            if (e < 0 || e > 1)
            {
                Random rng = new Random();
                e = rng.Next(0, 1);
            }
            if (e == 1)
            {
                se = "e";
            }
            if (e == 0)
            {
                se = "d";
            }

            if (f < 0 || f > 1)
            {
                Random rng = new Random();
                f = rng.Next(0, 1);
            }
            if (f == 1)
            {
                sf = "e";
            }
            if (f == 0)
            {
                sf = "d";
            }

            if (j == true)
            {
                sj = "t";
            }
            else
            {
                sj = "f";
            }
            if (k == true)
            {
                sk = "t";
            }
            else
            {
                sk = "f";
            }
            if (l == true)
            {
                sl = "t";
            }
            else
            {
                sl = "f";
            }
            if (m == true)
            {
                sm = "t";
            }
            else
            {
                sm = "f";
            }
            if (n == true)
            {
                sn = "t";
            }
            else
            {
                sn = "f";
            }
            if (o == true)
            {
                so = "t";
            }
            else
            {
                so = "f";
            }
            if (p == true)
            {
                sp = "t";
            }
            else
            {
                sp = "f";
            }
            if (q == true)
            {
                sq = "t";
            }
            else
            {
                sq = "f";
            }
            if (r == true)
            {
                sr = "t";
            }
            else
            {
                sr = "f";
            }
            if (s == true)
            {
                ss = "t";
            }
            else
            {
                ss = "f";
            }
            if (t == true)
            {
                st = "t";
            }
            else
            {
                st = "f";
            }
            if (u == true)
            {
                su = "t";
            }
            else
            {
                su = "f";
            }
            var path = "settings.sbkconfig";
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(a + b + c + sd + se + sf + g + h + i + sj + sk + sl + sm + sn + so + sp + sq + sr + ss + st + su + "\n\nThe numbers if edited, can only be 0-2\nThe letters signify true or false.\n\nNOTICE! Removing any letters/numbers\non the first line will ultimately break your settings file! To make a new one or fix it, use this format... 000ddd000ffffffffffff\n\n0 ~ Can be 0-2.\nd ~ Can be d or e.\nf ~ Can be f or t.");
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
        }
        //Setting File Reading

        //Can Randomize Boolean
        public void canRandomize()
        {
            if (!randomizeAble)
            {
                randomizeAble = true;
            }
        }
        //Can Randomize Boolean

        //Randomization Buffers
        public void trackCoin()
        {
            int a;
            if (comboBox1.SelectedIndex != 0)
            {
                richTextBox1.Text += "Track Coins = ENABLED\n";
                if (comboBox1.SelectedIndex > 2 || comboBox1.SelectedIndex < 0)
                {
                    richTextBox1.Text += "Randomizing track coin setting selection.\n";
                    Random rng = new Random();
                    comboBox1.SelectedIndex = rng.Next(0, 2);
                }
            }
            if (comboBox1.SelectedIndex == 0)
            {
                richTextBox1.Text += "Track Coins = VANILLA | Not Randomized\n";
                return;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                richTextBox1.Text += "Track Coins = BASIC\n";
                a = 0;
                trackCoinRandomization(a);
                return;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                richTextBox1.Text += "Track Coins = SPORADIC\n";
                a = 1;
                trackCoinRandomization(a);
            }
        }                       //Somewhat done.
        public void weaponShops()
        {
            int a = 0;
            if (comboBox3.SelectedIndex != 0)
            {
                richTextBox1.Text += "Weapon Shops = ENABLED\n";
                if (comboBox3.SelectedIndex > 2 || comboBox3.SelectedIndex < 0)
                {
                    richTextBox1.Text += "Randomizing weapon shop setting selection.\n";
                    Random rng = new Random();
                    comboBox3.SelectedIndex = rng.Next(0, 2);
                }
            }
            if (comboBox3.SelectedIndex == 0)
            {
                richTextBox1.Text += "Weapon Shops = VANILLA | Not Randomized\n";
                return;
            }
            if (comboBox3.SelectedIndex == 1)
            {
                richTextBox1.Text += "Weapon Shops = BASIC\n";
                a = 0;
                weaponShopsRandomization(a);
                return;
            }
            if (comboBox3.SelectedIndex == 2)
            {
                richTextBox1.Text += "Weapon Shops = SPORADIC\n";
                a = 1;
                weaponShopsRandomization(a);
            }
        }                     //Somewhat done.
        public void specialShops()
        {
            int a = 0;
            if (comboBox7.SelectedIndex != 0)
            {
                richTextBox1.Text += "Special Shops = ENABLED\n";
                if (comboBox7.SelectedIndex > 2 || comboBox7.SelectedIndex < 0)
                {
                    richTextBox1.Text += "Randomizing special shop setting selection.\n";
                    Random rng = new Random();
                    comboBox7.SelectedIndex = rng.Next(0, 2);
                }
            }
            if (comboBox7.SelectedIndex == 0)
            {
                richTextBox1.Text += "Special Shops = VANILLA | Not Randomized\n";
                return;
            }
            if (comboBox7.SelectedIndex == 1)
            {
                richTextBox1.Text += "Special Shops = BASIC\n";
                a = 0;
                specialShopsRandomization(a);
                return;
            }
            if (comboBox7.SelectedIndex == 2)
            {
                richTextBox1.Text += "Special Shops = SPORADIC\n";
                a = 1;
                specialShopsRandomization(a);
            }
        }                    //Somewhat done.
        public void racers()
        {
            bool sinobin;
            bool duplicates;

            if (comboBox2.SelectedIndex != 0)
            {
                richTextBox1.Text += "Racer Randomization = ENABLED\n";
                if (comboBox2.SelectedIndex > 1 || comboBox2.SelectedIndex < 0)
                {
                    richTextBox1.Text += "Randomizing racers setting selection.\n";
                    Random rng = new Random();
                    comboBox2.SelectedIndex = rng.Next(0, 1);
                }
            }
            if (comboBox2.SelectedIndex == 0)
            {
                richTextBox1.Text += "Racers = VANILLA | Not Randomized\n";
                return;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                richTextBox1.Text += "Racers = ENABLED\n";
                if (checkBox1.Checked)
                {
                    sinobin = true;
                    richTextBox1.Text += "Sinobin Randomized\n";
                }
                else
                {
                    sinobin = false;
                }
                if (checkBox2.Checked)
                {
                    duplicates = true;
                    richTextBox1.Text += "Duplicate NPCs possible.\n";
                }
                else
                {
                    duplicates = false;
                }
                racersRandomization(sinobin, duplicates);
            }
        }                          //Somewhat done.
        public void racerBoards()
        {
            bool fair;

            if (comboBox4.SelectedIndex != 0)
            {
                richTextBox1.Text += "Racer's Board Randomization = ENABLED\n";
                if (comboBox4.SelectedIndex > 1 || comboBox4.SelectedIndex < 0)
                {
                    richTextBox1.Text += "Randomizing racer's board setting selection.\n";
                    Random rng = new Random();
                    comboBox4.SelectedIndex = rng.Next(0, 1);
                }
            }
            if (comboBox4.SelectedIndex == 0)
            {
                richTextBox1.Text += "Racer's Board = VANILLA | Not Randomized\n";
                return;
            }
            if (comboBox4.SelectedIndex == 1)
            {
                richTextBox1.Text += "Racer's Board = ENABLED\n";

                if (checkBox1.Checked)
                {
                    fair = true;
                    richTextBox1.Text += "Keep Balanced = ON\n";
                }
                else
                {
                    fair = false;
                }

                racerBoardsRandomization(fair);
            }
        }                     //Somewhat done.
        public void boardColors()
        {
            bool hidden;

            if (comboBox8.SelectedIndex != 0)
            {
                richTextBox1.Text += "Racer's Board Color Randomization = ENABLED\n";
                if (comboBox8.SelectedIndex > 1 || comboBox8.SelectedIndex < 0)
                {
                    richTextBox1.Text += "Randomizing racer's board color setting selection.\n";
                    Random rng = new Random();
                    comboBox8.SelectedIndex = rng.Next(0, 1);
                }
            }
            if (comboBox8.SelectedIndex == 0)
            {
                richTextBox1.Text += "Racer's Board Colors = VANILLA | Not Randomized\n";
                return;
            }
            if (comboBox8.SelectedIndex == 1)
            {
                richTextBox1.Text += "Racer's Board Colors = ENABLED\n";

                if (checkBox1.Checked)
                {
                    hidden = true;
                    richTextBox1.Text += "Hidden board color allowed.\n";
                }
                else
                {
                    hidden = false;
                }

                boardColorsRandomization(hidden);
            }
        }                     //Somewhat done.
        public void shotGameSnowmen()
        {
            int a = 0;
            if (comboBox5.SelectedIndex != 0)
            {
                richTextBox1.Text += "Shot Game Snowmen = ENABLED\n";
                if (comboBox5.SelectedIndex > 2 || comboBox5.SelectedIndex < 0)
                {
                    richTextBox1.Text += "Randomizing shot game snowmen setting selection.\n";
                    Random rng = new Random();
                    comboBox5.SelectedIndex = rng.Next(0, 2);
                }
            }
            if (comboBox5.SelectedIndex == 0)
            {
                richTextBox1.Text += "Shot Game Snowmen = VANILLA | Not Randomized\n";
                return;
            }
            if (comboBox5.SelectedIndex == 1)
            {
                richTextBox1.Text += "Shot Game Snowmen = BASIC\n";
                a = 0;
                shotGameSnowmenRandomization(a);
                return;
            }
            if (comboBox5.SelectedIndex == 2)
            {
                richTextBox1.Text += "Shot Game Snowmen = PICK-UPS\n";
                a = 1;
                shotGameSnowmenRandomization(a);
            }
        }                 //Somehwat done.
        public void speedGameFans()
        {
            int a = 0;
            if (comboBox6.SelectedIndex != 0)
            {
                richTextBox1.Text += "Speed Game Fans = ENABLED\n";
                if (comboBox6.SelectedIndex > 2 || comboBox6.SelectedIndex < 0)
                {
                    richTextBox1.Text += "Randomizing speed game fans setting selection.\n";
                    Random rng = new Random();
                    comboBox6.SelectedIndex = rng.Next(0, 2);
                }
            }
            if (comboBox6.SelectedIndex == 0)
            {
                richTextBox1.Text += "Speed Game Fans = VANILLA | Not Randomized\n";
                return;
            }
            if (comboBox6.SelectedIndex == 1)
            {
                richTextBox1.Text += "Speed Game Fans = BASIC\n";
                a = 0;
                speedGameFansRandomization(a);
                return;
            }
            if (comboBox6.SelectedIndex == 2)
            {
                richTextBox1.Text += "Speed Game Fans = PICK-UPS\n";
                a = 1;
                speedGameFansRandomization(a);
            }
        }                   //Somewhat done.
        public void trickGameUnlocks()
        {
            int a = 0;
            if (comboBox9.SelectedIndex != 0)
            {
                richTextBox1.Text += "Trick Game Unlocks = ENABLED\n";
                if (comboBox9.SelectedIndex > 2 || comboBox9.SelectedIndex < 0)
                {
                    richTextBox1.Text += "Randomizing trick game unlocks setting selection.\n";
                    Random rng = new Random();
                    comboBox9.SelectedIndex = rng.Next(0, 2);
                }
            }
            if (comboBox9.SelectedIndex == 0)
            {
                richTextBox1.Text += "Trick Game Unlocks = VANILLA | Not Randomized\n";
                return;
            }
            if (comboBox9.SelectedIndex == 1)
            {
                richTextBox1.Text += "Trick Game Unlocks = SAFE\n";
                a = 0;
                trickGameUnlocksRandomization(a);
                return;
            }
            if (comboBox9.SelectedIndex == 2)
            {
                richTextBox1.Text += "Trick Game Unlocks = IDIOTIC\n";
                a = 1;
                trickGameUnlocksRandomization(a);
            }
        }                //Somewhat done.
        public void misc()
        {
            int score;
            if (checkBox7.Checked)
            {
                score = 0;
                scoreboardRandomization(score);
            }

            if (checkBox6.Checked)
            {
                score = 1;
                scoreboardRandomization(score);
            }

            if (checkBox9.Checked)
            {
                score = 2;
                scoreboardRandomization(score);
            }

            if (checkBox10.Checked)
            {
                //Disable the 4x bonus thingy here. No need to call another class.
            }

            if (checkBox12.Checked)
            {
                sceneryRandomization();
            }
        }
        //Randomization Buffers

        public void trackCoinRandomization(int a)
        {
        }     //Next in line
        public void weaponShopsRandomization(int a)
        {
        }
        public void specialShopsRandomization(int a)
        {
        }
        public void racersRandomization(bool sin, bool dup)
        {
        }
        public void racerBoardsRandomization(bool fair)
        {
        }
        public void boardColorsRandomization(bool hidden)
        {
        }
        public void shotGameSnowmenRandomization(int a)
        {
        }
        public void speedGameFansRandomization(int a)
        {
        }
        public void trickGameUnlocksRandomization(int a)
        {
        }
        public void scoreboardRandomization(int score)
        {

        }
        public void sceneryRandomization()
        {

        }

        /*public void otherTweaksRandomization()
        {

        }*/

        //CRC Patch
        //CRC Patch
    }
}
