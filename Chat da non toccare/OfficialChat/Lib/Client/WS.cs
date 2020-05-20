namespace OfficialChat.Lib.Client
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.IO;
    using System.Drawing;
    using System.Threading;
    using WebSocket4Net;
    using Newtonsoft.Json;
    using Bunifu.Framework.UI;
    using Chat.Controls;
    using System.Management;

    public class WS
    {
        //private static WebSocket ws = new WebSocket("ws://80.182.17.185:8181");
        private static WebSocket ws = new WebSocket("ws://127.0.0.1:8181");
        private static List<string> toSend = new List<string>();
        public static void Open()
        {
            ws.MessageReceived += ms;
            ws.Open();
            new Thread(() =>
            {
                int k = 5000;
                while (true)
                {
                    if (ws.State != WebSocketState.Open)
                    {
                        try
                        {
                            ws.Open();
                            Thread.Sleep(100);
                        }
                        catch
                        {

                        }
                        if (ws.State == WebSocketState.Open)
                            k = 0;
                        else
                            k = 5000;
                    }
                    else if (ws.State == WebSocketState.Open)
                    {
                        foreach (var i in toSend)
                        {
                            ws.Send(i);
                        }
                        toSend.Clear();
                    }
                    Thread.Sleep(k);
                }
            })
            { IsBackground = true }.Start();
        }
        public static void Close()
        {
            ws.Close();
        }
        public static void Send(JSON ms)
        {
            string item = JsonConvert.SerializeObject(ms);
            if (ws.State == WebSocketState.Open)
            {
                ws.Send(item);
            }
            else
                toSend.Add(item);
        }
        private static void ms(object sender, MessageReceivedEventArgs e)
        {
            JSON json = JsonConvert.DeserializeObject<JSON>(e.Message);
            switch (json.id)
            {
                case 1:
                    {
                        ClassOne.One(json);
                        break;
                    }
                case 2:
                    {
                        ClassTwo.Two(json);
                        break;
                    }
                case 3:
                    {
                        ClassThree.Three(json);
                        break;
                    }
                case 4:
                    {
                        ClassFour.Four(json);
                        break;
                    }
                case 5:
                    {
                        ClassFive.Five(json);
                        break;
                    }
                case 6:
                    {
                        ClassSix.Six(json);
                        break;
                    }
                case 7:
                    {
                        ClassSeven.Seven(json);
                        break;
                    }
                case 8:
                    {
                        ClassHeight.Height(json);
                        break;
                    }
            }
        }
        public class ClassOne
        {
            public static Panel panelForControl;
            public static void One(JSON json)
            {
                Form1.username = json.username;
                Form1.MainChat = new Chat.mainChatControl();
                panelForControl.Invoke(new Action(() =>
                {
                    panelForControl.Size = new Size(876, 612);
                    panelForControl.Controls.Clear();
                    panelForControl.Controls.Add(Form1.MainChat);
                }));

                MemoryStream ms;
                foreach (var i in json.friends)
                {
                    var pic = Convert.FromBase64String(i.image);
                    ms = new MemoryStream(pic);

                    userLeft user = new userLeft
                    {
                        name = i.user,
                        lastAccess = "Da mettere",
                        picture = Image.FromStream(ms),
                        Dock = DockStyle.Top
                    };
                    Form1.MainChat.panelUsers.Invoke(new Action(() => Form1.MainChat.panelUsers.Controls.Add(user)));
                }

                var pic1 = Convert.FromBase64String(json.image);
                ms = new MemoryStream(pic1);

                Image img = resizeImage(Image.FromStream(ms), new Size(90, 90));
                Image resizeImage(Image imgToResize, Size size)
                {
                    return (new Bitmap(imgToResize, size));
                }
                Form1.panelUserSetting.userImage = img;
                Form1.panelUserSetting.defaultImage = img;

                Form1.MainChat.myUser.Invoke(new Action(() =>
                {
                    Form1.MainChat.myUser.image = Image.FromStream(ms);
                }));

                Form1.loginPage.Invoke(new Action(() => Form1.loginPage.controlEnabled = true));
                JSON json1 = new JSON
                {
                    id = 8,
                    username = Form1.username,
                };
                WS.Send(json1);
            }
        }
        private class ClassTwo
        {
            public static void Two(JSON json)
            {
                Form1.loginPage.Invoke(new Action(() => Form1.loginPage.controlEnabled = true));
                if (!json.uok && !json.pok)
                {
                    Form1.loginPage.Invoke(new Action(() =>
                    {
                        Form1.loginPage.lbUsername.Visible = true;
                        Form1.loginPage.lbUsername.Text = "The user not exist";
                        Form1.loginPage.lbUsername.ForeColor = Color.FromArgb(204, 0, 0);

                        Form1.loginPage.lbPassword.ForeColor = Color.FromArgb(204, 0, 0);
                        Form1.loginPage.lbPassword.Text = "Error";
                        Form1.loginPage.lbPassword.Visible = true;
                    }));
                }
                if (json.uok && !json.pok)
                {
                    Form1.loginPage.Invoke(new Action(() =>
                    {
                        Form1.loginPage.lbPassword.ForeColor = Color.FromArgb(204, 0, 0);
                        Form1.loginPage.lbPassword.Text = "Error";
                        Form1.loginPage.lbPassword.Visible = true;
                    }));
                }
            }
        }
        private class ClassThree
        {
            public static void Three(JSON json)
            {
                foreach (Panel i in Form1.MainChat.flowLayoutPanelChat.Controls)
                {
                    if (i.Name == json.from)
                    {
                        if (json.messageType == "string")
                        {
                            YouBubble bubble = new YouBubble
                            {
                                Body = json.message,
                                Dock = DockStyle.Bottom
                            };
                            i.Invoke(new Action(() => i.Controls.Add(bubble)));
                        }
                    }
                }
            }
        }
        public class ClassFour
        {
            public static BunifuFlatButton btn;
            public static void Four(JSON json)
            {
                btn.Invoke(new Action(() => btn.Enabled = true));
                if (json.uok)
                {
                    Register.RegisterPage.userImage = "";
                    Form1.registerPage.Invoke(new Action(() =>
                    {
                        Form1.registerPage.numericUpDown.Value = 1;
                        Form1.registerPage.cPassword = "Confirm password";
                        Form1.registerPage.mail = "Mail";
                        Form1.registerPage.password = "Password";
                        Form1.registerPage.username = "Username";
                    }));

                    Register.RegisterPage.panelDown.Invoke(new Action(() =>
                    {
                        Register.RegisterPage.panelDown.Size = new Size(463, 493);
                        foreach (UserControl i in Register.RegisterPage.panelDown.Controls)
                            i.Visible = false;
                        Register.RegisterPage.panelDown.Controls.Add(Form1.loginPage);
                        Form1.loginPage.Show();
                    }));

                    MessageBox.Show("Registered!");
                }
                else
                {
                    Form1.registerPage.Invoke(new Action(() =>
                    {
                        if (json.mok && json.uok)
                        {
                            MessageBox.Show("ok");
                        }
                        else if (!json.mok && json.uok)
                        {
                            Form1.registerPage.lbMail.Text = "the mail is already used";
                            Form1.registerPage.lbMail.ForeColor = Color.FromArgb(204, 0, 0);
                            Form1.registerPage.lbMail.Visible = true;
                        }
                        else if (json.mok && !json.uok)
                        {
                            Form1.registerPage.lbUsername.Text = "The name is already used";
                            Form1.registerPage.lbUsername.ForeColor = Color.FromArgb(204, 0, 0);
                            Form1.registerPage.lbUsername.Visible = true;
                        }
                        else
                        {
                            Form1.registerPage.lbUsername.Text = "The name is already used";
                            Form1.registerPage.lbUsername.ForeColor = Color.FromArgb(204, 0, 0);
                            Form1.registerPage.lbUsername.Visible = true;

                            Form1.registerPage.lbMail.Text = "the mail is already used";
                            Form1.registerPage.lbMail.ForeColor = Color.FromArgb(204, 0, 0);
                            Form1.registerPage.lbMail.Visible = true;
                        }
                        Form1.registerPage.tbPassword.Text = "Password";
                        Form1.registerPage.tbCPassword.Text = "Confirm password";
                        Form1.registerPage.numericUpDown.Value = 1;
                    }));
                }
            }
        }
        private class ClassFive
        {
            public static void Five(JSON json)
            {
                new Thread(() =>
                {
                    Thread.Sleep(5000); // Tempo di attesa da regolare

                    foreach (Panel i in Form1.MainChat.flowLayoutPanelChat.Controls)
                    {
                        foreach (var k in json.ms)
                        {
                            if (i.Name == k.from)
                            {
                                if (k.messageType == "string")
                                {
                                    YouBubble bubble = new YouBubble
                                    {
                                        Body = k.message,
                                        Dock = DockStyle.Bottom
                                    };
                                    i.Invoke(new Action(() => i.Controls.Add(bubble)));
                                }
                            }
                        }
                    }
                }).Start();
            }
        }
        public class ClassSix
        {
            public static Panel panel;
            public static void Six(JSON json)
            {
                panel.Invoke(new Action(() =>
                {
                    panel.Controls.Clear();
                }));
                MemoryStream ms;
                foreach (var i in json.friends)
                {
                    var pic = Convert.FromBase64String(i.image);
                    ms = new MemoryStream(pic);

                    userToAdd user = new userToAdd
                    {
                        name = i.user,
                        picture = Image.FromStream(ms),
                        Dock = DockStyle.Top
                    };
                    panel.Invoke(new Action(() =>
                    {
                        bool ok = false;
                        foreach (userLeft k in Form1.MainChat.panelUsers.Controls)
                            if (k.name == i.user)
                                ok = true;
                        if (!ok)
                            panel.Controls.Add(user);
                    }));
                }
            }
        }
        private class ClassSeven
        {
            public static void Seven(JSON json)
            {
                MessageBox.Show("Aggiornato");
            }
        }
        public class ClassHeight
        {
            public static void Height(JSON json)
            {
                List<requestItem> items = new List<requestItem>();
                foreach (var i in json.friends)
                {
                    var img = Convert.FromBase64String(i.image);
                    MemoryStream ms = new MemoryStream(img);
                    requestItem item = new requestItem
                    {
                        Name = i.user,
                        Username = i.user,
                        Image = Image.FromStream(ms),
                        Dock = DockStyle.Top
                    };
                    items.Add(item);
                }

                new Thread(() =>
                {
                    if (Form1.rq.IsHandleCreated)
                    {
                        foreach (var s in items)
                            Form1.rq.Invoke(new Action(() => Form1.rq.panelForItem.Controls.Add(s)));
                    }
                })
                { IsBackground = true }.Start();
            }
        }
    }
}