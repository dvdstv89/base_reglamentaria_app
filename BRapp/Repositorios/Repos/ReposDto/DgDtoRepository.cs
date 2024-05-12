﻿using BRapp.Data;
using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Repositorios.Repos.ReposDto
{
    internal class DgDtoRepository : BaseRepository, IDGDtoRepository
    {
        private static DgDtoRepository instance;       
        private readonly string QUERY_SELECT_ALL_SISTEMAS = "SELECT * FROM DG";
        private readonly string QUERY_UPDATE = "UPDATE DG SET id_responsable = @responsable, numero = @numero WHERE id_papel = @papelId";
        private readonly string QUERY_INSERT = "INSERT INTO DG (id_papel, numero, id_responsable) VALUES ( @papelId, @numero, @responsable)";
        private readonly List<DGDto> dgsDto;
        private readonly IMapper mapperDG;

        private DgDtoRepository() : base(AplicationConfig.ConnectionString, "DG")
        {
            mapperDG = new DGMapper();
            dgsDto = getAll_DgDto();
        }

        private List<DGDto> getAll_DgDto()
        {
            List<DGDto> dgs = new List<DGDto>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL_SISTEMAS))
            {
                while (reader.Read())
                {
                    dgs.Add((DGDto)mapperDG.Map(reader));
                }
            }
            return dgs;
        }

        public DGDto getById(Guid id)
        {
            return dgsDto.FirstOrDefault(doc => doc.idPapel == id);
        }

        private int getIndexById(Guid id)
        {
            return dgsDto.FindIndex(doc => doc.idPapel == id);
        }

        public bool saveOrUpdate(DG papel)
        {
            DGDto dgDto = (DGDto)mapperDG.Map(papel);
            Dictionary<string, object> parametros = buildParametros(dgDto);
            int index = getIndexById(dgDto.idPapel);
            if (index != -1)
            {
                dgsDto[index] = dgDto;
                return ExecuteWriteOperation(QUERY_UPDATE, parametros);
            }
            else
            {
                bool result = ExecuteWriteOperation(QUERY_INSERT, parametros);
                dgsDto.Add(dgDto);
                return result;
            }
        }

        private Dictionary<string, object> buildParametros(DGDto dGDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@responsable", dGDto.idResponsable.ToString() },
                { "@numero", dGDto.numero.ToString() },
                { "@papelId", dGDto.idPapel.ToString() }
            };
            return parametros;
        }

        public static DgDtoRepository Instance
        {
            get
            {
                instance = (instance == null) ? new DgDtoRepository() : instance;
                return instance;
            }
        } 
    }
}