using System;
using System.Linq;
using SmartHouse.DomainModel.Scripts;
using SmartHouse.Presentation.Common;
using SmartHouse.Presentation.Views;
using SmartHouse.Presentation.Views.ViewModels;

namespace SmartHouse.Presentation.Presenters
{
    public class ScenariosPresenter : BasePresener<IScenariosView>, IDisposable
    {
        private const string NewScriptDefaultName = "Новый скрипт";
        private readonly IScriptRepository _scriptRepository;

        public ScenariosPresenter(IApplicationController controller, 
            IScenariosView view, 
            IScriptRepository scriptRepository) 
            : base(controller, view)
        {
            _scriptRepository = scriptRepository;
            View.NewScript += NewScript;
            View.EditScript += EditScript;
            View.RemoveScript += RemoveScript;

            SetSourceScripts();
        }

        private void RemoveScript(ScriptViewModel scriptViewModel)
        {
            _scriptRepository.Remove(scriptViewModel.Id);
            SetSourceScripts();
        }

        private void EditScript(ScriptViewModel scriptViewModel)
        {
            var script = _scriptRepository.Get(scriptViewModel.Id);
            RunEditScript(script);
        }

        private void NewScript()
        {
            var script = new ScriptModel()
            {
                Name = NewScriptDefaultName
            };
            RunEditScript(script);
        }

        private void RunEditScript(ScriptModel script)
        {
            Controller.Run<EditScenarioPresenter, ScriptModel>(script);
            SetSourceScripts();
        }

        private void SetSourceScripts()
        {
            View.SourceScripts = _scriptRepository
                .Get()
                .Select(o => new ScriptViewModel()
                {
                    Id = o.Id,
                    Name = o.Name
                })
                .ToList();
        }

        public void Dispose()
        {
            View.NewScript -= NewScript;
            View.EditScript -= EditScript;
            View.RemoveScript -= RemoveScript;
        }
    }
}
