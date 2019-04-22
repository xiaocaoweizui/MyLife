﻿using MyLift.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MyLift.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MyLiftDbContext _context;

        public InitialHostDbBuilder(MyLiftDbContext context)
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
