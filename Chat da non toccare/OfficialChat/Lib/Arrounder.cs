namespace OfficialChat.Lib
{
    using System;
    using System.Runtime.InteropServices;
    class Arrounder
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );   
    }
}
//this.FormBorderStyle = FormBorderStyle.None;
//Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));