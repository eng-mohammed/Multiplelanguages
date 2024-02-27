using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
namespace MultipleLanguages.App
{
    public partial class Form1 : Form
    {
        private JObject LangValue = new JObject();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

            arMenuItem.Click += ArMenuItem_Click;
            enMenuItem.Click += EnMenuItem_Click;
            frMenuItem.Click += FrMenuItem_Click;
            button1.Click += Button1_Click;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();

        }

        private void FrMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLang.lang = Lang.fr;
            //langMenu.Text = "Langue";
            //arMenuItem.Text = "arabe";
            //enMenuItem.Text = "Anglais";
            //frMenuItem.Text = "Français";
            //enMenuItem.Checked = false;
            //arMenuItem.Checked = false;
            //frMenuItem.Checked = true;
            //this.RightToLeft = RightToLeft.No;
            //this.RightToLeftLayout = false;
            SetLang();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.RightToLeft = RightToLeft.Yes;
            //this.RightToLeftLayout = true;
            SetLang();

        }

        private void EnMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLang.lang = Lang.en;
            //langMenu.Text = "Language";
            //arMenuItem.Text = "Arabic";
            //enMenuItem.Text = "English";
            //frMenuItem.Text = "French";

            //enMenuItem.Checked = true;
            //arMenuItem.Checked = false;
            //frMenuItem.Checked = false;
            //this.RightToLeft = RightToLeft.No;
            //this.RightToLeftLayout = false;
            SetLang();
        }

        private void ArMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLang.lang = Lang.ar;
            //langMenu.Text = "اللغة";
            //arMenuItem.Text = "عربي";
            //enMenuItem.Text = "انجليزي";
            //frMenuItem.Text = "فرنسي";
            //enMenuItem.Checked = false;
            //frMenuItem.Checked = false;
            //arMenuItem.Checked = true;
            //this.RightToLeft = RightToLeft.Yes;
            //this.RightToLeftLayout = true;
            SetLang();
        }


        private void SetLang()
        {
            LangValue = ChangeLang.GetLangProperties(this);
            button1.Text = LangValue["btntext"].ToString();

        }


    }
}
