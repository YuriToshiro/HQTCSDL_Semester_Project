using DatGiaoThucAn.NhanVien;

namespace DatGiaoThucAn
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new DangNhap());
            //Application.Run(new Form_AdminMain());
            Application.Run(new Form_mainNhanVien());
        }
    }
}