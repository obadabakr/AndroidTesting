using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace WebView1
{
    [Activity(Label = "WebView1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            WebView webv1 = FindViewById<WebView>(Resource.Id.webView1);
            webv1.Settings.JavaScriptEnabled = true;
            //webv1.LoadUrl("www.google.com");
            //webv1.LoadUrl("http://news.alruabye.net/");
            webv1.LoadUrl("file:///android_asset/offers.html");

            webv1.Settings.LoadWithOverviewMode = true;
            webv1.SetWebViewClient(new HelloWebViewClient());

        }
    }

    //load url inside
    public class HelloWebViewClient : WebViewClient
    {
        public override bool ShouldOverrideUrlLoading(WebView view, string url)
        {
            view.LoadUrl(url);
            return true;
        }
        public override void OnPageFinished(WebView view, string url)
        {

        }
    }
}

