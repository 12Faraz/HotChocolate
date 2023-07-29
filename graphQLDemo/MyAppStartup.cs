namespace graphQLDemo
{
    public class MyAppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphQLServer();
        }
    }
}
