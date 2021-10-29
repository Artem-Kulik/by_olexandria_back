using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using by_olexandria_back.Models.Configuration;
using by_olexandria_back.Models.Dto;
using by_olexandria_back.Models.Dto.ResultDto;
using by_olexandria_back.Models.Entities;
using by_olexandria_back.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace by_olexandria_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public AccountController(ApplicationContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public ResultDto getWorshipTypes()
        {
            //_context.WorshipTypes.AddAsync(new WorshipType { Type = "Evening" });
            //_context.SaveChanges();
            var types = _context.WorshipTypes.Select(x => new WorshipTypeDto
            {
                Id = x.Id,
                Type = x.Type
            }).ToList();

            return new CollectionResultDto<WorshipTypeDto>()
            {
                IsSuccessful = true,
                Data = types
            };
        }
    }
}