﻿using backend.Models;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Factories.Producer
{
    public class ProducerFactory
    {

        private backend.Models.Producer ProducerEntity = new backend.Models.Producer {
            Name = "Producer Test",
            Email = "test@test.com",
            CreatedAt = DateTime.Now,
            FavdByConsumers = new List<ConsumerFavProducer>(),
            Password = "123",
            Telephone = "(31) 99999-9999",
            WhereToFind = "Local de encontro",
            Location = new Point(new Coordinate(0,0))
        };

        public ProducerFactory WithId(Guid id)
        {
            ProducerEntity.Id = id;
            return this;
        }

        public ProducerFactory WithName(string name)
        {
            ProducerEntity.Name = name;
            return this;
        }

        public ProducerFactory WithEmail(string email)
        {
            ProducerEntity.Email = email;
            return this;
        }

        public ProducerFactory WithFavdByConsumers(List<ConsumerFavProducer> favd)
        {
            ProducerEntity.FavdByConsumers = favd;
            return this;
        }

        public ProducerFactory WithPassword(string password)
        {
            ProducerEntity.Password = password;
            return this;
        }

        public ProducerFactory WithTelephone(string telephone)
        {
            ProducerEntity.Telephone = telephone;
            return this;
        }

        public ProducerFactory WithWhereToFind(string whereToFind)
        {
            ProducerEntity.WhereToFind = whereToFind;
            return this;
        }

        public ProducerFactory WithLocation(Coordinate coordinate) {
            ProducerEntity.Location = new Point(coordinate);
            return this;
        }

        public backend.Models.Producer Build() {
            return ProducerEntity;
        }
    }
}
