﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100,ErrorMessage ="O tamanho maximo é de 100 caracteres")]
        [Required(ErrorMessage ="Informe o Nome da Categoria")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }


        [StringLength(200, ErrorMessage = "O tamanho maximo é de 200 caracteres")]
        [Required(ErrorMessage = "Informe a Descrição da Categoria")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }



        //Definindo o relacionamento - 1 Para N
        public List<Lanche> Lanches { get; set; }


    }
}
