using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using usúario_e_pets;

namespace TELA_DONO
{
    // Mantém a API usada pela tela original, mas compartilha a tabela MySQL "donos"
    // com o cadastro de pets. O nome da classe foi mantido para não quebrar a tela.
    public sealed class DonoMySqlRepository
    {
        private MySqlConnection AbrirConexao()
        {
            var conexao = new MySqlConnection(ConfiguracaoBanco.ConnectionString);
            try
            {
                conexao.Open();
                GarantirEstrutura(conexao);
                return conexao;
            }
            catch
            {
                conexao.Dispose();
                throw;
            }
        }

        private static void GarantirEstrutura(MySqlConnection conexao)
        {
            const string criarTabela = @"
                CREATE TABLE IF NOT EXISTS donos (
                    id_dono INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                    cpf VARCHAR(14) NULL,
                    nome VARCHAR(150) NOT NULL,
                    telefone VARCHAR(30) NULL,
                    email VARCHAR(150) NULL,
                    endereco VARCHAR(255) NULL
                ) ENGINE=InnoDB;";
            using (var cmd = new MySqlCommand(criarTabela, conexao))
                cmd.ExecuteNonQuery();

            GarantirColuna(conexao, "cpf", "VARCHAR(14) NULL");
            GarantirColuna(conexao, "nome", "VARCHAR(150) NULL");
            GarantirColuna(conexao, "telefone", "VARCHAR(30) NULL");
            GarantirColuna(conexao, "email", "VARCHAR(150) NULL");
            GarantirColuna(conexao, "endereco", "VARCHAR(255) NULL");
        }

        private static void GarantirColuna(MySqlConnection conexao, string coluna, string definicao)
        {
            const string sql = @"
                SELECT COUNT(*)
                FROM information_schema.columns
                WHERE table_schema = DATABASE()
                  AND table_name = 'donos'
                  AND column_name = @coluna;";
            using var verificar = new MySqlCommand(sql, conexao);
            verificar.Parameters.AddWithValue("@coluna", coluna);
            if (Convert.ToInt32(verificar.ExecuteScalar()) == 0)
            {
                using var adicionar = new MySqlCommand($"ALTER TABLE donos ADD COLUMN `{coluna}` {definicao};", conexao);
                adicionar.ExecuteNonQuery();
            }
        }

        public List<Dono> Listar()
        {
            using var conexao = AbrirConexao();
            const string sql = @"SELECT id_dono,
                COALESCE(cpf, '') AS cpf, COALESCE(nome, '') AS nome,
                COALESCE(telefone, '') AS telefone, COALESCE(email, '') AS email,
                COALESCE(endereco, '') AS endereco
                FROM donos ORDER BY nome;";
            using var cmd = new MySqlCommand(sql, conexao);
            using var reader = cmd.ExecuteReader();
            var resultado = new List<Dono>();
            while (reader.Read())
            {
                resultado.Add(new Dono
                {
                    Id = Convert.ToInt32(reader["id_dono"]),
                    Cpf = reader["cpf"].ToString() ?? "",
                    Nome = reader["nome"].ToString() ?? "",
                    Telefone = reader["telefone"].ToString() ?? "",
                    Email = reader["email"].ToString() ?? "",
                    Endereco = reader["endereco"].ToString() ?? ""
                });
            }
            return resultado;
        }

        public void Adicionar(Dono dono)
        {
            using var conexao = AbrirConexao();
            VerificarCpfDuplicado(conexao, dono.Cpf, null);
            const string sql = @"INSERT INTO donos (cpf, nome, telefone, email, endereco)
                VALUES (@cpf, @nome, @telefone, @email, @endereco);";
            using var cmd = new MySqlCommand(sql, conexao);
            AdicionarParametros(cmd, dono);
            cmd.ExecuteNonQuery();
            dono.Id = checked((int)cmd.LastInsertedId);
        }

        public void Atualizar(Dono dono)
        {
            using var conexao = AbrirConexao();
            VerificarCpfDuplicado(conexao, dono.Cpf, dono.Id);
            const string sql = @"UPDATE donos SET cpf=@cpf, nome=@nome, telefone=@telefone,
                email=@email, endereco=@endereco WHERE id_dono=@id;";
            using var cmd = new MySqlCommand(sql, conexao);
            AdicionarParametros(cmd, dono);
            cmd.Parameters.AddWithValue("@id", dono.Id);
            if (cmd.ExecuteNonQuery() == 0)
                throw new InvalidOperationException("O dono selecionado não foi encontrado.");
        }

        public void Excluir(int id)
        {
            using var conexao = AbrirConexao();
            using var cmd = new MySqlCommand("DELETE FROM donos WHERE id_dono=@id;", conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                    throw new InvalidOperationException("O dono selecionado não foi encontrado.");
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                throw new InvalidOperationException("Este dono está associado a um ou mais pets e não pode ser excluído.");
            }
        }

        private static void VerificarCpfDuplicado(MySqlConnection conexao, string cpf, int? idIgnorar)
        {
            string cpfNumerico = NormalizarCpf(cpf);
            const string sql = @"SELECT COUNT(*) FROM donos
                WHERE REPLACE(REPLACE(REPLACE(COALESCE(cpf, ''), '.', ''), '-', ''), ' ', '')=@cpf
                  AND (@idIgnorar IS NULL OR id_dono <> @idIgnorar);";
            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cpf", cpfNumerico);
            cmd.Parameters.AddWithValue("@idIgnorar", (object?)idIgnorar ?? DBNull.Value);
            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                throw new InvalidOperationException("Já existe um dono cadastrado com este CPF.");
        }

        private static void AdicionarParametros(MySqlCommand cmd, Dono dono)
        {
            cmd.Parameters.AddWithValue("@cpf", NormalizarCpf(dono.Cpf));
            cmd.Parameters.AddWithValue("@nome", dono.Nome.Trim());
            cmd.Parameters.AddWithValue("@telefone", dono.Telefone.Trim());
            cmd.Parameters.AddWithValue("@email", dono.Email.Trim());
            cmd.Parameters.AddWithValue("@endereco", dono.Endereco.Trim());
        }

        private static string NormalizarCpf(string? cpf) =>
            new string((cpf ?? "").Where(char.IsDigit).ToArray());
    }
}
