using Microsoft.AspNetCore.Http;
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
        readonly QuizContext context;
        public QuestionController(QuizContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public void Post([FromBody] Models.Question  value) 
        {
            context.Question.Add(value);
            context.SaveChanges();
        }

        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {
            return context.Question;
        }
    }
}
