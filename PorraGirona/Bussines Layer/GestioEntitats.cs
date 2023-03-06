using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PorraGirona.DataLayer;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace PorraGirona.Bussines_Layer
{
    class GestioEntitats
    {
        String connectionString = Globals.connectionString;
        PostDbContext context;
        public GestioEntitats()
        {
            context = new PostDbContext();
        }
        public List<Penyistes> LlegirPenyistes()
        {
            return (context.Penyistes.OrderBy(p => p.Nom).ToList());
        }
        public Boolean InserirPenyista(Penyistes penyista)
        {
            Boolean result = false;
            try
            {
                List<Penyistes> llista_penysites_trobats;
                llista_penysites_trobats = context.Penyistes.FromSqlRaw("SELECT * FROM penyistes where nif={0}", penyista.Nif).ToList<Penyistes>();
                if (llista_penysites_trobats.Count == 0)
                {
                    context.Penyistes.Add(penyista);
                    result = (context.SaveChanges() > 0);
                }


            } catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                result = false;
            }
            return true;



            
        }

        public Boolean EsborrarPenyista(Penyistes penyista)
        {
            Boolean result = false;
            if(penyista != null)
            {
                try
                {

                    context.Penyistes.Remove(penyista);
                    result = (context.SaveChanges() > 0);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    result = false;
                }

            }

            return result;

        }

    }

    
}
