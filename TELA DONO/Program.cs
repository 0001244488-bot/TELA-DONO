namespace TELA_DONO
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new usúario_e_pets.Form1());
        }
    }
}
