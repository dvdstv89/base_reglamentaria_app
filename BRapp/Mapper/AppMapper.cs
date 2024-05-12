using BRapp.Model;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class AppMapper : IMapper
    {
        public object Map(SqliteDataReader reader)
        {
            byte[] imagenData = Convert.FromBase64String(reader["organigrama"].ToString());
            string logo = "";
            if (imagenData.Length != 0) logo = "organigrama.jpg";
            Fichero fichero = new Fichero(logo, imagenData);

            return new App
                   (
                       Convert.ToInt32(reader["Id"].ToString()),
                       reader["fecha_actualizacion"].ToString(),
                       reader["copyright"].ToString(),
                       reader["empresa"].ToString(),
                       reader["mision"].ToString(),
                       reader["vision"].ToString(),
                       reader["objeto_social"].ToString(),
                       reader["valores_compartidos"].ToString(),
                       fichero
                   );
        }

        public object Map(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
