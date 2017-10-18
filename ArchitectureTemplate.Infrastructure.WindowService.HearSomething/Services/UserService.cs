﻿using ArchitectureTemplate.Domain.Interfaces.Services;

namespace ArchitectureTemplate.Infrastructure.WindowService.HearSomething.Services
{
    public class UserService
    {
        private readonly IUsuarioService _usuarioService;

        public UserService(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public void Action()
        {
            var getUsers = _usuarioService.GetAll();
        }
    }
}