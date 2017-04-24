using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
namespace ParsingBashorg
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            string code = new WebClient().DownloadString("http://bash.im/random");
            doc.LoadHtml(code);
            var result = doc.DocumentNode.SelectNodes("//div[@class='text']");
            foreach(HtmlNode node in result)
            {
                richTextBox1.Text += node.InnerText+ "\n\n";
            }
        }

        
    }
}
