using Microsoft.Web.WebView2.Core;
using System.Text.RegularExpressions;
using System.Web.Helpers;

namespace ScappingWeb
{
    public partial class Form1 : Form
    {
        public static Stack<string> UrlsStack = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
            webView21.EnsureCoreWebView2Async();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
               
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.marinetraffic.com/en/ais/details/ships/shipid:316/mmsi:311000307/imo:9387554/vessel:KAOMBO_SUL");
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var html = await webView21.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML;");
            html = Regex.Unescape(html);
            html = html.Remove(0, 1);
            html = html.Remove(html.Length - 1, 1);
            textBox1.Text = html;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
          await webView21.CoreWebView2.ExecuteScriptAsync(scriptText.Text);
        }

        private async void runBtn_Click(object sender, EventArgs e)
        {
            var urls = File.ReadAllLines(@"urls.txt");
            var script = File.ReadAllText(@"script.txt");
            for (var i = 0; i < urls.Length; i += 1)
            {
                UrlsStack.Push(urls[i]);

            }    
            webView21.CoreWebView2.Navigate(UrlsStack.Pop());
                 
        }

        private async void webView21_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            await Task.Delay(5 * 1000);
            var script = File.ReadAllText(@"script.txt");
            await webView21.CoreWebView2.ExecuteScriptAsync(script);
         
            await Task.Delay(15 * 1000);
            label1.Text = "" + (50 - UrlsStack.Count) + " done"; 
            if (UrlsStack.Count > 0)
                webView21.CoreWebView2.Navigate(UrlsStack.Pop());
         //
            //var t = Task.Run(async delegate
            //{
                

            //});
            //t.Wait();   

        }
    }
}