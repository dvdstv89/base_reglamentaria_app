using BRapp.Enums;
using BRapp.Model.Nomenclador;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class MenuDocumentalMapper : IMapper
    {
        public object Map(object objeto)
        {
            throw new NotImplementedException();
        }

        public object Map(SqliteDataReader reader)
        {
            return new MenuDocumental()
            {
                Id = Guid.Parse(reader["id"].ToString()), 
                Name = reader["name"].ToString(),
                Descripcion = reader["descripcion"].ToString(),
                ShowPanelBusqueda = Convert.ToBoolean(reader["show_panel_busqueda"]),
                ShowArchivados = Convert.ToBoolean(reader["show_archivados"]),
                IsRaiz = Convert.ToBoolean(reader["is_raiz"]),
                AbrirPagina = Convert.ToBoolean(reader["abrir_pagina"]),
                TipoUbicacionMenu = (TipoUbicacionMenu)Enum.Parse(typeof(TipoUbicacionMenu), reader["ubicacion_menu"].ToString()),
                Orden = Convert.ToInt32(reader["orden"].ToString())
            };
        }
    }
}
