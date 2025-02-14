using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Models
{
    public class Partidas
    {
        [Key]
        public int PartidasId { get; set; }
        public Guid PartidasIdGuid { get; set; }
        public string SenhaPartida {  get; set; }
        public uint? Games {  get; set; }

        [JsonIgnore]
        public ICollection<PartidasGames> PartidasGames { get; set; }
        public uint? PartidasGamesId { get; set; }
    }
}
