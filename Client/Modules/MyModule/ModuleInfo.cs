using Oqtane.Models;
using Oqtane.Modules;

namespace OqTenants.MyModule
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "MyModule",
            Description = "Example module",
            Version = "1.0.0",
            ServerManagerType = "OqTenants.Manager.MyModuleManager, OqTenants.Server.Oqtane",
            ReleaseVersions = "1.0.0",
            Dependencies = "OqTenants.Shared.Oqtane",
            PackageName = "OqTenants" 
        };
    }
}
