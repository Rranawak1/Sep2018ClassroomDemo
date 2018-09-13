using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Chinook.Data.Entities;
using ChinookSystem.DAL;
using System.ComponentModel;
#endregion


namespace ChinookSystem.BLL
{
    [DataObject]
    public class AlbumController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Artist> ALbum_List()
        {
            using (var context = new ChinookContext())
            {
                return context.Artists.ToList();
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Artist Album_Find(int artistID)
        {
            using (var context = new ChinookContext())
            {
                return context.Artists.Find(artistID);
            }
        }
    }
}