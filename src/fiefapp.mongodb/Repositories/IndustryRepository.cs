using fiefapp.entities;
using fiefapp.entities.BaseClasses;
using fiefapp.entities.Interfaces;
using fiefapp.services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.mongodb.Repositories
{
    class IndustryRepository : IIndustryRepository
    {
        private readonly IMongoCollection<Felling> _fellings;
        private readonly IMongoCollection<Income> _incomes;
        private readonly IMongoCollection<Market> _markets;
        private readonly IMongoCollection<Mine> _mines;
        private readonly IMongoCollection<Port> _ports;
        private readonly IMongoCollection<Quarry> _quarries;
        private readonly IMongoCollection<Shipyard> _shipyards;
        private readonly IMongoCollection<Subsidiary> _subsidiaries;

        private readonly IMongoDatabase _database;

        public IndustryRepository(IDatabaseSettings settings)
        {
            if (!string.IsNullOrEmpty(settings.ConnectionString))
            {
                var client = new MongoClient(settings.ConnectionString);

                _database = client.GetDatabase(settings.DatabaseName);

                _fellings = _database.GetCollection<Felling>("Felling");
                _incomes = _database.GetCollection<Income>("Income");
                _markets = _database.GetCollection<Market>("Market");
                _mines = _database.GetCollection<Mine>("Mine");
                _ports = _database.GetCollection<Port>("Port");
                _quarries = _database.GetCollection<Quarry>("Quarry");
                _shipyards = _database.GetCollection<Shipyard>("Shipyard");
                _subsidiaries = _database.GetCollection<Subsidiary>("Subsidiary");
            }
        }

        public async Task<ICollection<Industry>> GetIndustriesForFief(Guid fiefId)
        {
            var list = new List<Industry>();

            list.AddRange(await _fellings.Find(e => e.FiefId == fiefId).ToListAsync());
            list.AddRange(await _incomes.Find(e => e.FiefId == fiefId).ToListAsync());
            list.AddRange(await _markets.Find(e => e.FiefId == fiefId).ToListAsync());
            list.AddRange(await _mines.Find(e => e.FiefId == fiefId).ToListAsync());
            list.AddRange(await _ports.Find(e => e.FiefId == fiefId).ToListAsync());
            list.AddRange(await _quarries.Find(e => e.FiefId == fiefId).ToListAsync());
            list.AddRange(await _shipyards.Find(e => e.FiefId == fiefId).ToListAsync());
            list.AddRange(await _subsidiaries.Find(e => e.FiefId == fiefId).ToListAsync());

            return list;
        }
    }
}
