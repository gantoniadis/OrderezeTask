using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Models;
using System.Web.ModelBinding;

namespace WingtipToys
{
    public partial class ImageDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<WingtipToys.Models.Image> GetImage([QueryString("Id")] int? Id)
        {
            var _db = new WingtipToys.Models.ImageContext();
            IQueryable<WingtipToys.Models.Image> query = _db.Images;
            if (Id.HasValue )
            {
                query = query.Where(p => p.Id == Id);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}