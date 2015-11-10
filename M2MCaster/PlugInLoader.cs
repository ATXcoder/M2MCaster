using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace M2MCaster
{
    public class PlugInLoader<T>
    {
        private CompositionContainer _Container;

        [ImportMany]
        public IEnumerable<T> Plugins
        {
            get;
            set;
        }

        public PlugInLoader(string path)
        {
            DirectoryCatalog directoryCatalog = new DirectoryCatalog(path);

            var catalog = new AggregateCatalog(directoryCatalog);

            _Container = new CompositionContainer(catalog);

            _Container.ComposeParts(this);
        }
    }
}
