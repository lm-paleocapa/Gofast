namespace NameMessageRecived
{
    using System;
    using System.Collections.Generic;
    using NameJson;
    using System.IO;
    using System.Windows.Forms;
    using System.Drawing;

    using NameChat;
    class ClassMessageRecived
    {
        public class ClassOne
        {
            public static ListView listViewRecentChat;
            public static PictureBox pictureBoxImage;
            public static Label labelNoChats;
            public static Panel panelLogin;
            public static Panel panelRecentChat;
            public static List<ClassChat> chats = new List<ClassChat>(); // Tutti i pannelli.

            public static void One(ClassJson json)
            {
                if (json.pok && json.uok)
                {
                    if (!string.IsNullOrEmpty(json.image))
                    {
                        var pic = Convert.FromBase64String(json.image);
                        MemoryStream ms = new MemoryStream(pic);
                        pictureBoxImage.Invoke(new Action(() => pictureBoxImage.Image = Image.FromStream(ms)));
                    }
                    else
                    {
                        var pic = Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAB20lEQVR42mL8//8/w2AGTAyDHIw6cNg7kAWXBCMjIynm8AOxOhB7ALEWFIsCcS4QryHFIIxMCxLAhokEzEA8DYj/gIzCgScD8UwgLgViNmIciOIOCh2Yj8dh2HAOqQ6kNA0mk6jeid6ZRItE9aL0diAziep56OlAfjp4aHgX1NJk6PlFTFFDrXLwCYlFDAxvJ8U9jLgcQ0RNQm477TUQixFbk1ASxd/J1PeLXmnwApn6ptMrDQoB8WoS0583vetiUM3wgUjHbSEnwCh1IKx+/UbAcSBPKA6UA0HAjIADbchNcpQUM+jV3gc8uZad3AYrtaq6L3jk3g2GPokrkmMeQcvIeqTQ5SfbZCqkQVDR8Raa1vYiiSuiVW/S9MokckAcDsTzgfg5WmaYgKe+/gP1QCM0xHmo6UBQoVxHRAMBvQuwgoB6kINDKHWgGZaQwoWN0RyYQ0ILh4ccB5oRUQgjRyEnmgONSagGz4Na3KQ6cCMJFtzA0cT/TIIZ4aR2O41JyM1CWPoc/CT2QyxJLQclSOxS+qGJJWCJdpK6sfgcyElGLywWjZ9Gon4hWhTUyADUIXoFTU8HqFFxULvbCWoYLIOyZ1HFRCqHIAgYQEORkxruYRwdRB/uDgQIMADK7J2uzc976AAAAABJRU5ErkJggg==");
                        MemoryStream ms = new MemoryStream(pic);
                        pictureBoxImage.Invoke(new Action(() => pictureBoxImage.Image = Image.FromStream(ms)));
                    }

                    if (json.friends.Count != 0)
                    {
                        // Schermata di caricamento.......
                        // Creazione delle chats.

                        foreach (var i in json.friends)
                        {
                            string[] row = { i.user };
                            var item = new ListViewItem(row);
                            listViewRecentChat.Invoke(new Action(() => listViewRecentChat.Items.Add(item)));

                            bool ok = false;
                            foreach (var z in ClassThree.messages)
                            {
                                if (z.user == i.user)
                                    ok = true;
                            }

                            if (!ok)
                            {
                                ClassUsersMessages users = new ClassUsersMessages
                                {
                                    user = i.user
                                };
                                ClassThree.messages.Add(users);
                            }

                            ok = false;
                            foreach (var k in chats)
                            {
                                if (k.name == i.user)
                                    ok = true;

                            }
                            if (!ok)
                            {
                                // Creazione del pannelo.
                            }
                        }
                    }
                    else
                    {
                        listViewRecentChat.Invoke(new Action(() => listViewRecentChat.Enabled = false));
                        labelNoChats.Invoke(new Action(() => labelNoChats.Visible = true));
                    }
                    panelLogin.Invoke(new Action(() => panelLogin.Hide()));
                    panelRecentChat.Invoke(new Action(() => panelRecentChat.Show()));
                }
            }
        }
        public class ClassTwo
        {
            public static Label labelPassword;
            public static Label labelUser;
            public static TextBox tbPassword;
            public static TextBox tbUser;
            public static void Two(ClassJson json)
            {
                if (!json.pok && !json.uok)
                {
                    labelPassword.Invoke(new Action(() => labelPassword.ForeColor = Color.Red));
                    labelUser.Invoke(new Action (() => labelUser.ForeColor = Color.Red));
                    tbPassword.Invoke(new Action(() => tbPassword.Clear()));
                    tbUser.Invoke(new Action(() => tbUser.Clear()));
                    return;
                }

                if (!json.uok)
                {
                    labelPassword.Invoke(new Action(() => labelPassword.ForeColor = Color.Red));
                    labelUser.Invoke(new Action(() => labelUser.ForeColor = Color.Red));
                    tbPassword.Invoke(new Action(() => tbPassword.Clear()));
                    tbUser.Invoke(new Action(() => tbUser.Clear()));
                    return;
                }

                if (!json.pok)
                {
                    labelPassword.Invoke(new Action(() => labelPassword.ForeColor = Color.Red));
                    tbPassword.Invoke(new Action(() => tbPassword.Clear()));
                    return;
                }
            }
        }
        public class ClassThree
        {
            public static List<ClassUsersMessages> messages = new List<ClassUsersMessages>();
            public static void Three(ClassJson json)
            {
                foreach (var i in messages)
                {
                    if (i.user == json.from)
                    {
                        ClassMessage message = new ClassMessage
                        {
                            date = json.date,
                            message = json.message,
                            messageType = json.messageType
                        };
                        i.messages.Add(message);
                    }
                }
            }
        }
    }
}