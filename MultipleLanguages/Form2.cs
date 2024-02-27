using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleLanguages.App
{
    public partial class Form2 : Form
    {
        private JObject LangValue = new JObject();
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
            LangValue = ChangeLang.GetLangProperties(this);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Text = LangValue["btntext"].ToString();

            dataGridView1.Columns["Column1"].HeaderText = LangValue["col1"].ToString();
            dataGridView1.Columns["Column2"].HeaderText = LangValue["col2"].ToString();



        }
    }
}
