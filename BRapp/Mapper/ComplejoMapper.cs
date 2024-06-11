using BRapp.Enums;
using BRapp.Model;
using BRapp.Model.Tiendas;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class ComplejoMapper : IMapper
    {
        public object Map(SqliteDataReader reader)
        {
            byte[] imagenData = Convert.FromBase64String(reader["organigrama"].ToString());
            string logo = "";
            if (imagenData.Length != 0) logo = "organigrama.jpg";
            Fichero fichero = new Fichero(logo, imagenData);

            return new Complejo
                   (
                       Guid.Parse(reader["id"].ToString()),
                       reader["name"].ToString(),
                       fichero,
                       (TipoComplejo)Enum.Parse(typeof(TipoComplejo), reader["tipo_complejo"].ToString()),
                       Convert.ToInt32(reader["orden"].ToString()),
                       reader["descripcion"].ToString()
                   );
        }

        public object Map(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
