using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


using CefSharp;
using CefSharp.WinForms;
using System.IO;

namespace Test47
{
    public partial class Form1 : Form
    {

        public ChromiumWebBrowser chromeBrowser;

        private Bitmap captureBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);

        private DateTime NextShot = new DateTime();
        private Random random = new Random();
        private DateTime curShot = DateTime.Now;

        private int keyStrokeCount = 0;
        private int mouseClickCount = 0;


        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("http://ourcodeworld.com");
            // Add it to the form and fill it to the form window.
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        public Form1()
        {
            InitializeComponent();
            // Start the browser after initialize global component
            //InitializeChromium();
        }

        private MouseHook mh;
        private GlobalKeyboardHook _globalKeyboardHook;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName.ToString() + ' ' + Application.ProductVersion;
            mh = new MouseHook();
            mh.SetHook();
            mh.MouseClickEvent += mh_MouseClickEvent;
            //mh.KeyBoardEvent += mh_KeyBoardEvent;

            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardPressed += KeyBoardEvent;

            timer1.Enabled = true;
            NextShot = curShot.AddMinutes(random.Next(1, 2));
            nextCaptureTime.Text = NextShot.ToString();
        }


        private void mh_MouseClickEvent(object sender, MouseEventArgs e)
        {
            mouseClickCount = mh.clickCount;
            mclickCount.Text = mouseClickCount.ToString();

        }


        private void KeyBoardEvent(object sender, GlobalKeyboardHookEventArgs e)
        {
            // EDT: No need to filter for VkSnapshot anymore. This now gets handled
            // through the constructor of GlobalKeyboardHook(...).
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown)
            {
                // Now you can access both, the key and virtual code
                ///Keys loggedKey = e.KeyboardData.Key;
                //int loggedVkCode = e.KeyboardData.VirtualCode;
                //                kstrokCount.Text = loggedKey.ToString();
                keyStrokeCount++;
                kstrokCount.Text = keyStrokeCount.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cef.Shutdown();
            mh.UnHook();
        }



        
        private Bitmap CaptureMyScreen()
        {
            try
            {
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

                lastCaptureTime.Text = curShot.ToString();
                NextShot = curShot.AddMinutes(random.Next(1, 2));
                nextCaptureTime.Text = NextShot.ToString();

                captureBitmap.SetResolution(10, 10);
               // captureBitmap.Save(Application.StartupPath + "\\capture_" + curShot.ToFileTime() + ".jpg", ImageFormat.Jpeg);
                return captureBitmap;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new  Bitmap(50, 50, PixelFormat.Format32bppArgb);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            curShot = DateTime.Now;
            CurrentTime.Text = curShot.ToString();

            if (curShot > NextShot)
            {
                NextShot = curShot.AddMinutes(random.Next(1, 2));
                nextCaptureTime.Text = NextShot.ToString();
                lastCapture.Image = CaptureMyScreen();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            lastCapture.Image = CaptureMyScreen();
            lastCapture.Image.Save(Application.StartupPath + "\\capture_" + curShot.ToFileTime() + ".jpg", ImageFormat.Jpeg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lastCapture.Image = CaptureMyScreen();
            _ = uploadLstShotAsync();
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private static string ImageToBase64(Image image)
        {
            var imageStream = new MemoryStream();
            image.Save(imageStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            imageStream.Position = 0;
            var imageBytes = imageStream.ToArray();
            var ImageBase64 = Convert.ToBase64String(imageBytes);
            return ImageBase64;
            
        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        private async Task uploadLstShotAsync()
        {
            //lastCapture.Image;
            //ServerURL
            //UserKey
            //keyStrokeCount
            //mouseClickCount
            //curShot
            Image.GetThumbnailImageAbort myCallback =                new Image.GetThumbnailImageAbort(ThumbnailCallback);



            //var wid = (lastCapture.Image.Width*300) / lastCapture.Image.Height ;
            ///MessageBox.Show(dddd.ToString());

            string myJson =  JsonSerializer.Serialize(new
            {
                AppVersion = Application.ProductVersion,
                UserKey = UserKey.Text,
                curShot = curShot.ToString(),
                keyStrokeCount = keyStrokeCount.ToString(),
                mouseClickCount = mouseClickCount.ToString(),
                //lastCaptureImage = ImageToBase64(lastCapture.Image.GetThumbnailImage(400, (400/ lastCapture.Image.Width)*lastCapture.Height,null, IntPtr.Zero))
                lastCaptureImage = ImageToBase64(resizeImage(lastCapture.Image, new Size((lastCapture.Image.Width * 300) / lastCapture.Image.Height, 300)))
            });


            
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(
                    ServerURL.Text,
                     new StringContent(myJson, Encoding.UTF8, "application/json"));
            }


            keyStrokeCount = 0;
            kstrokCount.Text = keyStrokeCount.ToString();

            mouseClickCount = mh.clickCount= 0;
            mclickCount.Text = mouseClickCount.ToString();


        }
    }
}
