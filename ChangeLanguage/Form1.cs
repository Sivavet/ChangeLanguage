using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeLanguage
{
    public partial class TsGUI : Form
    {
        public TsGUI()
        {
            InitializeComponent();
        }


        string wordIn;
        string smallEng_Alphabe;
        string bigEng_Alphabe;
        string smallThai_Alphabe;
        string bigThai_Alphabe;
        string ansWer;
        int numThai;
        int numEng;
        

        private void translateBtn_Click(object sender, EventArgs e)
        {
            wordIn = fillBox.Text;
            smallEng_Alphabe = "1234567890-=qwertyuiop[]asdfghjkl;'zxcvbnm,./ ";
            bigEng_Alphabe = "!@#$%^&*()_+QWERTYUIOP{}ASDFGHJKL:\"ZXCVBNM<>? ";
            bigThai_Alphabe = "+๑๒๓๔ู฿๕๖๗๘๙๐\"ฎฑธํ๊ณฯญฐ,ฤฆฏโฌ็๋ษศซ.()ฉฮฺ์?ฒฬฦ ";
            smallThai_Alphabe = "ๅ/-ภถุึคตจขชๆไำพะัีรนยบลฟหกดเ้่าสวงผปแอิืทมใฝ ";

            for(int i = 0; i < wordIn.Length; i++) //i เพิ่ม = จำนวนตัวอักษรที่ใส่เข้าไป
            {
                for (int j = 0; j < smallEng_Alphabe.Length; j++) //แปลง อิ้งเล็ก ไป ไทยเล็ก //
                {
                    if (wordIn[i] == smallEng_Alphabe[j]) 
                    {
                        ansWer += smallThai_Alphabe[j];
                    }                
                }

                for (int k = 0; k < bigEng_Alphabe.Length; k++) //แปลง อิ้งใหญ่ ไป ไทยใหญ่
                {
                    if (wordIn[i] == bigEng_Alphabe[k]) 
                    {
                        ansWer += bigThai_Alphabe[k];
                    }                 
                }

                for (int l = 0; l < smallThai_Alphabe.Length; l++)
                {
                    if (wordIn[i] == smallThai_Alphabe[l]) //แปลง ไทยเล็ก ไป อิ้งเล็ก 
                    {
                        ansWer += smallEng_Alphabe[l];
                    }
                }

                for (int m = 0; m < bigThai_Alphabe.Length; m++)
                {
                    if (wordIn[i] == bigThai_Alphabe[m]) // แปลง ไทยใหญ่ ไป อิ้งใหญ่
                    {
                        ansWer += bigEng_Alphabe[m];
                    }
                }

                
                translateText.Text = ansWer;
                Clipboard.SetText(ansWer);
                
                

            }


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ansWer = "";
            translateText.Text = " ";
            fillBox.Text = "";
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
