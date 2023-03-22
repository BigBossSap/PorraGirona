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

        public List<Puntuacions> LlegirPuntuacions()
        {
            var llista_puntuacions = context.Puntuacions.ToList();
            foreach(var puntuacio in llista_puntuacions)
            {

                context.Entry(puntuacio).Reload();
            }

            return (context.Puntuacions.OrderByDescending(m => m.Puntuacio).ToList());
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

        public Boolean CalcularPuntuacioEntity()
        {
            PostDbContext context = new PostDbContext();
            List<Partits> llista_partits;
            Boolean result = true;
            Puntuacions puntuacio;

            try
            {
                int registers_affected = context.Database.ExecuteSqlRaw("TRUNCATE TABLE puntuacions");

                List<Penyistes> llistatPenyistes = new List<Penyistes>();
                llistatPenyistes = context.Penyistes.ToList<Penyistes>();

                Penyistes penyista;
                for(int i =0; i<llistatPenyistes.Count();i++)
                {
                    penyista = llistatPenyistes[i];
                    List<Porres> llistatPorres = new List<Porres>();
                    llistatPorres = context.Porres.Where(porra_aux => porra_aux.Idpenyista == penyista.Idpenyista).ToList<Porres>();
                    puntuacio = new Puntuacions();
                    puntuacio.Idpenyista = penyista.Idpenyista;
                    puntuacio.Alias = penyista.Alias;
                    puntuacio.Puntuacio = 0;

                    Porres porra;

                    for (int j =0; j<llistatPorres.Count(); j++)
                    {

                        porra = llistatPorres[j];
                        llista_partits = context.Partits.Where(partit_aux => partit_aux.Idpartit == porra.Idpartit
                         && partit_aux.Finalitzat.Equals("SI")).ToList<Partits>();

                        if (llista_partits != null)
                        {
                            if(llista_partits.Count>0)
                            {
                                Partits partits = llista_partits[0];
                                puntuacio.Puntuacio = puntuacio.Puntuacio + CalcularPuntsPorra(porra, partits);
                            }

                        }

                    }

                    context.Puntuacions.Add(puntuacio);
                }

                result = result && (context.SaveChanges() > 0);


               
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                result = false;
            }

            return result;
        }
        /* 6.- Esborrem tota la taula de puntuacions
        3.- Iterem per penyistes, encara que hi hagi penyistes que no han fet cap porra
        //no Iterem per cada porra, perquè igual hi ha penyistes que no han fet cap porra
        {
            //4.- Iterem per cada porra que ha fet el penyista
            {
                //5.- Recuperem el partit de la porra i que el partit hagi finalitzat
                //Ara ja tenim les tres dades: penyista, partits, porra

                //1.- Comencem pel que volem obtenir
                //Dades d'entrada: porra i partit
                //Dada de sortida: punts
                puntuacions.Idpenyista = penyista.Idpenyista;
                puntuacions.puntuacio = CalculaPuntsPorra(partit, porra);
		   2.- Guardar a la Base dades les puntuacions */

        public int CalcularPuntsPorra(Porres porra, Partits partit)
        {
            int punts = 0;
            int guanyador = 0;
            int guanyadorPorra = 0;
            if (partit.Golsvisitant > partit.Golslocal)
                guanyador = 2;
            else
                guanyador = 1;
            if (porra.Golsvisitant > porra.Golslocal)
                guanyadorPorra = 2;
            else
                guanyadorPorra = 1;

            if (porra.Golslocal == partit.Golslocal && porra.Golsvisitant == partit.Golsvisitant)
                punts = 5;

            else if (porra.Golslocal == partit.Golslocal +1 || porra.Golsvisitant == partit.Golsvisitant +1 )
                punts = 2;

            else if (porra.Golslocal == partit.Golslocal && porra.Golsvisitant != partit.Golsvisitant)
                punts = 4;

            else if (porra.Golslocal != partit.Golslocal && porra.Golsvisitant == partit.Golsvisitant)
                punts = 4;
            else if (guanyadorPorra == guanyador)
                punts = 3;

            return punts;

        }

    }
}
 


    

    

