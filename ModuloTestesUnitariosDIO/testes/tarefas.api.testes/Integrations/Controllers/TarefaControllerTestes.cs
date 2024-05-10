using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefas.api.testes.Integrations.Controllers
{
    public class TarefaControllerTestes
    {
        private readonly WebApplicationFactory<Program> _factory;
        public TarefaControllerTestes(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }


        public void ObterTodos()
        {

        }
    }
}
