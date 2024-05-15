﻿using BRapp.Data;
using BRapp.Repositorios.Interfaces;
using BRapp.Mapper;
using System;
using System.Collections.Generic;
using BRapp.Model.Tiendas;
using System.Linq;

namespace BRapp.Repositorios.Repos
{
    public class TipoGrupoDocumentacionRepository : BaseRepository, ITipoGrupoDocumentacionRepository
    {
        private static TipoGrupoDocumentacionRepository instance; 

        private readonly string QUERY_SELECT_ALL = "SELECT * FROM TipoGrupoDocumentacion";
        private readonly string QUERY_UPDATE = "UPDATE TipoGrupoDocumentacion SET name = @name, descripcion = @descripcion WHERE id = @Id";
        private readonly string QUERY_INSERT = "INSERT INTO TipoGrupoDocumentacion (id, name, descripcion) VALUES ( @Id, @name, @descripcion)"; 
        private List<TipoGrupoDocumentacion> tipoGrupoDocumentacions;      
        private readonly IMapper mapperTipoGrupoDocumentacion;

        protected TipoGrupoDocumentacionRepository():base(AplicationConfig.ConnectionString, "TipoGrupoDocumentacion")
        {
            mapperTipoGrupoDocumentacion = new TipoGrupoDocumentacionMapper();  
            updateListApp();

        }

        protected void updateListApp()
        {
            tipoGrupoDocumentacions = getAll();
        }

        public List<TipoGrupoDocumentacion> getAll()
        {
            List<TipoGrupoDocumentacion> apps = new List<TipoGrupoDocumentacion>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        apps.Add((TipoGrupoDocumentacion)mapperTipoGrupoDocumentacion.Map(reader));
                    }
                }
            }
            return apps;
        }      

        public TipoGrupoDocumentacion getById(Guid id)
        {
            return tipoGrupoDocumentacions.FirstOrDefault(persona => persona.Id == id);
        }

        private int getIndexById(Guid id)
        {
            return tipoGrupoDocumentacions.FindIndex(doc => doc.Id == id);
        }

        public bool saveOrUpdate(TipoGrupoDocumentacion tipoGrupoDocumentacion)
        {
            Dictionary<string, object> parametros = buildParametros(tipoGrupoDocumentacion);
            int index = getIndexById(tipoGrupoDocumentacion.Id);
            if (index != -1)
            {
                tipoGrupoDocumentacions[index] = tipoGrupoDocumentacion;
                return ExecuteWriteOperation(QUERY_UPDATE, parametros);
            }
            else
            {
                bool result = ExecuteWriteOperation(QUERY_INSERT, parametros);
                tipoGrupoDocumentacions.Add(tipoGrupoDocumentacion);
                return result;
            }
        }

        private Dictionary<string, object> buildParametros(TipoGrupoDocumentacion tipoGrupoDocumentacion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@name", tipoGrupoDocumentacion.Name },
                { "@descripcion", tipoGrupoDocumentacion.Descripcion },
                { "@Id", tipoGrupoDocumentacion.Id.ToString() }
            };          
            return parametros;
        }

        public static TipoGrupoDocumentacionRepository Instance
        {
            get
            {                
                instance = (instance == null) ? new TipoGrupoDocumentacionRepository() : instance;
                return instance;
            }
        } 
    }
}