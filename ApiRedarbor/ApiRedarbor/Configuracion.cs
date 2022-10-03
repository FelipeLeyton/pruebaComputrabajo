namespace ApiRedarbor
{
    public class Configuracion
    {
        public static IConfiguration AppSetting { get; }
        static Configuracion()
        {
            AppSetting = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
        }
    }
}
