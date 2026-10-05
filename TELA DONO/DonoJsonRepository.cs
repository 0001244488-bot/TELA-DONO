using System.Text.Json;

namespace TELA_DONO
{
    public sealed class DonoJsonRepository
    {
        private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };
        private readonly string _filePath;

        public DonoJsonRepository()
        {
            var directory = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "TelaDono");
            Directory.CreateDirectory(directory);
            _filePath = Path.Combine(directory, "donos.json");
        }

        public List<Dono> Listar()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Dono>();
            }

            return JsonSerializer.Deserialize<List<Dono>>(File.ReadAllText(_filePath)) ?? new List<Dono>();
        }

        public void Adicionar(Dono dono)
        {
            var donos = Listar();
            if (donos.Any(item => NormalizarCpf(item.Cpf) == NormalizarCpf(dono.Cpf)))
            {
                throw new InvalidOperationException("Já existe um dono cadastrado com este CPF.");
            }

            dono.Id = donos.Count == 0 ? 1 : donos.Max(item => item.Id) + 1;
            donos.Add(dono);
            SalvarArquivo(donos);
        }

        public void Atualizar(Dono dono)
        {
            var donos = Listar();
            var indice = donos.FindIndex(item => item.Id == dono.Id);
            if (indice < 0)
            {
                throw new InvalidOperationException("O dono selecionado não foi encontrado.");
            }

            if (donos.Any(item => item.Id != dono.Id && NormalizarCpf(item.Cpf) == NormalizarCpf(dono.Cpf)))
            {
                throw new InvalidOperationException("Já existe um dono cadastrado com este CPF.");
            }

            donos[indice] = dono;
            SalvarArquivo(donos);
        }

        public void Excluir(int id)
        {
            var donos = Listar();
            if (donos.RemoveAll(item => item.Id == id) == 0)
            {
                throw new InvalidOperationException("O dono selecionado não foi encontrado.");
            }

            SalvarArquivo(donos);
        }

        private void SalvarArquivo(List<Dono> donos)
        {
            File.WriteAllText(_filePath, JsonSerializer.Serialize(donos, JsonOptions));
        }

        private static string NormalizarCpf(string cpf)
        {
            return new string(cpf.Where(char.IsDigit).ToArray());
        }
    }
}
