using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loja
{
    public partial class produtos : System.Web.UI.Page
    {

        public string obj_produto;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj_produto = new Produtos().Montar_produtos();
           
        }
    }
}