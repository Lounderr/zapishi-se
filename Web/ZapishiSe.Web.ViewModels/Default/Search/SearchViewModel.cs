using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapishiSe.Data.Models;

namespace ZapishiSe.Web.ViewModels.Default.Search
{
    public class SearchViewModel
    {
        [Required]
        public string Keywords { get; set; }

        [Required]
        public string Location { get; set; }

        public IEnumerable<ZapishiSe.Data.Models.Business> Businesses { get; set; }
    }
}
