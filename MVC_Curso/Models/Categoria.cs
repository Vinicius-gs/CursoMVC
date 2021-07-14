using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Curso.Models
{
    [Keyless]
    public class Categoria
    {
        private int Id { get; set; }
        private string Descricao { get; set; }
    }
}
