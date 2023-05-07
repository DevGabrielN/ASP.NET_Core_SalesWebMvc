using SalesWebMvc.Data;

namespace SalesWebMvc
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            _env = env;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configuração do DbContext e outros serviços aqui
            services.AddScoped<SeedingService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, SeedingService seedingService)
        {
            if (env.IsDevelopment())
            {
                seedingService.Seed(); // Chama o método Seed da classe SeedingService
            }

            // Outras configurações aqui
        }
    }
}
