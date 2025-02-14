using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Models
{
    public class Atleta
    {
        [Key]
        public int AtletaId { get; set; }
        public string? NomeAtleta { get; set; }
        public string? EmailAtleta { get; set; }
        public string? Senha {  get; set; }
        public string? NumeroTelefone { get; set; }
        public uint? PartidasJogadas { get; set; }
        public uint? PartidasGanhas { get; set; }
        public uint? PartidasPerdidas { get; set; }
        [JsonIgnore]
        public ICollection<Partidas> Partidas { get; set; }
        public int PartidasId {  get; set; }    
    }
}
