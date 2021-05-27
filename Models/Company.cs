using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialFit.Models
{
	public class Company
	{
		public virtual Client Cliente { get; set; }
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Cnpj {get; set;}
		public string Endereco { get; set; }
	}
}
