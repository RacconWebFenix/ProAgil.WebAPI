using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProAgil.WebAPI.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Local deve ter entre 3 e 100 caracteres.")]
        public string Local { get; set; }
        public string DataEvento { get; set; }
        [Required(ErrorMessage = "O Tema é obrigatório.")]
        public string Tema { get; set; }
        [Range(2, 120000, ErrorMessage = "Quantidade de Pessoas é entre 2 e 120000")]
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }
        [Phone]
        public string Telefone { get; set; }
        [EmailAddress(ErrorMessage = "O email deve ser válido.")]
        public string Email { get; set; }
        public List<LoteDto> Lotes { get; set; }
        public List<RedeSocialDto> RedesSociais { get; set; }
        public List<PalestranteDto> Palestrantes { get; set; }
    }
}