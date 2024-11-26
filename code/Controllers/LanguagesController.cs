using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Code.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LanguagesController : ControllerBase
    {
        [HttpGet("list")]
        public IActionResult GetLanguages()
        {
            var languages = new
            {
                ProgrammingLanguages = new List<string>
                {
                    "Java", "Python", "C", "C++", "NodeJS", "JavaScript", "Groovy", "JShell", "Haskell", "Tcl",
                    "Lua", "Ada", "CommonLisp", "D", "Elixir", "Erlang", "F#", "Fortran", "Assembly", "Scala",
                    "PHP", "Python2", "C#", "Perl", "Ruby", "Go", "R", "Racket", "OCaml", "Visual Basic (VB.NET)",
                    "Basic", "Bash", "Clojure", "TypeScript", "Cobol", "Kotlin", "Pascal", "Prolog", "Rust",
                    "Swift", "Objective-C", "Octave", "Text", "BrainFK", "CoffeeScript", "EJS"
                },
                WebLanguages = new List<string>
                {
                    "HTML", "Materialize", "Bootstrap", "JQuery", "Foundation", "Bulma", "Uikit",
                    "Semantic UI", "Skeleton", "Milligram", "PaperCSS", "BackboneJS", "React (Beta)",
                    "Angular (Beta)", "Vue (Beta)", "Vue3 (Beta)"
                },
                DatabaseLanguages = new List<string>
                {
                    "MySQL", "Oracle Database", "PostgreSQL", "MongoDB", "SQLite", "Redis", "MariaDB",
                    "Oracle PL/SQL", "Microsoft SQL Server"
                }
            };

            var jsonResult = JsonConvert.SerializeObject(languages, Formatting.Indented);
            return Content(jsonResult, "application/json");
        }
    }
}
