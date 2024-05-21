using BRapp.Data;
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
        private readonly string QUERY_SELECT_ALL = "SELECT * FROM TipoGrupoDocumentacion";
        private readonly string QUERY_UPDATE = "UPDATE TipoGrupoDocumentacion SET name = @name, descripcion = @descripcion, tipo_indicacion = @tipo_indicacion WHERE id = @Id";
        private readonly string QUERY_INSERT = "INSERT INTO TipoGrupoDocumentacion (id, name, descripcion, tipo_indicacion) VALUES ( @Id, @name, @descripcion, @tipo_indicacion)"; 
        private List<TipoGrupoDocumentacion> tipoGrupoDocumentacions;      
        private readonly IMapper tipoGrupoDocumentacionMapper;

        public TipoGrupoDocumentacionRepository(IMapper tipoGrupoDocumentacionMapper) :base(AplicationConfig.ConnectionString, "TipoGrupoDocumentacion")
        {
            this.tipoGrupoDocumentacionMapper = tipoGrupoDocumentacionMapper;
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
                        apps.Add((TipoGrupoDocumentacion)tipoGrupoDocumentacionMapper.Map(reader));
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
                { "@tipo_indicacion", tipoGrupoDocumentacion.TipoIndicacion },
                { "@Id", tipoGrupoDocumentacion.Id.ToString() }
            };          
            return parametros;
        }
       
    }
}
