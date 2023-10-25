﻿using backend.Contexts;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories {
    public class ProducerRepository : IProducerRepository {
        private readonly DatabaseContext _context;
        
        public ProducerRepository(DatabaseContext context) {
            _context = context;
        }

        public async Task<Producer?> FindByEmail(string email) {
            
            return await this._context.Producers.FirstOrDefaultAsync(producer => producer.Email == email);    

        }

        public async Task<Producer?> FindById(Guid id) {
            return await this._context.Producers.FirstOrDefaultAsync(producer => producer.Id == id);
        }

        public IEnumerable<Producer> GetNearProducers(string city) {
            var producers = this._context.Producers
                .Where(producer => producer.Attended_Cities.Contains(city.ToUpper()))
                .Include(producer => producer.Products)
                .ToList();

            return producers;
        }

        public IEnumerable<Product> GetProducts(Guid producerId) {
            //var products = this._context.Producers.Include(producer => producer.Products).SingleOrDefault(producer => producer.Id.Equals(producerId));
            var products = this._context.Producers
                .Where(producer => producer.Id == producerId)
                .SelectMany(producer => producer.Products)
                .ToList();
            
            return products;
        }

        public async Task<Producer> Save(Producer producer) {
            var createdProducer = await this._context.Producers.AddAsync(producer);
            await this._context.SaveChangesAsync();
            return createdProducer.Entity;
        }
    }
}
