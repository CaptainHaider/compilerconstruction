using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace SnowX1
{
    public partial class Form1 : Form
    {

        public int dinx = 0, scope = 0;
        string s, type = null;
        string stp;
        int i = 0;
        string[,] simpleT = new string[4, 30];
        string[] DT = new String[] { "intg", "str", "flt", "start", "SSWITCH", "FR", "WL", "SIF", "SELSE", "CC", "break", "FUNC", "void" };
        string[] CPl = new String[] { "INC/DEC_OPR", "ASGN_OPR", "ARTH_OPR", "RELT_OPR" };
        int ptcount = 0;
        int tcount = 0;
        string valid = "false";
        string temp = "";
        int clp = 0;
        bool rt = true;
        public static string[] d = new string[500];
        string[] CP;
        string[] inter=new string[500];
        int icgIndex = 0;
        int li_count=1, lf_count=1, lw_count=1,le_count=1;
        //string[] VP;
        //int vlp=0;

        public Form1()
        {
            InitializeComponent();
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button4.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
            button4.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            textBox2.Text = "";


            try
            {
                // CP = new string[2000];

                CP = new string[2000];
                clp = 1;
                System.IO.TextReader read = new System.IO.StringReader(textBox1.Text);
                string Line = read.ReadLine() + "";
                int count = 1;
                clp = 1;
                while (Line != null)
                {

                    Line += "";
                    for (i = 0; i < Line.Length; i++)
                    {

                    stt:

                        if (Line[i] == 'i')
                        {

                            if (i + 1 < Line.Length && Line[i + 1] == 'n')
                            {

                                if (i + 2 < Line.Length && Line[i + 2] == 't')
                                {
                                    if (i + 3 < Line.Length && Line[i + 3] == 'g')
                                    {

                                        textBox2.Text += "intg, " + DT[0] + ", " + count;
                                        textBox2.Text += "\r\n";
                                        //CP[clp]+=DT[0];
                                        CP[clp] = "DT";
                                        //    VP[vlp] = "intg";
                                        //   vlp++;
                                        //textBox3.Text += CP[clp];
                                        // clp++;
                                        textBox3.Text += CP[clp] + "\r\n";
                                        clp++;

                                        i += 4;
                                        if (Line.Length == i)
                                        {
                                            break;
                                        }
                                    }
                                }

                            }
                        }

                        // void token
                        if (Line[i] == 'v')
                        {

                            if (i + 1 < Line.Length && Line[i + 1] == 'o')
                            {

                                if (i + 2 < Line.Length && Line[i + 2] == 'i')
                                {
                                    if (i + 3 < Line.Length && Line[i + 3] == 'd')
                                    {

                                        textBox2.Text += "void, " + DT[12] + ", " + count;
                                        textBox2.Text += "\r\n";
                                        //CP[clp]+=DT[0];
                                        CP[clp] = "void";
                                        //   VP[vlp] = "void";
                                        //  vlp++;

                                        //textBox3.Text += CP[clp];
                                        // clp++;
                                        textBox3.Text += CP[clp] + "\r\n";
                                        clp++;
                                        i += 4;
                                        if (Line.Length == i)
                                        {
                                            break;
                                        }
                                    }
                                }

                            }
                        }
                        //func token
                        //


                        //func token
                        if (Line[i] == 'F')
                        {

                            if (i + 1 < Line.Length && Line[i + 1] == 'U')
                            {

                                if (i + 2 < Line.Length && Line[i + 2] == 'N')
                                {
                                    if (i + 3 < Line.Length && Line[i + 3] == 'C')
                                    {

                                        textBox2.Text += "FUNC, " + DT[11] + ", " + count;
                                        textBox2.Text += "\r\n";
                                        //CP[clp]+=DT[0];
                                        CP[clp] = "FUNC";
                                        //textBox3.Text += CP[clp];
                                        // clp++;
                                        textBox3.Text += CP[clp] + "\r\n";
                                        clp++;
                                        i += 4;
                                        if (Line.Length == i)
                                        {
                                            break;
                                        }
                                    }
                                }

                            }
                        }
                        //

                        if (Line[i] == 's')
                        {
                            if (i + 1 < Line.Length && Line[i + 1] == 't')
                            {
                                if (i + 2 < Line.Length && Line[i + 2] == 'r')
                                {

                                    textBox2.Text += "str, " + DT[1] + ", " + count;
                                    textBox2.Text += "\r\n";
                                    //CP[clp] += DT[1];
                                    CP[clp] = "DT";


                                    //textBox3.Text += CP[clp];
                                    // clp++;
                                    textBox3.Text += CP[clp] + "\r\n";
                                    clp++;
                                    i += 3;
                                    if (Line.Length == i)
                                    {
                                        break;
                                    }
                                }
                            }
                        }

                        if (Line[i] == 'f')
                        {
                            if (i + 1 < Line.Length && Line[i + 1] == 'l')
                            {
                                if (i + 2 < Line.Length && Line[i + 2] == 't')
                                {

                                    textBox2.Text += "flt, " + DT[2] + ", " + count;
                                    textBox2.Text += "\r\n";
                                    // CP[clp] += DT[2];
                                    CP[clp] = "DT";
                                    //textBox3.Text += CP[clp];
                                    // clp++;
                                    textBox3.Text += CP[clp] + "\r\n";
                                    clp++;
                                    i += 3;
                                    if (Line.Length == i)
                                    {
                                        break;
                                    }
                                }
                            }
                        }

                        if (Line[i] == 's')
                        {
                            if (i + 1 < Line.Length && Line[i + 1] == 't')
                            {
                                if (i + 2 < Line.Length && Line[i + 2] == 'a')
                                {
                                    if (i + 3 < Line.Length && Line[i + 3] == 'r')
                                    {
                                        if (i + 4 < Line.Length && Line[i + 4] == 't')
                                        {

                                            // textBox2.Text += "start, " + DT[3] + ", " + count;
                                            textBox2.Text += "KW, " + DT[3] + ", " + count;
                                            textBox2.Text += "\r\n";
                                            CP[clp] += DT[3];
                                            //CP[clp] = "DT\r\n";
                                            //textBox3.Text += CP[clp];
                                            // clp++;
                                            textBox3.Text += CP[clp] + "\r\n";
                                            clp++;
                                            i += 5;
                                            if (Line.Length == i)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }



                        ////
                        //switch
                        if (Line[i] == 'S')
                        {
                            if (i + 1 < Line.Length && Line[i + 1] == 'S')
                            {
                                if (i + 2 < Line.Length && Line[i + 2] == 'W')
                                {
                                    if (i + 3 < Line.Length && Line[i + 3] == 'I')
                                    {
                                        if (i + 4 < Line.Length && Line[i + 4] == 'T')
                                        {
                                            if (i + 5 < Line.Length && Line[i + 5] == 'C')
                                            {
                                                if (i + 6 < Line.Length && Line[i + 6] == 'H')
                                                {

                                                    textBox2.Text += "KW, " + "SSWITCH , " + count;
                                                    textBox2.Text += "\r\n";
                                                    CP[clp] += DT[4];
                                                    //CP[clp] = "DT\r\n";
                                                    //textBox3.Text += CP[clp];
                                                    // clp++;
                                                    textBox3.Text += CP[clp] + "\r\n";
                                                    clp++;
                                                    i += 7;
                                                    if (Line.Length == i)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        //
                        if (Line[i] == 'b')
                        {
                            if (i + 1 < Line.Length && Line[i + 1] == 'r')
                            {
                                if (i + 2 < Line.Length && Line[i + 2] == 'e')
                                {
                                    if (i + 3 < Line.Length && Line[i + 3] == 'a')
                                    {
                                        if (i + 4 < Line.Length && Line[i + 4] == 'k')
                                        {
                                            textBox2.Text += "KW, " + "break" + ", " + count;
                                            textBox2.Text += "\r\n";
                                            i += 5;
                                            textBox2.Text += "\r\n";
                                            CP[clp] += DT[10];
                                            //CP[clp] = "DT\r\n";
                                            //textBox3.Text += CP[clp];
                                            // clp++;
                                            textBox3.Text += CP[clp] + "\r\n";
                                            clp++;
                                            if (Line.Length == i)
                                            {
                                                break;
                                            }

                                        }
                                    }

                                }
                            }
                        }
                        //
                        if (Line[i] == 'F')
                        {
                            if (i + 1 < Line.Length && Line[i + 1] == 'R')
                            {
                                textBox2.Text += "KW, " + "FR, " + count;
                                textBox2.Text += "\r\n";
                                i += 2;
                                textBox2.Text += "\r\n";
                                CP[clp] += DT[5];
                                //CP[clp] = "DT\r\n";
                                //textBox3.Text += CP[clp];
                                // clp++;
                                textBox3.Text += CP[clp] + "\r\n";
                                clp++;
                                if (Line.Length == i)
                                {
                                    break;
                                }

                            }
                        }
                        //
                        //Case 
                        if (Line[i] == 'C')
                        {
                            if (Line[i + 1] == 'C')
                            {
                                textBox2.Text += "KW, " + "CC, " + count;
                                textBox2.Text += "\r\n";
                                i += 2;
                                textBox2.Text += "\r\n";
                                CP[clp] += DT[9];
                                //CP[clp] = "DT\r\n";
                                //textBox3.Text += CP[clp];
                                // clp++;
                                textBox3.Text += CP[clp] + "\r\n";
                                clp++;
                                if (Line.Length == i)
                                {
                                    break;
                                }


                            }
                        }
                        //
                        if (Line[i] == 'W')
                        {
                            if (i + 1 < Line.Length && Line[i + 1] == 'L')
                            {
                                textBox2.Text += "KW, " + "WL, " + count;
                                textBox2.Text += "\r\n";
                                i += 2;
                                textBox2.Text += "\r\n";
                                CP[clp] += DT[6];
                                //CP[clp] = "DT\r\n";
                                //textBox3.Text += CP[clp];
                                // clp++;
                                textBox3.Text += CP[clp] + "\r\n";
                                clp++;
                                if (Line.Length == i)
                                {
                                    break;
                                }

                            }
                        }
                        //if (Line[i] == 'D')
                        //{
                        //    if (i + 1 < Line.Length && Line[i + 1] == 'L')
                        //    {

                        //        textBox2.Text += "KW, " + "DL, " + count;
                        //        textBox2.Text += "\r\n";
                        //        i += 2;
                        //        if (Line.Length == i)
                        //        {
                        //            break;
                        //        }

                        //    }

                        //}
                        if (Line[i] == '$')
                        {
                            if (i + 1 < Line.Length && Line[i + 1] == 'I')
                            {
                                if (i + 2 < Line.Length && Line[i + 2] == 'F')
                                {

                                    textBox2.Text += "KW, " + "SIF, " + count;
                                    // textBox2.Text += "\r\n";
                                    i += 3;
                                    textBox2.Text += "\r\n";
                                    CP[clp] += DT[7];
                                    //CP[clp] = "DT\r\n";
                                    //textBox3.Text += CP[clp];
                                    // clp++;
                                    textBox3.Text += CP[clp] + "\r\n";
                                    clp++;
                                    if (Line.Length == i)
                                    {
                                        break;
                                    }

                                }
                            }

                        }
                        if (Line[i] == '$')
                        {
                            if (i + 1 < Line.Length && Line[i + 1] == 'E')
                            {
                                if (i + 2 < Line.Length && Line[i + 2] == 'L')
                                {
                                    if (i + 3 < Line.Length && Line[i + 3] == 'S')
                                    {
                                        if (i + 4 < Line.Length && Line[i + 4] == 'E')
                                        {
                                            textBox2.Text += "KW, " + "SELSE, " + count;
                                            // textBox2.Text += "\r\n";
                                            i += 5;
                                            textBox2.Text += "\r\n";
                                            CP[clp] += DT[8];
                                            //CP[clp] = "DT\r\n";
                                            //textBox3.Text += CP[clp];
                                            // clp++;
                                            textBox3.Text += CP[clp] + "\r\n";
                                            clp++;
                                            if (Line.Length == i)
                                            {
                                                break;
                                            }

                                        }
                                    }
                                }
                            }

                        }

                        //// NEW OPERTORS CHECKS
                        {
                            if (Line[i] == '+')
                            {

                                if (i + 1 < Line.Length && Line[i + 1] == '+')
                                {
                                    textBox2.Text += CPl[0] + "," + Line[i].ToString() + Line[i + 1].ToString() + ", " + count;
                                    textBox2.Text = textBox2.Text + "\r\n";
                                    CP[clp] = "INC/DEC_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;

                                    i++;


                                }

                                else if (i + 1 < Line.Length && Line[i + 1] == '=')
                                {
                                    textBox2.Text += CPl[1] + "," + Line[i].ToString() + Line[i + 1].ToString() + ", " + count;
                                    textBox2.Text = textBox2.Text + "\r\n";

                                    CP[clp] = "ASGN_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;

                                    i++;


                                }

                                else
                                {
                                    textBox2.Text += CPl[2] + "," + Line[i].ToString() + ", " + count;
                                    textBox2.Text = textBox2.Text + "\r\n";
                                    CP[clp] = "ARTH_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;

                                    // i++; left

                                }
                            }

                            else if (Line[i] == '*')
                            {
                                if (i + 1 < Line.Length && Line[i + 1] == '=')
                                {
                                    textBox2.Text += CPl[1] + "," + Line[i].ToString() + Line[i + 1].ToString() + ", " + count;
                                    textBox2.Text = textBox2.Text + "\r\n";
                                    CP[clp] = "ASGN_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;

                                    i++;
                                }
                                else
                                {
                                    textBox2.Text += CPl[2] + "," + Line[i].ToString() + ", " + count;
                                    textBox2.Text += "\r\n";
                                    CP[clp] = "ARTH_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;

                                }
                            }

                            else if (Line[i] == '/')
                            {
                                if (i + 1 < Line.Length && Line[i + 1] == '=')
                                {
                                    textBox2.Text += CPl[1] + "," + Line[i].ToString() + Line[i + 1].ToString() + ", " + count;
                                    textBox2.Text = textBox2.Text + "\r\n";
                                    CP[clp] = "ASGN_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;
                                    i++;
                                }
                                else
                                {
                                    textBox2.Text += CPl[2] + "," + Line[i].ToString() + ", " + count;
                                    textBox2.Text += "\r\n";
                                    CP[clp] = "ARTH_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;

                                }
                            }




                            else if (Line[i] == '-')
                            {
                                if (i + 1 < Line.Length && Line[i + 1] == '-')
                                {
                                    textBox2.Text += CPl[0] + "," + Line[i].ToString() + Line[i + 1].ToString() + ", " + count;
                                    textBox2.Text = textBox2.Text + "\r\n";
                                    CP[clp] = "INC/DEC_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;
                                    i++;
                                }

                                else if (i + 1 < Line.Length && Line[i + 1] == '=')
                                {
                                    textBox2.Text += CPl[1] + "," + Line[i].ToString() + Line[i + 1].ToString() + ", " + count;
                                    textBox2.Text = textBox2.Text + "\r\n";
                                    CP[clp] = "ASGN_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;
                                    i++;
                                }

                                else
                                {
                                    textBox2.Text += CPl[2] + "," + Line[i].ToString() + ", " + count;
                                    textBox2.Text = textBox2.Text + "\r\n";
                                    CP[clp] = "ARTH_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;

                                }
                            }

                            else if (Line[i] == '=')
                            {

                                if (i + 1 < Line.Length && Line[i + 1] == '=')
                                {
                                    textBox2.Text += CPl[3] + "," + Line[i].ToString() + Line[i + 1].ToString() + ", " + count;
                                    textBox2.Text = textBox2.Text + "\r\n";
                                    CP[clp] = "RELT_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;
                                    i++;
                                }
                                else
                                {
                                    textBox2.Text += CPl[1] + "," + Line[i].ToString() + ", " + count;
                                    textBox2.Text = textBox2.Text + "\r\n";
                                    CP[clp] = "ASGN_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;

                                }
                            }

                            else if (Line[i] == '<' || Line[i] == '>')
                            {
                                if (i + 1 < Line.Length && Line[i + 1] == '=')
                                {
                                    textBox2.Text += CPl[3] + "," + Line[i].ToString() + Line[i + 1].ToString() + ", " + count;
                                    textBox2.Text += "\r\n";
                                    CP[clp] = "RELT_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;
                                    i++;
                                }
                                else
                                {
                                    textBox2.Text += CPl[3] + "," + Line[i].ToString() + ", " + count;
                                    textBox2.Text += "\r\n";
                                    CP[clp] = "RELT_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;

                                }
                            }

                            else if (Line[i] == ' ')
                            {
                                textBox2.Text += "\r\n";
                            }

                        }
                        if (Line[i] == '&')
                        {
                            if (i + 1 < Line.Length && Line[i + 1] == '&')
                            {
                                textBox2.Text += "AND_OPR, " + "&&, " + count;
                                textBox2.Text += "\r\n";
                                //added 10/21/1014
                                CP[clp] = "AND_OPR\r\n";
                                textBox3.Text += CP[clp];
                                clp++;
                            }
                        }
                        if (Line[i] == '|')
                        {
                            if (i + 1 < Line.Length && Line[i + 1] == '|')
                            {
                                textBox2.Text += "OR_OPR, " + "||, " + count;
                                textBox2.Text += "\r\n";
                                //added
                                CP[clp] = "OR_OPR\r\n";
                                textBox3.Text += CP[clp];
                                clp++;
                            }
                        }
                        if (Line[i] == '!')
                        {
                            if (i + 1 < Line.Length && Line[i] == '!')
                            {
                                if (i + 1 < Line.Length && Line[i + 1] == '=')
                                {
                                    textBox2.Text += CPl[3] + "," + Line[i].ToString() + Line[i + 1].ToString() + ", " + count;
                                    textBox2.Text += "\r\n";
                                    CP[clp] = "RELT_OPR\r\n";
                                    textBox3.Text += CP[clp];
                                    clp++;
                                    i++;

                                }
                            }
                            else
                            {
                                textBox2.Text += "NOT_OPR, " + Line[i].ToString() + ", " + count;
                                textBox2.Text += "\r\n";
                                //added
                                CP[clp] = "NOT_OPR\r\n";
                                textBox3.Text += CP[clp];
                                clp++;
                            }
                        }

                        if (Line[i] == '(' || Line[i] == '{' || Line[i] == '}' || Line[i] == ')' || Line[i] == '[' || Line[i] == ']' || Line[i] == ';' || Line[i] == '?' || Line[i] == '"' || Line[i] == ',' || Line[i] == ':')
                        {

                            if (Line[i] == '(')
                            {
                                textBox2.Text += "(, " + Line[i].ToString() + ", " + count;
                                textBox2.Text += "\r\n";

                                CP[clp] = "(\r\n";
                                textBox3.Text += CP[clp];
                                clp++;

                            }
                            else if (Line[i] == ')')
                            {
                                textBox2.Text += "), " + Line[i].ToString() + ", " + count;
                                textBox2.Text += "\r\n";

                                CP[clp] = ")\r\n";
                                textBox3.Text += CP[clp];
                                clp++;

                            }
                            else if (Line[i] == '{')
                            {
                                textBox2.Text += "{, " + Line[i].ToString() + ", " + count;
                                textBox2.Text += "\r\n";

                                CP[clp] = "{\r\n";
                                textBox3.Text += CP[clp];
                                clp++;

                            }
                            else if (Line[i] == '}')
                            {
                                textBox2.Text += "}, " + Line[i].ToString() + ", " + count;
                                textBox2.Text += "\r\n";

                                CP[clp] = "}\r\n";
                                textBox3.Text += CP[clp];
                                clp++;

                            }
                            else if (Line[i] == ';')
                            {
                                textBox2.Text += "\r\n" + "; , " + Line[i].ToString() + ", " + count;
                                textBox2.Text += "\r\n";

                                CP[clp] = ";\r\n";
                                textBox3.Text += CP[clp];
                                clp++;

                            }
                            //these lines are added to show ',' 

                            else if (Line[i] == ',')
                            {
                                textBox2.Text += "\r\n" + ", , " + Line[i].ToString() + ", " + count;
                                textBox2.Text += "\r\n";

                                CP[clp] = ",\r\n";
                                textBox3.Text += CP[clp];
                                clp++;

                            }
                            //
                            //these lines are added to show :
                            else if (Line[i] == ':')
                            {
                                textBox2.Text += "\r\n" + ": , " + Line[i].ToString() + ", " + count;
                                textBox2.Text += "\r\n";

                                CP[clp] = ":\r\n";
                                textBox3.Text += CP[clp];
                                clp++;

                            }
                            //

                            else if (Line[i] == '[')
                            {
                                textBox2.Text += "[, " + Line[i].ToString() + ", " + count;
                                textBox2.Text += "\r\n";

                                CP[clp] = "[\r\n";
                                textBox3.Text += CP[clp];
                                clp++;
                            }
                            else if (Line[i] == ']')
                            {
                                textBox2.Text += "], " + Line[i].ToString() + ", " + count;
                                textBox2.Text += "\r\n";

                                CP[clp] = "]\r\n";
                                textBox3.Text += CP[clp];
                                clp++;
                            }
                            else if (Line[i] == '?')
                            {
                                if (i + 1 < Line.Length && Line[i + 1] == '?')
                                {
                                    // textBox2.Text += "COMMENT," + Line[i].ToString() + ", " + count;
                                    textBox2.Text += "\r\n";

                                    //CP[clp] = "COMMENT\r\n";
                                    //textBox3.Text += CP[clp];
                                    //clp++;
                                    i++;
                                    goto ccc;
                                }
                                else
                                    textBox2.Text += "? , " + Line[i].ToString() + ", " + count;
                                textBox2.Text += "\r\n";

                                //CP[clp] = "?\r\n";
                                //textBox3.Text += CP[clp];
                                //clp++;

                            }
                            else if (Line[i] == '"')
                            {
                                textBox2.Text += "STRING_CONST, ";
                                CP[clp] = "STRING_CONST\r\n";
                                textBox3.Text += CP[clp];


                                while (i + 1 < Line.Length && Line[i + 1] != '"')
                                {
                                //111
                                qqq:
                                    if (i == Line.Length - 2)
                                    {
                                        textBox2.Text += " Lexical error";
                                        goto ccc;

                                        //break;
                                    }

                                    else
                                    {
                                        //if (Line[i] == '\\') { 
                                        Line = Line.Replace("\\n", string.Empty);
                                        Line = Line.Replace("\\t", string.Empty);
                                        //  Line = Line.Replace("\\", string.Empty);
                                        //}
                                        textBox2.Text += Line[++i].ToString();
                                    }

                                    if (Line[i] == '\\' && Line[i + 1] == '"')
                                    {
                                        //Line = Line.Replace("\\", string.Empty);
                                        goto qqq;
                                        //  continue;

                                    }
                                    //if (Line[i] == '\\' && Line[i + 1] == 'n')
                                    //{

                                    //    goto qqq;
                                    //    //continue;

                                    //}


                                }
                                i++;
                                textBox2.Text += ", " + count;

                                textBox2.Text = textBox2.Text.Replace("\\", string.Empty);
                                textBox2.Text += "\r\n";


                                // textBox2.Text += "STRING_CONST, ";
                                // //CP[clp] = "STRING_CONST\r\n";
                                // //textBox3.Text += CP[clp];
                                // //clp++;
                                // while (i + 1 < Line.Length && Line[i + 1] != '"')
                                // {
                                //     //111
                                //     if (i == Line.Length - 2)
                                //     {
                                //         textBox2.Text += "error";
                                //         break;
                                //     }

                                //     else
                                //     {
                                //         textBox2.Text += Line[++i].ToString();
                                //     }
                                // }
                                // i++;
                                // textBox2.Text += ", " + count;
                                //textBox2.Text += "\r\n";
                            }

                        }


                        ////

                        ////


                        if ((Char.IsDigit(Line[i])) && !(Char.IsLetter(Line[i])))
                        {
                            //checkNum(Line,i);
                            //
                            while (Char.IsDigit(Line[i]) && (Line[i] != '.') && (Line[i] != ' '))
                            {
                                valid = "integer_constant";
                                if (i < Line.Length)
                                {
                                    temp += Line[i];
                                    i++;
                                }
                                if (i == Line.Length)
                                {
                                    goto abd;

                                }
                                if (Char.IsLetter(Line[i]))
                                {
                                    valid = "not valid";
                                }


                            }
                            if (Line[i] == '@' || Line[i] == '_' || Line[i] == '#' || Line[i] == '$')
                            {
                                while (Line[i] != ' ')
                                {
                                    if (i < Line.Length)
                                    {
                                        temp += Line[i];
                                        i++;
                                    }
                                    if (i == Line.Length)
                                    {
                                        break;
                                    }//; breaking
                                    if (Line[i] == '+' || Line[i] == '-' || Line[i] == '=' || Line[i] == '*' || Line[i] == '/' || Line[i] == '&' || Line[i] == '|' || Line[i] == '<' || Line[i] == '>' || Line[i] == '{' || Line[i] == '}' || Line[i] == '(' || Line[i] == ')')
                                    {
                                        break;
                                    }

                                }
                                valid = "error";
                                goto abd;


                            }
                            if (Line[i] == '.')
                            {
                                //ptcount++;
                                temp += Line[i];
                                i++;
                                while (Char.IsDigit(Line[i]) && !(Char.IsLetter(Line[i])))
                                {
                                    valid = "float_constant";
                                    if (i < Line.Length)
                                    {
                                        temp += Line[i];
                                        i++;
                                    }
                                    if (i == Line.Length)
                                    {
                                        goto abd;

                                    }
                                    if (Line[i] == '.' || Line[i] == '@' || Line[i] == '#' || Line[i] == '$')
                                    {/// changes made

                                        //goto abd;
                                        // textBox2.Text += "error";
                                        // goto ccc;

                                        while (Line[i] != ' ')
                                        {
                                            if (i < Line.Length)
                                            {
                                                temp += Line[i];
                                                i++;
                                            }
                                            if (i == Line.Length)
                                            {
                                                break;
                                            }
                                            if (Line[i] == '+' || Line[i] == '-' || Line[i] == '=' || Line[i] == '*' || Line[i] == '/' || Line[i] == '&' || Line[i] == '|' || Line[i] == '<' || Line[i] == '>' || Line[i] == '{' || Line[i] == '}' || Line[i] == '(' || Line[i] == ')')
                                            {
                                                break;
                                            }
                                        }
                                        valid = "error";
                                        goto abd;
                                    }

                                }
                                ///*888
                                if (Char.IsLetter(Line[i]))
                                {
                                    // while (Char.IsLetter(Line[i]) && (i < Line.Length))
                                    //{
                                    while (Line[i] != ' ')
                                    {
                                        if (i < Line.Length)
                                        {
                                            temp += Line[i];
                                            i++;
                                        }
                                        if (i == Line.Length)
                                        {
                                            break;
                                        }//121
                                        if (Line[i] == '+' || Line[i] == '-' || Line[i] == '=' || Line[i] == '*' || Line[i] == '/' || Line[i] == '&' || Line[i] == '|' || Line[i] == '<' || Line[i] == '>' || Line[i] == '{' || Line[i] == '}' || Line[i] == '(' || Line[i] == ')')
                                        {
                                            break;
                                        }

                                    }
                                    //textBox2.Text += "error";
                                    valid = "error";
                                    goto abd;//changes made


                                }

                            }
                        abd:
                            textBox3.Text += valid + "\r\n";
                            textBox2.Text += valid + ", " + temp + ", " + count;
                            textBox2.Text += "\r\n";
                            temp = null;
                            //new remember
                            ////new edtion for terminating
                            if ((i < Line.Length) && (Line[i] == '+' || Line[i] == '-' || Line[i] == '=' || Line[i] == ';' || Line[i] == '*' || Line[i] == '/' || Line[i] == '&' || Line[i] == '|' || Line[i] == '<' || Line[i] == '>' || Line[i] == '{' || Line[i] == '}' || Line[i] == '(' || Line[i] == ')')) //(Char.IsSymbol(Line[i]))
                            {
                                goto stt;
                            }


                        }





                        if ((checkNum(i, Line).Item2) && (Char.IsLetter(Line[i]) || (Line[i] == '_')))
                        {

                            valid = "ID";
                            //if (Char.IsLetter(Line[i]) )
                            //{
                            //    valid = "ID";
                            //}
                            temp += Line[i];
                            i++;
                            if (i < Line.Length)
                            {

                                while (Char.IsLetter(Line[i]) && !(Line[i] == '_'))
                                {
                                    while (Char.IsLetter(Line[i]) || (Char.IsDigit(Line[i])))
                                    {
                                        valid = "ID";

                                        if (i < Line.Length)
                                        {
                                            temp += Line[i];
                                            i++;
                                        }
                                        if (i == Line.Length)
                                        {
                                            goto aaa;

                                        }
                                        if (Char.IsDigit(Line[i]))
                                        {

                                            valid = "ID";
                                        }
                                        //if(Line[i] == '_'){
                                        //    textBox2.Text += "ID " + valid + " " + count;
                                        //    textBox2.Text += "\r\n";
                                        //    goto 
                                        //}

                                    }
                                }

                                if (Line[i] == '_' || Line[i] == '.' || Line[i] == '@' || Line[i] == '#' || Line[i] == '$')
                                {
                                    //textBox2.Text += "not valid"  + " " + count;
                                    //textBox2.Text += "\r\n";

                                    //   goto ccc;


                                    ////1111
                                    while (Line[i] != ' ')
                                    {
                                        if (i < Line.Length)
                                        {
                                            temp += Line[i];
                                            i++;
                                        }
                                        if (i == Line.Length)
                                        {
                                            break;
                                        }
                                        //remember if fault for giving error abc.a+a
                                        if (Line[i] == '+' || Line[i] == '-' || Line[i] == '=' || Line[i] == '*' || Line[i] == '/' || Line[i] == '&' || Line[i] == '|' || Line[i] == '<' || Line[i] == '>' || Line[i] == '{' || Line[i] == '}' || Line[i] == '(' || Line[i] == ')')
                                        {
                                            break;
                                        }

                                    }
                                    valid = "not valid";
                                    goto aaa;
                                }

                                if (Char.IsDigit(Line[i]))
                                {
                                    textBox2.Text += "not valid" + " " + count;
                                    textBox2.Text += "\r\n";
                                    goto ccc;
                                }


                            }




                        aaa:
                            textBox3.Text += valid + "\r\n";
                            textBox2.Text += valid + " ," + temp + ", " + count;
                            textBox2.Text += "\r\n";
                            temp = null; ;
                            ////new edtion for terminating
                            if ((i < Line.Length) && (Line[i] == '+' || Line[i] == ';' || Line[i] == '-' || Line[i] == '=' || Line[i] == '*' || Line[i] == '/' || Line[i] == '&' || Line[i] == '|' || Line[i] == '<' || Line[i] == '>' || Line[i] == '{' || Line[i] == '}' || Line[i] == '(' || Line[i] == ')')) //(Char.IsSymbol(Line[i]))
                            {
                                goto stt;
                            }

                        }
                        //else if (checkNum(i, Line).Item2==false) {
                        //    textBox2.Text += "new"+ " " + count;
                        //    textBox2.Text += "\r\n";
                        //}
                        //if (i < Line.Length)//new condition
                        //{
                        //    i = checkNum(i, Line).Item1; //for checking int not to show as DT
                        //}








                    }
                ccc:
                    Line = read.ReadLine();
                    count++;
                }



            }
            catch (Exception)
            {


            }

        }



        Tuple<int, bool> checkNum(int i, string line)
        {
            //start
            if (line[i] == 's')
            {
                if (i + 1 < line.Length && line[i + 1] == 't')
                {
                    if (i + 2 < line.Length && line[i + 2] == 'a')
                    {
                        if (i + 3 < line.Length && line[i + 3] == 'r')
                        {
                            if (i + 4 < line.Length && line[i + 4] == 't')
                            {

                                rt = false;
                                i += 4;
                            }
                        }
                    }
                }
            }
            //
            //int check
            if (line[i] == 'i')
            {

                if (i + 1 < line.Length && line[i + 1] == 'n')
                {

                    if (i + 2 < line.Length && line[i + 2] == 't')
                    {
                        if (i + 3 < line.Length && line[i + 3] == 'g')
                        {
                            rt = false;
                            i += 3;
                        }
                    }
                }
            }
            // 
            //str check
            else if (line[i] == 's')
            {

                if (i + 1 < line.Length && line[i + 1] == 't')
                {

                    if (i + 2 < line.Length && line[i + 2] == 'r')
                    {
                        rt = false;
                        i += 2;

                    }
                }
            }
            // 
            //float check
            else if (line[i] == 'f')
            {

                if (i + 1 < line.Length && line[i + 1] == 'l')
                {

                    if (i + 2 < line.Length && line[i + 2] == 't')
                    {
                        rt = false;
                        i += 2;

                    }
                }
            }
            // 
            //SIF check
            else if (line[i] == '$')
            {

                if (i + 1 < line.Length && line[i + 1] == 'I')
                {

                    if (i + 2 < line.Length && line[i + 2] == 'F')
                    {
                        rt = false;
                        i += 2;

                    }
                }
            }
            // 
            //Selse check
            else if (line[i] == '$')
            {
                if (i + 1 < line.Length && line[i + 1] == 'E')
                {
                    if (i + 2 < line.Length && line[i + 2] == 'L')
                    {
                        if (i + 3 < line.Length && line[i + 3] == 'S')
                        {
                            if (i + 4 < line.Length && line[i + 4] == 'E')
                            {
                                rt = false;
                                i += 4;


                            }
                        }
                    }
                }

            }
            // 
            //DO WHILE check
            else if (line[i] == 'D')
            {

                if (i + 1 < line.Length && line[i + 1] == 'L')
                {

                    rt = false;
                    i += 1;


                }
            }
            // 
            //DO WHILE check
            else if (line[i] == 'W')
            {

                if (i + 1 < line.Length && line[i + 1] == 'L')
                {

                    rt = false;
                    i += 1;


                }
            }
            // 
            // FOR check
            else if (line[i] == 'F')
            {

                if (i + 1 < line.Length && line[i + 1] == 'R')
                {

                    rt = false;
                    i += 1;


                }
            }
            // 

            else
            {
                rt = true;
            }
            return Tuple.Create(i, rt);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // File.WriteAllText("cc1.txt", textBox2.Text);
            System.IO.File.AppendAllText("myfile.txt", DateTime.Now + Environment.NewLine + textBox1.Text + Environment.NewLine + textBox2.Text + "******************************************************" + Environment.NewLine);
            MessageBox.Show("File Saved :) ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            // for seprating value part
            string[] syn_token_tmp, sem_token_tmp, syn_token = new string[200], sem_token = new string[200];
            int ir = 0;
            bool y;
            // simple[0][3] = "";
            //int p = txtoutput.Lines.Length;
            while (ir != textBox2.Lines.Length)
            {
                syn_token_tmp = textBox2.Lines[ir].ToString().Split(new Char[] {
					','
				});
                if (syn_token_tmp[0] != "")
                    syn_token[ir] = syn_token_tmp[0].Remove(0, 1);
                ir++;
            }
            ir = 0;
            while (ir != textBox2.Lines.Length)
            {
                sem_token_tmp = textBox2.Lines[ir].ToString().Split(new Char[] {
					','
				});
                if (sem_token_tmp[0] != "" && sem_token_tmp[0] != "comma")
                {
                    //int len = syn_token_tmp[0].Length;
                    sem_token[ir] = sem_token_tmp[1];
                }
                else if (sem_token_tmp[0] == "comma")
                {
                    //int len = syn_token_tmp[0].Length;
                    sem_token[ir] = ",";
                }
                ir++;
            }
            //txtoutput.Lines = syn_token;
            syn_token = syn_token.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            sem_token = sem_token.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            for (int i = 0; i < sem_token.Length; i++)
            {
                label6.Text += sem_token[i];
            }

            //

            label5.Visible = true;
            textBox4.Visible = true;//
            TextReader r = new System.IO.StringReader(textBox3.Text);


            int j = 0;
            while ((s = r.ReadLine()) != null)
            {
                d[j] = s.ToString();
                j++;
                // label3.Text += d[j];
            }
            //  bool check;
            //check = main();
            // if (check == true)


            if (main(sem_token))
            {
                textBox4.Text += "No Syntax Error \n \r";
            }


            else
            {
                textBox4.Text = "Syntax Error! \n \r";
            }
            string ans = "";
            ans += main1(sem_token);
            // if (main1() == "working" || main1() == "" || main1() == "parameter error")
            if (ans == "working" || ans == "" || ans == "parameter error")
            {
                textBox4.Text += "\n \r" + stp;
            }
            textBox5.Lines = inter;
            //else
            //{
            //    textBox4.Text += "function Error!";
            //}
            //

        }

        public  string main1(string[] sem_token)
        {
            //  label3.Text = d[dinx].ToString();
            if (d[dinx] == "FUNC")//|| d[dinx] == "void")
            {
                dinx++;

                if (d[dinx] == "(")
                {
                    dinx++;
                    // if (d[dinx] == "DT")
                    if (param(sem_token))
                    {

                        //dinx++;
                        if (d[dinx] == ")")
                        {
                            dinx++;
                            if (d[dinx] == "{")
                            {
                                dinx++;
                                if (body(sem_token))
                                {
                                    //dinx++;
                                    if (d[dinx] == "}")
                                    {
                                        dinx++;
                                        return stp = "working";
                                    }
                                }


                            }

                        }
                    }
                    else
                    {
                        return stp = "parameter error";
                    }
                }
            }


            return stp = "";
        }
        public bool main(string[] sem_token)
        {
            //  label3.Text = d[dinx].ToString();
            if (d[dinx] == "DT")//|| d[dinx] == "void")
            {
                dinx++;
                if (d[dinx] == "start")
                {
                    dinx++;
                    if (d[dinx] == "(")
                    {
                        dinx++;
                        if (d[dinx] == "void" || d[dinx] == "DT")
                        {
                            dinx++;
                            if (d[dinx] == ")")
                            {
                                dinx++;
                                if (d[dinx] == "[")
                                {
                                    dinx++;
                                    if (body(sem_token))
                                    {
                                        //dinx++;
                                        if (d[dinx] == "]")
                                        {
                                            dinx++;
                                            return true;
                                        }
                                    }
                                }

                            }

                        }
                    }
                }
            }


            return false;
        }

        public bool body(string[] sem_token)
        {
            if (d[dinx] == ";")//null
            {//terminator dinx++
                dinx++;
                //if (body())
                //{
                //    return true;
                //}
                return true;
            }
            else if (s_st(sem_token))
            {
                return true;
            }
            else if (d[dinx] == "{")
            {
                dinx++;
                if (m_st(sem_token))
                {
                    if (d[dinx] == "}")
                    {
                        dinx++;
                        return true;
                    }
                }
            }
            else if (d[dinx] == "")
            {

                return true;
            }

            return false;
        }

        public bool m_st(string[] sem_token)
        {
            if (s_st(sem_token))
            {
                if (m_st(sem_token))
                {
                    return true;

                }
                else return false;
            }
            else
                return true;

        }

        public bool s_st(string[] sem_token)
        {
            if (decl(sem_token))
            {
                return true;
            }
            else if (While(sem_token))
            {
                return true;
            }
            else if (For(sem_token))
            {
                return true;
            }

            else if (IF_ELSE(sem_token))
            {
                return true;
            }
            else if (Switch_Case(sem_token))
            {
                return true;
            }
           
            //for a++ in if else 
            //else if (inc(sem_token))
            //{
            //    if (d[dinx] == ";")
            //    {
            //        dinx++;
            //        return true;
            //    }
            //    //else dinx--;
            //}
            else if (ID(sem_token))
            {
                if (d[dinx] == "ASGN_OPR")
                {
                    dinx++;
                    if (init2(sem_token))
                    {
                        dinx--;
                        string id = sem_token[dinx];
                        string type1 = null;
                        for (int i = 0; i < 30; i++)
                        {
                            if (simpleT[0, i] == id && scope_func(simpleT[2, i]))//lookup
                            {
                                type1 = simpleT[1, i];
                                //MessageBox.Show("redeclaration within this scope");
                                break;
                            }


                        }
                        if (type1 == null)
                        {
                            MessageBox.Show("undeclared variable is used");
                        }
                        dinx++;
                        if (d[dinx] == ";")
                        {
                            dinx++;
                            return true;
                        }
                        while (RO2(sem_token))//RO2 hoga yahn RO1 likaha ha
                        {
                            dinx--;
                            string opr = sem_token[dinx];
                            dinx++;
                            if (ID(sem_token) || constant(sem_token))
                            {
                                dinx--;
                                string idd = sem_token[dinx];
                                //string type1 = null;
                                for (int i = 0; i < 30; i++)
                                {
                                    if (simpleT[0, i] == idd && scope_func(simpleT[2, i]))//lookup
                                    {
                                        type = simpleT[1, i];
                                        //MessageBox.Show("redeclaration within this scope");
                                        break;
                                    }


                                }
                                if (type == null)
                                {
                                    MessageBox.Show("undeclared variable is used");
                                }
                                else if (type != null)
                                {
                                    if (opr == "-")
                                    {
                                        if ((type1 != type))//|| (type != " flt" && type1 != " intg") ||( type != " intg" && type1 != " flt") || (type1 == " str" && type == " str"))
                                        {
                                            MessageBox.Show("operation cannot be applied");
                                        }

                                    }
                                    else if (opr == "+")
                                    {
                                        if ((type1 != type))//|| (type != " flt" && type1 != " intg") ||( type != " intg" && type1 != " flt"))
                                        {
                                            MessageBox.Show("operation cannot be applied");
                                        }
                                    }
                                    else if (opr == "*")
                                    {
                                        if ((type1 != type))//|| (type != " flt" && type1 != " intg") || (type != " intg" && type1 != " flt") || (type1 == " str" && type == " str"))
                                        {
                                            MessageBox.Show("operation cannot be applied");
                                        }
                                    }
                                    else if (opr == "/")
                                    {
                                        if ((type1 != type) || (type != " flt" && type1 != " intg") || (type != " intg" && type1 != " flt") || (type1 == " str" && type == " str"))
                                        {
                                            MessageBox.Show("operation cannot be applied");
                                        }
                                    }
                                }
                                dinx++;
                                if (d[dinx] == ";")
                                {
                                    dinx++;
                                    return true;
                                }

                            }



                        }
                    }
                }
                else if (d[dinx] == "INC/DEC_OPR")
                {
                    dinx++;
                    if (d[dinx] == ";")
                    {
                        dinx++;
                        return true;
                    }
                }
                return false;
                //else dinx--;
            }

            //else if (init1())
            //{
            //    if (d[dinx] == ";")
            //    {
            //        dinx++;
            //        return true;
            //    }
            //    else dinx--;
            //}

            return false;
        }

        public bool decl(string[] sem_token)
        {
            if (d[dinx] == "DT")// "intg" || d[dinx] == "flt" || d[dinx] == "str")
            {
                string dt = sem_token[dinx];
                dinx++;
                if (ID(sem_token))
                {
                    dinx--;
                    string id = sem_token[dinx];
                    //string type1 = null;
                    //int chk = 0;
                    for (int i = 0; i < 30; i++)
                    {
                        if (simpleT[0, i] == id && simpleT[2, i] == scope.ToString())//lookup
                        {
                           
                            MessageBox.Show("redeclaration within this scope");
                            break;
                        }
                        else if (simpleT[0, i] == null && simpleT[1, i] == null && simpleT[2, i] == null)//insertion
                        {
                            simpleT[0, i] = id;
                            simpleT[1, i] = dt;
                            simpleT[2, i] = scope.ToString();
                            break;
                        }
                    }
                    dinx++;
                        if (init(sem_token))
                        {
                            dinx--;
                            
                            //12
                            if (d[dinx] == "ID")
                            {
                                for (int i = 0; i < 30; i++)
                                {
                                    if (simpleT[0, i] == id && scope_func(simpleT[2, i]))//lookup
                                    {
                                        type = simpleT[1, i];
                                        //MessageBox.Show("redeclaration within this scope");
                                        break;
                                    }


                                }
                                if (type != null)
                                {
                                    if ((dt == " intg") && (type != " intg"))//&& d[dinx] != "integer_constant" || d[dinx] == " intg")
                                    {
                                        MessageBox.Show("type mismatch");
                                    }
                                    else if ((dt == " flt") && (type != " flt"))
                                    {
                                        MessageBox.Show("type mismatch");
                                    }
                                    else if ((dt == " str") && (type != " str"))
                                    {
                                        MessageBox.Show("type mismatch");
                                    }
                                }
                                else if (type == null)
                                {
                                    MessageBox.Show("undeclared variable is used");
                                }

                            }
                            //12
                            else
                            {

                                if ((dt == " intg") && (d[dinx] != "integer_constant" || type != " intg"))//&& d[dinx] != "integer_constant" || d[dinx] == " intg")
                                {
                                    MessageBox.Show("type mismatch");
                                }
                                else if ((dt == " flt") && (d[dinx] != "float_constant" || type != " flt"))
                                {
                                    MessageBox.Show("type mismatch");
                                }
                                else if ((dt == " str") && (d[dinx] != "STRING_CONST" || type != " str"))
                                {
                                    MessageBox.Show("type mismatch");
                                }
                            }
                            dinx++;
                            if (List(sem_token))
                            {
                                return true;
                            }
                        }
                }
            }
            return false;
        }
        public bool ID(string[] sem_token)
        {
            if (d[dinx] == "ID")
            {//added
                dinx++;
                return true;
            }
            return false;
        }


        public bool init(string[] sem_token)
        {
            if (d[dinx] == "ASGN_OPR")
            {
                dinx++;
                if (init2(sem_token))
                {
                    return true;
                }
                //
                else
                {
                    dinx++;
                    return false;
                }
            }
            //else if (d[dinx] == "")//null
            //{
            //    dinx++;
            //    return true;
            //}
            return true;//ll
        }

        public bool init2(string[] sem_token)
        {
            if (constant(sem_token))
            {
                return true;
            }
            else if (ID(sem_token))
            {
                if (init(sem_token))
                {
                    return true;
                }
            }
            return false;
        }
        public bool List(string[] sem_token)
        {
            if (d[dinx] == ";")
            {//7:55 11/1/2014
                dinx++;
                return true;
            }
            else if (d[dinx] == ",")
            {
                dinx++;
                if (ID(sem_token))
                {
                    if (init(sem_token))
                    {
                        if (List(sem_token))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        public bool constant(string[] sem_token)
        {
            if (d[dinx] == "integer_constant" || d[dinx] == "float_constant" || d[dinx] == "STRING_CONST")
            {
                dinx++;
                return true;
            }
            return false;
        }

        public bool While(string[] sem_token)
        {
            //if (d[dinx] == "WL")
            //{
            //    dinx++;
            //    if (d[dinx] == "(")
            //    {
            //        dinx++;
            //        if (cond(sem_token))//
            //        {
            //            if (d[dinx] == ")")
            //            {
            //                dinx++;
            //                scope++;
            //                if (body(sem_token))
            //                {
            //                    scope--;
            //                    return true;
            //                }
            //            }
            //        }
            //    }
            //}
             if (d[dinx] == "WL")
                 {
                     string l = "L";
                     l += lw_count.ToString();
                     lw_count++;
                     inter[icgIndex] = l + ":";
                     string temppp = inter[icgIndex] ;    
                 icgIndex++;
                  
                 dinx++;
                      if (d[dinx] == "[")
                      {
                          dinx++;
                          if (d[dinx] == "(")
                          {
                              dinx++;
                              if (acond(sem_token))
                              {

                                  if (d[dinx] == ")")
                                  {
                                      dinx++;
                                      if (d[dinx] == ";")
                                      {
                                          dinx++;
                                          if (inc(sem_token))
                                          {
                                              if (d[dinx] == ";")
                                              {
                                                  dinx++;
                                                  string t = "t";
                                                  t += tcount.ToString();
                                                  tcount++;
                                                  inter[icgIndex] = temppp + t;
                                                  icgIndex++;
                                                  inter[icgIndex] = "if(" + t + "==false)jmp" + "L" + lw_count;
                                                  icgIndex++;
                                                  if (d[dinx] == "]")
                                                  {
                                                      
                                                      dinx++;
                                                      scope++;
                                                      if (body(sem_token))
                                                      {
                                                          inter[icgIndex] = "jmp" + l;
                                                          icgIndex++;
                                                          l = "L";
                                                          l += lw_count.ToString();
                                                          inter[icgIndex] = l + ":";
                                                          icgIndex++;
                                                          scope--;
                                                          return true;
                                                      }
                                                  }

                                              }
                                          }
                                      }
                                  }
                              }
                          }
                      }
            }
                                           
            return false;
        }

                                    

        //condition forloop and if else
        public bool acond(string[] sem_token)
        {
            //if (constant())
            //{
            //    if (acond1())
            //    {

            //        return true;
            //    }
            //}
            if (ID(sem_token))
            {
                dinx--;
                int c = 0;
                string id = sem_token[dinx];
                for (int i = 0; i < 30; i++)
                {
                    if (simpleT[0, i] == id && scope_func(simpleT[2, i]))//lookup
                    {
                        type = simpleT[1, i];
                        c = 1;
                        //MessageBox.Show("redeclaration within this scope");
                        break;
                    }
                    
                }//edited
                if (c==0) {
                    MessageBox.Show("not decleared");
                }
                dinx++;
                if (acond1(sem_token))
                {
                    return true;
                }
            }
            return false;
        }
        public bool acond1(string[] sem_token)
        {
            if (d[dinx] == "")
            {
                return true;
            }
            //Ro ki jagah R1
            else if (RO1(sem_token))
            {
                if (acond2(sem_token))
                {
                    return true;
                }
            }
            return false;
        }
        public bool acond2(string[] sem_token)
        {
            if (d[dinx] == "integer_constant")
            {//d[dinx]==integer_constant;
                if (type != " intg")
                {
                    MessageBox.Show("type mismatch");
                }
                dinx++;
                return true;
            }
            else if (ID(sem_token))
            {
                dinx--;
                string id = sem_token[dinx];
                string type1 = null;
                for (int i = 0; i < 30; i++)
                {
                    if (simpleT[0, i] == id && scope_func(simpleT[2, i]))//lookup
                    {
                        type1 = simpleT[1, i];
                        //MessageBox.Show("redeclaration within this scope");
                        break;
                    }

                }
                if (type != type1)
                {
                    MessageBox.Show("type mismatch");
                }
                dinx++;
                return true;
            }
            return false;
        }

        //
        public bool param(string[] sem_token)
        {
            if (d[dinx] == "DT")
            {
                while (d[dinx] == "DT")
                {
                    dinx++;
                    if (d[dinx] == ",")
                    {
                        dinx++;
                    }
                    //continue;
                }
                if (d[dinx - 1] == "DT")
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public bool cond(string[] sem_token)
        {
            if (constant(sem_token))
            {
                if (cond1(sem_token))
                {

                    return true;
                }
            }
            else if (ID(sem_token))
            {
                if (cond1(sem_token))
                {
                    return true;
                }
            }
            return false;
        }


        public bool cond1(string[] sem_token)
        {
            if (d[dinx] == "")
            {
                return true;
            }
            else if (RO(sem_token))
            {
                if (cond2(sem_token))
                {
                    return true;
                }
            }
            return false;
        }
        public bool cond2(string[] sem_token)
        {
            if (constant(sem_token))
            {
                //,a++
                if (d[dinx] == ",")
                {
                    dinx++;
                    if (inc(sem_token))
                    {
                        return true;
                    }
                }
                return false;
            }
            else if (ID(sem_token))
            {
                return true;
            }
            return false;
        }

        public bool RO(string[] sem_token)
        {
            if (d[dinx] == "RELT_OPR")
            {//added
                dinx++;
                return true;
            }
            else return false;
        }

        public bool inc(string[] sem_token)
        {
            if (ID(sem_token))
            {
                dinx--;
                string id = sem_token[dinx];
                string type1 = null;
                for (int i = 0; i < 30; i++)
                {
                    if (simpleT[0, i] == id && scope_func(simpleT[2, i]))//lookup
                    {
                        type1 = simpleT[1, i];
                        //MessageBox.Show("redeclaration within this scope");
                        break;
                    }
                    

                }
                if (type1 == null)
                {
                    MessageBox.Show("undeclared variable is used");
                }
                dinx++;
                if (incr(sem_token))
                {
                    return true;
                }
            }

            //000
            //  dinx--;
            return false;
        }
        public bool incr(string[] sem_token)
        {
            if (d[dinx] == "INC/DEC_OPR")
            {
                dinx++;
                return true;
            }
            return false;
        }

        public bool For(string[] sem_token)
        {
            if (d[dinx] == "FR")
            {
                dinx++;
                if (d[dinx] == "(")
                {
                    scope++;
                    dinx++;
                    if (initial(sem_token))
                    {
                        if (d[dinx] == ")")
                        {
                            dinx++;
                            //
                            string l = "FLL";
                            l += lf_count.ToString();
                            lf_count++;
                            inter[icgIndex] = l + ":";
                            string temppp = inter[icgIndex];
                            icgIndex++;
                  
                            //
                            if (d[dinx] == "{")
                            {
                                dinx++;
                                if (d[dinx] == "(")
                                {
                                    dinx++;
                                    if (acond(sem_token))
                                    {

                                        if (d[dinx] == ")")
                                        {
                                            dinx++;
                                            if (d[dinx] == ";")
                                            {
                                                dinx++;
                                                if (inc(sem_token))
                                                {
                                                    if (d[dinx] == ";")
                                                    {
                                                        dinx++;
                                                        //
                                                        
                                                        string t = "t";
                                                        t += tcount.ToString();
                                                        tcount++;
                                                        inter[icgIndex] = temppp + t;
                                                        icgIndex++;
                                                        inter[icgIndex] = "if(" + t + "==false)jmp" + "L" + lf_count;
                                                        icgIndex++;
                                                        //
                                                        if (d[dinx] == "}")
                                                        {
                                                            dinx++;
                                                            if (body(sem_token))
                                                            {
                                                                inter[icgIndex] = "jmp" + l;
                                                                icgIndex++;
                                                                l = "L";
                                                                l += lf_count.ToString();
                                                                inter[icgIndex] = l + ":";
                                                                icgIndex++;
                                                                scope--;
                                                                return true;
                                                            }
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                        }

                    }
                }
            }
            return false;
        }
        public bool initial(string[] sem_token)
        {
            if (d[dinx] == "DT")
            {
                string dt = sem_token[dinx];
                dinx++;

                if (init1(sem_token,dt))
                {
                    return true;
                }
            }
            //else if (init1(sem_token,dt))     //if no data type then not possible
            //{
            //    return true;
            //}
            return false;
        }
        public bool init1(string[] sem_token,string dt)
        {
            if (ID(sem_token))
            {
                dinx--;
                string id = sem_token[dinx];
                //string type1 = null;
                //int chk = 0;
                for (int i = 0; i < 30; i++)
                {
                   
                    if (simpleT[0, i] == null && simpleT[1, i] == null && simpleT[2, i] == null)//insertion
                    {
                        simpleT[0, i] = id;
                        simpleT[1, i] = dt;
                        simpleT[2, i] = scope.ToString();
                        break;
                    }
                }
                dinx++;
                if (d[dinx] == "ASGN_OPR")
                {
                    dinx++;
                    if (init2(sem_token))
                    {
                        return true;
                    }
                }
            }

            //000
            //   dinx--;
            return false;
        }

        public bool IF_ELSE(string[] sem_token)
        {
            if (d[dinx] == "SIF")
            {
                string t = "t";
                t += tcount.ToString();
                tcount++;
                string l = "IFL";
                l += li_count.ToString();
                li_count++;
                inter[icgIndex] = "if(" + t + "==false)jmp" + l;
                icgIndex++;
                dinx++;
                if (d[dinx] == "(")
                {
                    dinx++;
                    if (acond(sem_token))
                    {
                        if (d[dinx] == ")")
                        {
                            dinx++;
                            scope++;
                            if (body(sem_token))
                            {
                                if (oelse(sem_token))
                                {
                                    scope--;
                                    return true;

                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool oelse(string[] sem_token)
        {
            if (d[dinx] == "SELSE")
            {
                string l = "IFL";
                l += le_count.ToString();
                le_count++;
                inter[icgIndex] = "jmp" + l;
                icgIndex++;
                int tmp = le_count - 1;
                inter[icgIndex] = "L" + tmp.ToString() + ":";
                icgIndex++;
                
                dinx++;
                scope++;
                if (body(sem_token))
                {
                    inter[icgIndex] = l + ":";
                    icgIndex++;
                    scope--;
                    return true;
                }
            }
            else if (d[dinx] == "")
            {
                int tmp = li_count - 1;
                inter[icgIndex] = "L" + tmp.ToString() + ":";
                icgIndex++;
                return true;
            }
            return false;
        }

        public bool Switch_Case(string[] sem_token)
        {
            if (d[dinx] == "SSWITCH")
            {
                dinx++;
                if (d[dinx] == "(")
                {
                    dinx++;
                    if (ID(sem_token))
                    {
                        dinx--;
                        string id = sem_token[dinx], type1 = null;
                        for (int i = 0; i < 30; i++)
                        {
                            if (simpleT[0, i] == id && scope_func(simpleT[2, i]))//lookup
                            {
                                type1 = simpleT[1, i];
                                //MessageBox.Show("redeclaration within this scope");
                                break;
                            }

                        }
                        if (type1 == null)
                        {
                            MessageBox.Show("undeclared variable is used");
                        }
                        dinx++;
                        if (d[dinx] == ")")
                        {
                            dinx++;
                            if (d[dinx] == "{")
                            {
                                dinx++;
                                scope++;
                                if (SCase(sem_token))
                                {
                                    if (d[dinx] == "}")
                                    {
                                        dinx++;
                                        //if (body(sem_token))

                                        //{

                                        scope--;
                                        return true;
                                        //}

                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool SCase(string[] sem_token)
        {
            if (d[dinx] == "CC")
            {
                dinx++;
                if (d[dinx] == "ASGN_OPR")
                {
                    dinx++;
                    if (constant(sem_token))
                    {
                        if (d[dinx] == ":")
                        {
                            dinx++;
                            if (body(sem_token))
                            {
                                if (d[dinx] == "break")
                                {
                                    dinx++;
                                    if (d[dinx] == ";")
                                    {
                                        dinx++;
                                        if (SCase2(sem_token))
                                        {
                                            return true;
                                        }
                                        else// null
                                        {
                                            return true;
                                        }
                                    }
                                }

                            }
                        }

                    }
                }
            }
            return false;
        }

        public bool SCase2(string[] sem_token)
        {
            if (d[dinx] == "")
            {
                return true;
            }
            else if (SCase(sem_token))
            {
                return true;
            }
            return false;
        }

        public bool RO1(string[] sem_token)
        {
            if (d[dinx] == "RELT_OPR" || d[dinx] == "ARTH_OPR" || d[dinx] == "AND_OPR" || d[dinx] == "OR_OPR")
            {//added
                dinx++;
                return true;
            }
            else return false;
        }
        public bool RO2(string[] sem_token)// its for main when statement like a=a+b....;
        {
            if (d[dinx] == "ARTH_OPR")
            {//added
                dinx++;
                return true;
            }
            else return false;
        }

        public bool scope_func(string s)
        {
            int w = Convert.ToInt32(s);
            if (w >= 0 && w <= scope)
            {
                return true;
            }
            else
                return false;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("1:First insert souce code in source code textbox\n2:Then you have to generate tokens by clicking token generator button and then check syntax of our language by clicking syntax analyzer button. \n3:Functions can be declared after main function\n4: Refernce source codes are given in project folder", "HELP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

    }
}

