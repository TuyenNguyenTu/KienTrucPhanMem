using Project.KienTrucPhanMem.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Project.KienTrucPhanMem.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly KienTrucPhanMemDbContext _context;

        public InitialHostDbBuilder(KienTrucPhanMemDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
