using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// Représente l'interface de la BLL
    /// </summary>
    /// <typeparam name="Truc"></typeparam>
    interface IcrudBLL<Truc>
    {
        /// <summary>
        /// Represente la fonction create de l'interface  
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Create(Truc item);

        /// <summary>
        /// Représente la fonction Delete de l'interface
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Delete(Truc item);

        /// <summary>
        /// Représente la fonction Update de l'interface 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Update(Truc item);

        /// <summary>
        /// Représente la fonction qui lit un objet 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// 
        Truc Get(Truc item); 


        /// <summary>
        /// Représente la fonction qui lit une liste d'objet 
        /// </summary>
        /// <returns></returns>
        List<Truc> Get();

        Truc itemBuilder(SqlDataReader dr);
    }
}
