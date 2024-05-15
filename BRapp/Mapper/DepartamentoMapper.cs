using BRapp.Dto;
using BRapp.Enums;
using BRapp.Model.Tiendas;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace BRapp.Mapper
{
    internal class DepartamentoMapper : IMapper
    {   
        public object Map(object objeto)
        {
            Departamento departamento = (Departamento) objeto;
            return new DepartamentoDto()
            {
                id = departamento.Id,
                name = departamento.Name,
                idComplejo = (departamento.Complejo != null) ? departamento.Complejo.Id : Guid.Empty,                
                tipoDepartamento = departamento.DepartamentoTipo
            };
        }

        public object Map(SqliteDataReader reader)
        {
            return new DepartamentoDto()
            {
                id = Guid.Parse(reader["id"].ToString()),
                name = reader["name"].ToString(),
                idComplejo = Guid.Parse(reader["id_complejo"].ToString()),
                tipoDepartamento = (TipoDepartamento)Enum.Parse(typeof(TipoDepartamento), reader["tipo_departamento"].ToString())               
            };
        }
    }
}
