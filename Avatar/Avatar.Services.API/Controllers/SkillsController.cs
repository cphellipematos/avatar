﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Avatar.Infra.Data.Repository.UoW;
using Swashbuckle.AspNetCore.SwaggerGen;
using Avatar.Application.ViewModel;
using Avatar.Application.Interfaces;
using Avatar.Application.Service;

namespace Avatar.Services.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/skill")]
    public class SkillsController : BaseController
    {
        protected ISkillAppService _skillAppService;

        public SkillsController(UnitOfWork uow, SkillAppService skillAppService)
            :base(uow)
        {
            _skillAppService = skillAppService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad Request</response> 
        [HttpGet]
        [SwaggerOperation("GetSkills")]
        [SwaggerResponse(200, type: typeof(IEnumerable<SkillViewModel>))]
        public virtual IActionResult GetSkills()
        {
            try
            {
                var skillsCommand = _skillAppService.GetSkills();
                return ReturnResponse(skillsCommand);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }
        }
    }
}