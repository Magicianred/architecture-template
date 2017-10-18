﻿using ArchitectureTemplate.Domain.Interfaces.Services;
using ArchitectureTemplate.Infraestrutura.CrossCutting.Support.Extensions;
using ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities;
using ArchitectureTemplate.Infrastructure.WCF.Contracts.ServiceInterfaces;
using System.Collections.Generic;
using System.Linq;

namespace ArchitectureTemplate.Infrastructure.WCF.Services
{
    public class ScreenManager : IScreenServiceContract
    {
        private readonly ITelaService _telaService;

        public ScreenManager(ITelaService telaService)
        {
            _telaService = telaService;
        }

        public ScreenContract GetById(int id)
        {
            var tela = _telaService.GetId(id);
            return tela.Cast<ScreenContract>();
        }

        public ScreenContract GetByName(string name)
        {
            var tela = _telaService.Get(t => t.Nome == name);
            return tela.Cast<ScreenContract>();
        }

        public IEnumerable<ScreenContract> GetTelas(string key)
        {
            var telaList = _telaService
                .GetList(t => t.Nome.Contains(key)
                    || t.ControllerName.Contains(key))
                .ToList();

            return telaList.CastAll<ScreenContract>();
        }

        public IEnumerable<ScreenContract> GetTelas(int idBegin, int idEnd)
        {
            var telaList = _telaService
                .GetList(t => t.Id >= idBegin && t.Id <= idEnd)
                .ToList();

            return telaList.Cast<ScreenContract>();
        }
    }
}