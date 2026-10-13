namespace usúario_e_pets
{
    public static class ConfiguracaoBanco
    {
        // Configure PETSHOP_CONNECTION_STRING no Windows para usar a senha do seu MySQL.
        // O fallback considera MySQL local com usuário root e senha vazia.
        public static string ConnectionString =>
            Environment.GetEnvironmentVariable("PETSHOP_CONNECTION_STRING")
            ?? "server=localhost;database=petshop_tecnico;uid=root;pwd=;";
    }
}
