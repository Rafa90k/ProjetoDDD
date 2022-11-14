using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities;

public class Notifies
{
    public Notifies()
    {
        Notificacao = new List<Notifies>();
    }

    [NotMapped] public string NomePropiedade { get; set; }

    [NotMapped] public string Mensagem { get; set; }

    [NotMapped] public List<Notifies> Notificacao { get; set; }

    public bool ValidaPropiedadeString(string valor, string nomePropeidade)
    {
        if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropeidade))
        {
            Notificacao.Add(new Notifies
            {
                Mensagem = "Campo Obrigatorio"
            });
            return false;
        }

        return true;
    }
    
    public bool ValidaPropiedadeInt(int valor, string nomePropeidade)
    {
        if (valor < 1 || string.IsNullOrWhiteSpace(nomePropeidade))
        {
            Notificacao.Add(new Notifies
            {
                Mensagem = "Campo Obrigatorio"
            });
            return false;
        }

        return true;
    }
}
