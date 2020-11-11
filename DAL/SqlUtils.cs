using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlUtils
    {
        /// <summary>
        /// Requête  permettant de se connecter à la bdd et affectée dans une constante
        /// </summary>
        private const string CHAINE_DE_CONNEXION = "server=localhost;database=GestiondeLieu;user=sa;password=Pa$$w0rd";

        /// <summary>
        /// Fonction qui permet d'ouvrir une connexion à la bdd
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = CHAINE_DE_CONNEXION;
            cnx.Open();
            return cnx;
        }
        
    }
}
