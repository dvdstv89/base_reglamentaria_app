﻿using BRapp.Dto;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Repositorios.Repos.ReposDto;
using BRapp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Services.Services
{
    public class GrupoDocumentacionService : IGrupoDocumentacionService
    {
        private static GrupoDocumentacionService instance;
        protected readonly ITipoGrupoDocumentacionService tipoGrupoDocumentacionService;
        protected readonly IGrupoDocumentacionDtoRepository grupoDocumentacionDtoRepository;
        protected readonly IPapelService papelService;

        public GrupoDocumentacionService()
        {
            tipoGrupoDocumentacionService = TipoGrupoDocumentacionService.Instance;
            grupoDocumentacionDtoRepository = GrupoDocumentacionDtoRepository.Instance;
            papelService = PapelService.Instance;
        }

        public static GrupoDocumentacionService Instance
        {
            get
            {              
                instance = (instance == null) ? new GrupoDocumentacionService() : instance;
                return instance;
            }
        }

        public List<GrupoDocumentacion> getAll()
        {
            List<GrupoDocumentacion> grupoDocumentacions = new List<GrupoDocumentacion>();
            List<GrupoDocumentacionDto> grupoDocumentacionDtos = grupoDocumentacionDtoRepository.getAll();
            foreach (GrupoDocumentacionDto grupo in grupoDocumentacionDtos)
            {
                Documento documento = (Documento)papelService.getById(grupo.idDocumento);
                TipoGrupoDocumentacion tipoGrupoDocumentacion = tipoGrupoDocumentacionService.getById(grupo.idTipoGrupoDocumentacion);
                grupoDocumentacions.Add(new GrupoDocumentacion(grupo, tipoGrupoDocumentacion, documento));
            }
            return grupoDocumentacions;
        }
        public GrupoDocumentacion getById(Guid id)
        {
            return getAll().FirstOrDefault(g => g.Id == id);
        }
    }
}