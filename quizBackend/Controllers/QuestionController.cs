﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using quizBackend.Models;

namespace quizBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/Question")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] Models.Question  value) 
        {
            
        }

        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {
            return new Models.Question[] {
                 new Models.Question(){ Text = "Hello"},
                 new Models.Question(){ Text = "World"}
            };
        }
    }
}