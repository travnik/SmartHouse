using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace SmartHouse.DomainModel.Scripts
{
    public interface IScriptRepository
    {
        IEnumerable<ScriptModel> Get();
        ScriptModel Get(Guid id);
        ScriptModel AddOrUpdate(ScriptModel script);
        void Remove(Guid id);
    }

    public class ScriptRepository : IScriptRepository
    {
        private static readonly ConcurrentDictionary<Guid, ScriptModel> _scripts = new ConcurrentDictionary<Guid, ScriptModel>();

        public IEnumerable<ScriptModel> Get()
        {
            return _scripts.Values.ToList();
        }

        public ScriptModel Get(Guid id)
        {
            return _scripts[id];
        }

        public ScriptModel AddOrUpdate(ScriptModel script)
        {
            _scripts.AddOrUpdate(script.Id, script, (guid, model) => model);
            return script;
        }

        public void Remove(Guid id)
        {
            _scripts.TryRemove(id, out _);
        }
    }
}
