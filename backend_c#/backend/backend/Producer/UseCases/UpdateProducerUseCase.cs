﻿using System;
using System.Threading.Tasks;
using backend.Producer.DTOs;
using backend.Producer.Repository;

namespace backend.Producer.UseCases;

public class UpdateProducerUseCase{
    private readonly IProducerRepository repository;

    public UpdateProducerUseCase(IProducerRepository repository){
        this.repository = repository;
    }

    public async Task<Models.Producer> Execute(UpdateProducerDTO updateProducerDTO){
        var possibleProducer = await repository.FindById(updateProducerDTO.Id);

        if (possibleProducer == null) throw new Exception("Produtor não existe");

        var producerEntity = new Models.Producer{
            Id = updateProducerDTO.Id,
            Name = updateProducerDTO.Name ?? possibleProducer.Name,
            Email = updateProducerDTO.Email ?? possibleProducer.Email,
            Password = updateProducerDTO.Password ?? possibleProducer.Password,
            Telephone = updateProducerDTO.Telephone ?? possibleProducer.Telephone,
            WhereToFind = updateProducerDTO.WhereToFind ?? possibleProducer.WhereToFind,
            UpdatedAt = DateTime.Now
        };

        var updatedProducer = repository.Update(producerEntity);

        return updatedProducer.Result;
    }
}