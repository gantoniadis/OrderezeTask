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
    public partial class ImageList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<WingtipToys.Models.Image> GetImages([QueryString("id")] int? id)
        {
            var _db = new WingtipToys.Models.ImageContext();
            IQueryable<WingtipToys.Models.Image> query = _db.Images;
            if (id > 0)
            {
                query = query.Where(i => i.Id == id);
            }
            return query;
        }
    }
}