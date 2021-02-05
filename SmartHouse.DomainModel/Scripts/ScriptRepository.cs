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
        ScriptModel Add(ScriptModel script);
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

        public ScriptModel Add(ScriptModel script)
        {
            _scripts.TryAdd(script.Id, script);
            return script;
        }
    }
}
