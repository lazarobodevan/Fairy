﻿using backend.Picture.DTOs;
using backend.Product.DTOs;
using backend.Product.Models;
using backend.Shared.Classes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Product.Repository;

public interface IProductRepository{
    Task<backend.Models.Product> Save(backend.Models.Product product, List<CreateProductPictureDTO> pictures);
    backend.Models.Product? FindById(Guid productId);
    Pagination<backend.Models.Product> GetProducerProducts(Guid producerId, int page, int pageResults, ProductFilterModel? filterModel);
    Pagination<backend.Models.Product> FindByFilter(ProductFilterModel filterModel, int page, int pageResults);
    Task<List<backend.Models.Product>> SaveMany(List<backend.Models.Product> products);
    backend.Models.Product Update(backend.Models.Product product);
    Task<backend.Models.Product> Delete(backend.Models.Product product);
}