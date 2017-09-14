using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loja
{
    public partial class carrinho : System.Web.UI.Page
    {
        public string obj_carrinho;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj_carrinho = new Carrinho().MontaCarrinhoVazio();
        }
    }
}