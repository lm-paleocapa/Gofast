namespace OfficialChat.Chat.Controls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.IO;
    using System.Threading;
    using OfficialChat.Lib;
    using OfficialChat.Lib.Client;

    using Newtonsoft.Json;
    public partial class typingBoxChat : UserControl
    {
        public typingBoxChat()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Arrounder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            string mes = box.Text;
            new Thread(() =>
            {
                var pic = Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAAsTAAALEwEAmpwYAAAD3klEQVRYhc2XbUidZRjH/8/RZCvnaWsf0umyGNuiEW5WIARBDPqQFgiesgZJglgp55OOCCIcoxf60JeIMDbCIgiqkRwMGr3QMcSSyK1cJG5m07VMmrWds9Lz68N9Hc/T8fG8uEH9vzzPfV/Xdf//9/t1S/8xvGIDgJCk2yTVSKqSVCZpTtKspJOe5128qgp9xPcBR4DzrI0kEAPagQ2FtJt3BIAGSS9JuttXPStpUq7nlyVVyo3Ibp/PT5KelTTgeV6qsG7+m9gDDvt6twAcAvaavQyoBXYBm6yuGngS+N4XdxzYXCz5RuB9a2AZeBnYbGSHge8Chv8c8AawHyi1aZg324/AzmIEvGOBF4D7ga3A68BSjvn34zNgL3AzcNLqTgNbCyF/xgL+BPYBeyy4WCSBA0AF8K3VfQ5ck4v8VutlCmgGdgO/r4Pcj8eBm8jsnmguAR+a01EgjJu7K8VfQAPwkJV/BSqCyPeZQwKoAV7M13IqlSpUxDdACfCVlZ8OEpDeckeAKtwc5kRPTw/xeLxQEa1AxP7HggScMOMDQFchLba0tFBfX080GmV6ejqfewzYRKZjNZJUauTXSdojaVnSx5KOpYWNjo5qZmYmcM0sLi5KkuLxuEZGRtTa2qr29naVl5cHue+XlJL0hf03SJopNWOVfc95npcAVo7UwcFBDQ0NBQrwY2lpSQMDA4rFYurq6lJjY6NCoZDfpUxSraQzfs6QvyDpLO62q8zLuAYWFhbU19entrY2jY+PZ5sr5e6RVQKuOpLJpBKJRF6/9BSkVW3zPC8FzEnavh7icDiszs5ONTc3q6SkJNs8p8xoz/oFnLXvjcC1kibSApqamlRXVxdI1t/fr/n5eUlSKBRSJBJRR0eHKipWnzNy1/YZuXWwImAFwLhtjweBp4rZht3d3UxNTeVzH8zahtXZAg6Z4ShQiTsRc6K3t5fh4eFCtII7ih+2/69XjQ9QZ8YksB14Pl+LRRzFY7ijeMzKBwPnFPjAHN7EXaOnCmXIgcvAXcAjVj6PZVBBAnYBf5tjBNiJS8WuBI/hEpN0dtQdSO4TcdAcLwJ34HKEyXUQX8LNe5jMPfMJUJpTgIl4ywL+wO2KLcCrZEYnH44DtwM7gAmrmwS25CU3ARuAdy0wBbwC3GANPodLsZazSH8GXgPuwSWlTwC/me0UsKMgcp8Iz8jSS/0C8AJuQXlGsg24BdhoMbVAFPjBJ+wj4PqiyLOE3Al8mtXbX4AvgfeAt82evU5OA48CRT//1hJyLy41n2NtXAKO4VZ+WSHtrudx6sk9waq1+nE64Xle/ivw/4R/ANkprcmYT0Z3AAAAAElFTkSuQmCC");
                MemoryStream ms = new MemoryStream(pic);
                pictureBox.Image = Image.FromStream(ms);
                Thread.Sleep(150);
                pic = Convert.FromBase64String("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");
                ms = new MemoryStream(pic);
                pictureBox.Image = Image.FromStream(ms);
                Thread.Sleep(150);
                box.Invoke(new Action(() =>
                {
                    box.Text = "";
                }));
            }).Start();

            JSON json = new JSON
            {
                id = 2,
                from = mainChatControl.from,
                to = mainChatControl.To,
                message = mes,
                messageType = "string",
                date = DateTime.Now
            };
            string toServer = JsonConvert.SerializeObject(json);
            WS.Send(toServer);

            MeBubble bubble = new MeBubble
            {
                Body = mes,
                Dock = DockStyle.Bottom,
            };
            foreach (Panel i in Form1.MainChat.flowLayoutPanelChat.Controls)
            {
                if (i.Name == mainChatControl.To)
                {
                    i.Controls.Add(bubble);
                }
            }
        }

        private static int n = 0;
        private void box_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(box.Text))
            {
                pictureBox.Visible = true;
                if (n == 0)
                {
                    Size size = new Size();
                    size.Width = box.Width - 40;
                    size.Height = box.Height;
                    box.Size = size;
                    n++;
                }
            }
            else
            {
                pictureBox.Visible = false;
                if (n == 1)
                {
                    Size size = new Size();
                    size.Width = box.Width + 40;
                    size.Height = box.Height;
                    box.Size = size;
                    n--;
                }
            }
        }
        private void typingBox_Load(object sender, EventArgs e)
        {

        }
    }
}