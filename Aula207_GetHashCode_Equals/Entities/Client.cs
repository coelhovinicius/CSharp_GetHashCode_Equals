/* >>> CLASSE CLIENT <<< */
namespace Aula207_GetHashCode_Equals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        // Operacoes Equals e GetHashCode customizadas para evitar clientes duplicados
        public override bool Equals(object obj)
        {
            if (!(obj is Client)) // Programacao defensiva para verificar se "obj" e "Client"
            {
                return false;
            }
            Client other = obj as Client; // Downcasting
            return Email.Equals(other.Email); // Retorna True ou False na comparacao dos emails
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode(); // Retorna o codigo do email
        }
    }
}
