﻿namespace OfficialChat.Lib.Client
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
    public class WS
    {
        private static WebSocket ws = new WebSocket("ws://127.0.0.1:8181");
        public static void Open()
        {
            ws.MessageReceived += ms;
            ws.Open();
        }
        public static void Close()
        {
            ws.Close();
        }
        public static void Send(string ms)
        {
            ws.Send(ms);
        }
        public static void ms(object sender, MessageReceivedEventArgs e)
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
            }
        }

        public static List<userLeft> panelUserLeft = new List<userLeft>();
        public class ClassOne
        {
            public static Panel panelForControl;
            public static void One(JSON json)
            {
                panelForControl.Invoke(new Action(() =>
                {
                    panelForControl.Size = new Size(876, 612);
                    foreach (UserControl i in panelForControl.Controls)
                        i.Visible = false;
                    panelForControl.Controls.Add(Form1.MainChat);
                }));

                new Thread(() =>
               {
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

                   Form1.MainChat.myUser.Invoke(new Action(() =>
                   {
                       Form1.MainChat.myUser.image = Image.FromStream(ms);
                   }));
               }).Start();
            }
        }
        public class ClassTwo
        {
            public static void Two(JSON json)
            {
                if (!json.uok && !json.pok)
                {
                    Form1.loginPage.Invoke(new Action(() =>
                    {
                        if (Form1.loginPage.tbUser.pictureBoxTop == 41 && Form1.loginPage.tbUser.typingBoxTop == 37)
                        {
                            Form1.loginPage.tbUser.pictureBoxTop -= 15;
                            Form1.loginPage.tbUser.typingBoxTop -= 15;
                        }
                        Form1.loginPage.tbUser.labelErrorControl.Visible = true;
                        Form1.loginPage.tbUser.labelErrorControl.Text = "The user not exist";
                        Form1.loginPage.tbUser.labelErrorControl.ForeColor = Color.FromArgb(204, 0, 0);

                        Form1.loginPage.tbPassword.labelErrorControl.ForeColor = Color.FromArgb(204, 0, 0);
                        Form1.loginPage.tbPassword.labelErrorControl.Text = "Error";
                        Form1.loginPage.tbPassword.labelErrorControl.Visible = true;
                    }));
                }
                if (json.uok && !json.pok)
                {
                    Form1.loginPage.Invoke(new Action(() =>
                    {
                        Form1.loginPage.tbPassword.labelErrorControl.ForeColor = Color.FromArgb(204, 0, 0);
                        Form1.loginPage.tbPassword.labelErrorControl.Text = "Error";
                        Form1.loginPage.tbPassword.labelErrorControl.Visible = true;
                    }));
                }
            }
        }
        public class ClassThree
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
                        Form1.registerPage.typingBoxConfirmPassword.text = "Confirm password";
                        Form1.registerPage.typingBoxMail.text = "Mail";
                        Form1.registerPage.typingBoxPassword.text = "Password";
                        Form1.registerPage.typingBoxUser.text = "Username";
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
                            Form1.registerPage.typingBoxMail.labelErrorControl.Text = "the mail is already used";
                            Form1.registerPage.typingBoxMail.labelErrorControl.ForeColor = Color.FromArgb(204, 0, 0);
                            Form1.registerPage.typingBoxMail.labelErrorControl.Visible = true;
                        }
                        else if (json.mok && !json.uok)
                        {
                            Form1.registerPage.typingBoxUser.labelErrorControl.Text = "The name is already used";
                            Form1.registerPage.typingBoxUser.labelErrorControl.ForeColor = Color.FromArgb(204, 0, 0);
                            Form1.registerPage.typingBoxUser.labelErrorControl.Visible = true;
                        }
                        else
                        {
                            Form1.registerPage.typingBoxUser.labelErrorControl.Text = "The name is already used";
                            Form1.registerPage.typingBoxUser.labelErrorControl.ForeColor = Color.FromArgb(204, 0, 0);
                            Form1.registerPage.typingBoxUser.labelErrorControl.Visible = true;

                            Form1.registerPage.typingBoxMail.labelErrorControl.Text = "the mail is already used";
                            Form1.registerPage.typingBoxMail.labelErrorControl.ForeColor = Color.FromArgb(204, 0, 0);
                            Form1.registerPage.typingBoxMail.labelErrorControl.Visible = true;
                        }
                        Form1.registerPage.typingBoxConfirmPassword.text = "";
                        Form1.registerPage.typingBoxConfirmPassword.text = "";
                    }));
                }
            }
        }
    }
}